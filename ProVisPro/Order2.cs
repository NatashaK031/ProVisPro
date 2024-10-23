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
    public partial class Order2 : Form
    {
        public Order2()
        {
            InitializeComponent();
        }

        private void Order2_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (var order in Order1.confirmedOrders)
            {
                listBox1.Items.Add(order);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Order1 order1 = new Order1();
            order1.Show();
        }
    }
}
