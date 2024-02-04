using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPT206_CH14_4_Lab_David_Hudgins
{
    public partial class LookupForm : Form
    {
        public LookupForm()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            greaterTextBox.Clear();
            lessTextBox.Clear();

            ProductDBDataContext db = new ProductDBDataContext();   //Uses LINQ to SQL Class to create new object

            var results = from product in db.Products               //Gets all items in product table and sorts by Units on Hand, Ascending 
                          orderby product.Units_On_Hand ascending
                          select product;

            productDataGridView.DataSource = results;               //Fills datagrid with results var
        }

        private void LookupForm_Load(object sender, EventArgs e)
        {
            ProductDBDataContext db = new ProductDBDataContext();

            var results = from product in db.Products
                          orderby product.Units_On_Hand ascending       //Same as reset
                          select product;

            productDataGridView.DataSource = results;
        }

        private void greaterSearchButton_Click(object sender, EventArgs e)
        {
            int greaterAmt;

            if(int.TryParse(greaterTextBox.Text, out greaterAmt))
            {
                productDataGridView.DataSource = null;

                ProductDBDataContext db = new ProductDBDataContext();

                var results = from product in db.Products
                              where product.Units_On_Hand > greaterAmt      //finds all rows with units on hand > the amount in greater textbox
                              orderby product.Units_On_Hand ascending
                              select product;

                productDataGridView.DataSource = results;
            }
            else
            {
                MessageBox.Show("Please Enter A Valid Number");
            }
        }

        private void lessSearchButton_Click(object sender, EventArgs e)
        {
            int lessAmt;

            if (int.TryParse(lessTextBox.Text, out lessAmt))
            {
                productDataGridView.DataSource = null;

                ProductDBDataContext db = new ProductDBDataContext();

                var results = from product in db.Products
                              where product.Units_On_Hand < lessAmt     //finds all rows with units on hand < the amount in less textbox
                              orderby product.Units_On_Hand ascending
                              select product;

                productDataGridView.DataSource = results;
            }
            else
            {
                MessageBox.Show("Please Enter A Valid Number");
            }
        }
    }
}
