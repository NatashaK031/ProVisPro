using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProVisPro
{
    public partial class Order1 : Form
    {
        public static List<string> confirmedOrders = new List<string>();

        private MySqlConnection koneksi;
        private MySqlDataAdapter adapter;
        private MySqlCommand perintah;
        private DataSet ds = new DataSet();
        private string alamat, query;

        public Order1()
        {
            alamat = "server=localhost; database=projectvp; username=root; password=;";
            koneksi = new MySqlConnection(alamat);
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5) // Confirm button is in column index 5
            {
                string nama = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                string tanggalMasuk = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                string kg = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                string alamat = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                string estimasiTersedia = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();

                // Format the data into a string and add to the list
                string orderData = $"{nama}, {tanggalMasuk}, {kg} kg, {alamat}, Estimasi: {estimasiTersedia}";
                confirmedOrders.Add(orderData);

                MessageBox.Show("Order confirmed!");

                // Optionally clear the row for new input
                dataGridView1.Rows[e.RowIndex].Cells[0].Value = "";
                dataGridView1.Rows[e.RowIndex].Cells[1].Value = "";
                dataGridView1.Rows[e.RowIndex].Cells[2].Value = "";
                dataGridView1.Rows[e.RowIndex].Cells[3].Value = "";
                dataGridView1.Rows[e.RowIndex].Cells[4].Value = "";
            }
        }

        private void btnShowOrder_Click(object sender, EventArgs e)
        {
            Order2 orderDisplayForm = new Order2();
            orderDisplayForm.Show();
        }
    }
}
