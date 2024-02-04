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
            lowTextBox.Clear();
            highTextBox.Clear();

            ProductDBDataContext db = new ProductDBDataContext();

            var results = from product in db.Products
                          orderby product.Price ascending
                          select product;

            productDataGridView.DataSource = results;
        }

        private void LookupForm_Load(object sender, EventArgs e)
        {
            ProductDBDataContext db = new ProductDBDataContext();

            var results = from product in db.Products
                          orderby product.Price ascending   //loads all rows sorted by price, ascending
                          select product;

            productDataGridView.DataSource = results;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            int lowAmt;
            int highAmt;

            if (int.TryParse(lowTextBox.Text, out lowAmt)) { } else { MessageBox.Show("Please Enter A Valid Low Number"); return; }     //Tryparse
            if (int.TryParse(highTextBox.Text, out highAmt)) { } else { MessageBox.Show("Please Enter A Valid High Number"); return; }  //Tryparse

            productDataGridView.DataSource = null;

            ProductDBDataContext db = new ProductDBDataContext();

            var results = from product in db.Products
                          where product.Price >= lowAmt             //Two where clauses, one for low amount and one for high
                          where product.Price <= highAmt
                          orderby product.Price ascending
                          select product;

            productDataGridView.DataSource = results;
        }
    }
}
