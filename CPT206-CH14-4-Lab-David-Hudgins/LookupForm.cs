using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
            productNumberTextBox.Clear();
            descriptionTextBox.Clear();
            productDataGridView.DataSource = "";
        }

        private void showAllButton_Click(object sender, EventArgs e)
        {
            ProductDBDataContext db = new ProductDBDataContext();       //Takes LINQ to SQL Class and creates object

            var results = from product in db.Products           //Selects all rows
                          select product;

            productDataGridView.DataSource = results;       //Fills Gridview table
        }

        private void productNumberSearchButton_Click(object sender, EventArgs e)
        {
            if(productNumberTextBox.Text != "")
            {
                productDataGridView.DataSource = "";

                ProductDBDataContext db = new ProductDBDataContext();

                var results = from product in db.Products
                              where product.Product_Number.Equals(productNumberTextBox.Text)        //Looks for matching product number with textbox entry
                              select product;

                productDataGridView.DataSource = results;
            }
            else
            {
                MessageBox.Show("Please Enter A Product Number");
            }

        }

        private void descriptionSearchButton_Click(object sender, EventArgs e)
        {
            if(descriptionTextBox.Text != "")
            {
                productDataGridView.DataSource = "";

                ProductDBDataContext db = new ProductDBDataContext();

                var results = from product in db.Products
                              where product.Description.Contains(descriptionTextBox.Text)       //Finds all rows with descriptions containing textbox entry
                              select product;

                productDataGridView.DataSource = results;
            }
            else
            {
                MessageBox.Show("Please Enter A Description");
            }
        }
    }
}
