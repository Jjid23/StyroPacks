using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.InteropServices;


namespace StyroPackPro
{
    public partial class SalesForm : UserControl
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Jobert\OneDrive - MSFT\Documents\StyroPACK.mdf"";Integrated Security=True;Connect Timeout=30");
        public SalesForm()
        {
            InitializeComponent();
        }

        private void fetchDataHistory()
        {
            Con.Open();
            string query = "select * from HistoryTable";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var data = new DataSet();
            sda.Fill(data);
            SPPtable.DataSource = data.Tables[0];
            Con.Close();
        }

        private void fetchDataAllSales()
        {
            Con.Open();
            string query = "select * from AllSalesTable";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var data = new DataSet();
            sda.Fill(data);
            AStable.DataSource = data.Tables[0];
            Con.Close();
        }

        private void fetchDataSpecificText()
        {
            Con.Open();
            string query = "select * from HistoryTable where AttName like '" + "%" + searchH.Text + "%" + "'" + "or" + " date like '" + "%" + searchH.Text + "%" + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var data = new DataSet();
            sda.Fill(data);
            SPPtable.DataSource = data.Tables[0];
            Con.Close();
        }

        private void fetchDataSpecificText2()
        {
            Con.Open();
            string query = "select * from AllSalesTable where Date like '" + "%" + searchA.Text + "%" + "'" + "or" + " Name like '" + "%" + searchA.Text + "%" + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var data = new DataSet();
            sda.Fill(data);
            AStable.DataSource = data.Tables[0];
            Con.Close();
        }

        private void searchH_TextChanged(object sender, EventArgs e)
        {

        }

        private void searchA_TextChanged(object sender, EventArgs e)
        {
            fetchDataSpecificText2();
        }

        private void refreshH_Click(object sender, EventArgs e)
        {
            fetchDataHistory();
            searchH.Text = "";
        }

        private void refreshA_Click(object sender, EventArgs e)
        {
            fetchDataAllSales();
            searchA.Text = "";
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;
        [DllImport("User32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private void History_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        private void AStable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
