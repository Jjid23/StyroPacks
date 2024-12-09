using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace StyroPackPro
{
    public partial class AdminAddProducts : UserControl
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Jobert\OneDrive - MSFT\Documents\StyroPACK.mdf"";Integrated Security=True;Connect Timeout=30");

        public AdminAddProducts()
        {
            InitializeComponent();
            displayAllProducts();
        }

        public void refreshData()
        {
            if(InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                 return;
            }
            displayAllProducts();
        }

        public void displayAllProducts()
        {
            AddProductsData apData = new AddProductsData();
            List<AddProductsData> listdata = apData.AllProductsData();

            DataGridView1.DataSource = listdata;
        }

        public bool emptyFields()
        {
            return addProducts_prodID.Text == "" || addProducts_prodName.Text == "" ||
                   addProducts_price.Text == "" || addProducts_stock.Text == "" ||
                   addProducts_status.SelectedIndex == -1 || addProducts_imageView.Image == null;
        }

        public bool checkConnection()
        {
            if (connect.State == ConnectionState.Closed)
            {
                connect.Open();
                return true;
            }
            return connect.State == ConnectionState.Open;
        }

        private void addProducts_ImportBtn_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog
                {
                    Filter = "Image Files (*.jpg *.png)|*.jpg;*.png"
                };

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    addProducts_imageView.ImageLocation = dialog.FileName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void addProducts_addBtn_Click(object sender, EventArgs e)
        {
            if (emptyFields())
            {
                MessageBox.Show("Empty Fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!checkConnection())
            {
                MessageBox.Show("Database connection failed", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                string selectData = "SELECT * FROM products WHERE prod_id = @prodID";
                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    cmd.Parameters.AddWithValue("@prodID", addProducts_prodID.Text.Trim());

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    if (table.Rows.Count > 0)
                    {
                        MessageBox.Show("Product ID: " + addProducts_prodID.Text.Trim() + " is already existing.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }


                string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
                string relativePath = Path.Combine("Product_Directory", addProducts_prodID.Text.Trim() + ".jpg");
                string path = Path.Combine(baseDirectory, relativePath);

                string directoryPath = Path.GetDirectoryName(path);
                if (!Directory.Exists(directoryPath))
                {
                    Directory.CreateDirectory(directoryPath);
                }
                File.Copy(addProducts_imageView.ImageLocation, path, true);

                string insertData = "INSERT INTO products (prod_id, prod_name, price, stock, image_path, status, date_insert) " +
                                    "VALUES (@prodID, @prodName, @price, @stock, @path, @status, @date)";

                using (SqlCommand insertD = new SqlCommand(insertData, connect))
                {
                    insertD.Parameters.AddWithValue("@prodID", addProducts_prodID.Text.Trim());
                    insertD.Parameters.AddWithValue("@prodName", addProducts_prodName.Text.Trim());
                    insertD.Parameters.AddWithValue("@price", addProducts_price.Text.Trim());
                    insertD.Parameters.AddWithValue("@stock", addProducts_stock.Text.Trim());
                    insertD.Parameters.AddWithValue("@path", path);
                    insertD.Parameters.AddWithValue("@status", addProducts_status.SelectedItem);


                    DateTime today = DateTime.Today;
                    insertD.Parameters.AddWithValue("@date", DateTime.Now);  

                    insertD.ExecuteNonQuery();
                    clearFIelds();
                    displayAllProducts();


                    MessageBox.Show("Added Successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to add product: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connect.Close();
            }
        }

        public void clearFIelds()
        {
            addProducts_prodID.Text = "";
            addProducts_prodName.Text = "";
            addProducts_price.Text = "";
            addProducts_status.SelectedIndex = -1;
            addProducts_stock.Text = "";
            addProducts_imageView.Image = null;
        }

        private void addProducts_clearBtn_Click(object sender, EventArgs e)
        {
            clearFIelds();
        }
        private int getID = 0;
        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = DataGridView1.Rows[e.RowIndex];

                getID = (int)row.Cells[0].Value;
                addProducts_prodID.Text = row.Cells[1].Value.ToString();
                addProducts_prodName.Text = row.Cells[2].Value.ToString();
                addProducts_price.Text = row.Cells[3].Value.ToString();
                addProducts_stock.Text = row.Cells[4].Value.ToString();

                string statusValue = row.Cells[5].Value.ToString();
                addProducts_status.SelectedItem = statusValue;

                string imagepath = row.Cells[7].Value.ToString(); 

                try
                {
                    if (!string.IsNullOrEmpty(imagepath) && File.Exists(imagepath))
                    {
                        using (FileStream fs = new FileStream(imagepath, FileMode.Open, FileAccess.Read))
                        {
                            addProducts_imageView.Image = Image.FromStream(fs);
                        }
                    }
                    else
                    {
                        addProducts_imageView.Image = null;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading image: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }



        private void addProducts_updateBtn_Click(object sender, EventArgs e)
        {
            if (emptyFields())
            {
                MessageBox.Show("Empty Fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("Are you sure you want to update Product ID: " + addProducts_prodID.Text.Trim() + "?",
                                "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            if (!checkConnection())
            {
                MessageBox.Show("Database connection failed.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                string path = HandleImageSave(addProducts_prodID.Text.Trim());

                string updateData = "UPDATE products SET prod_id = @prodID, prod_name = @prodName, price = @price, " +
                    "stock = @stock, image_path = @path, status = @status WHERE id = @id"; // Removed last_updated

                using (SqlCommand updateD = new SqlCommand(updateData, connect))
                {
                    updateD.Parameters.AddWithValue("@prodID", addProducts_prodID.Text.Trim());
                    updateD.Parameters.AddWithValue("@prodName", addProducts_prodName.Text.Trim());
                    updateD.Parameters.AddWithValue("@price", Convert.ToDecimal(addProducts_price.Text.Trim()));
                    updateD.Parameters.AddWithValue("@stock", Convert.ToInt32(addProducts_stock.Text.Trim()));
                    updateD.Parameters.AddWithValue("@path", path);
                    updateD.Parameters.AddWithValue("@status", addProducts_status.SelectedItem);
                    updateD.Parameters.AddWithValue("@id", getID);

                    int rowsAffected = updateD.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        clearFIelds();
                        displayAllProducts();
                        MessageBox.Show("Updated Successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No record updated.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to update product: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connect.Close();
            }
        }

        private string HandleImageSave(string prodID)
        {
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string relativePath = Path.Combine("Product_Directory", prodID + ".jpg");
            string path = Path.Combine(baseDirectory, relativePath);

            if (!string.IsNullOrEmpty(addProducts_imageView.ImageLocation))
            {
                if (!Directory.Exists(Path.GetDirectoryName(path)))
                {
                    Directory.CreateDirectory(Path.GetDirectoryName(path));
                }
                File.Copy(addProducts_imageView.ImageLocation, path, true);
            }

            return path;
        }


        private void addProducts_removeBtn_Click_1(object sender, EventArgs e)
        {
            if (getID == 0)
            {
                MessageBox.Show("Please select a product to remove.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("Are you sure you want to delete Product ID: " + addProducts_prodID.Text.Trim() + "?",
                                "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (!checkConnection())
                {
                    MessageBox.Show("Database connection failed", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                try
                {
                    string deleteData = "DELETE FROM products WHERE id = @id";

                    using (SqlCommand deleteD = new SqlCommand(deleteData, connect))
                    {
                        deleteD.Parameters.AddWithValue("@id", getID);

                        int rowsAffected = deleteD.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            clearFIelds();
                            displayAllProducts();
                            MessageBox.Show("Deleted Successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No record found with the specified ID.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to delete product: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }
            }
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}



