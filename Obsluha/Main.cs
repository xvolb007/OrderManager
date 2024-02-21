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
    public partial class Main : Form
    {
        //just dictionary to save new order forms
        private Dictionary<int, Order> orderForms = new Dictionary<int, Order>();

        //function to open order form if its exist or create new and add the order to the orderForms dictionary if doesnt
        private void OpenOrderForm(int tableNumber)
        {
            if (orderForms.ContainsKey(tableNumber) && orderForms[tableNumber] != null)
            {
                this.Hide();
                orderForms[tableNumber].Show();
            }
            else
            {
                this.Hide();
                Order order = new Order(this, tableNumber);
                orderForms[tableNumber] = order;
                order.Show();
            }
        }
        public Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //5 different tables
        private void Table1_Click(object sender, EventArgs e)
        {
            int tableNumber = int.Parse(((Button)sender).Name.Substring(5));
            OpenOrderForm(tableNumber);
        }

        private void Table2_Click(object sender, EventArgs e)
        {
            int tableNumber = int.Parse(((Button)sender).Name.Substring(5));
            OpenOrderForm(tableNumber);
        }

        private void Table3_Click(object sender, EventArgs e)
        {
            int tableNumber = int.Parse(((Button)sender).Name.Substring(5));
            OpenOrderForm(tableNumber);
        }

        private void Table4_Click(object sender, EventArgs e)
        {
            int tableNumber = int.Parse(((Button)sender).Name.Substring(5));
            OpenOrderForm(tableNumber);
        }

        private void Table5_Click(object sender, EventArgs e)
        {
            int tableNumber = int.Parse(((Button)sender).Name.Substring(5));
            OpenOrderForm(tableNumber);
        }
        
        
    }
}
