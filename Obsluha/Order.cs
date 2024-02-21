using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderManager
{
    public partial class Order : Form
    {
        private int tableNumber;
        private Main mainForm;
        private BindingList<Item> OrderList { get; set; }

        public Order(Main mainForm, int tableNumber)
        {
            InitializeComponent();
            this.tableNumber = tableNumber;
            this.mainForm = mainForm;

            OrderList = new BindingList<Item>();

            dgvItems.DataSource = Databaze.Items;
            dgvOrder.DataSource = OrderList;
        }

        private void aBt_Click(object sender, EventArgs e)
        {
            int indZ = dgvItems.CurrentCell.RowIndex;
            OrderList.Add(Databaze.Items[indZ]);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainForm.Show();
        }

        private void Rbt_Click(object sender, EventArgs e)
        {
            if (dgvOrder.RowCount != 0)
            {
                int indX = dgvOrder.CurrentCell.RowIndex;
                OrderList.Remove(OrderList[indX]);
            }
        }

    }
}
