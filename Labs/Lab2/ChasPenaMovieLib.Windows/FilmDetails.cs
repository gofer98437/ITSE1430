using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChasPenaMovieLib.Windows
{
    public partial class FilmDetails : Form
    {
        public FilmDetails()
        {
            InitializeComponent();
        }

        private void FilmDetails_Load( object sender, EventArgs e )
        {
            base.OnLoad(e);

        }

        private void OnAdd( object sender, EventArgs e )
        {
            //var button = sender as ToolStripMenuItem;

            //var form = new ProductDetailForm("Add Product");
            ////form.Text = "Add Product";
            ////Show the form modally
            //var result = form.ShowDialog(this);
            //if (result != DialogResult.OK)
            //    return;
            //_product = form.Product;


        }
        private void OnEdit( object sender, EventArgs e )
        {
            //if (_product == null)
            //    return;
            //var form = new ProductDetailForm(_product);
            ////form.Text = "Edit Product";
            ////form.Product = _product;

            ////Show the form modally
            //var result = form.ShowDialog(this);
            //if (result != DialogResult.OK)
            //    return;

            //_product = form.Product;
        }
        private void OnRemove( object sender, EventArgs e )
        {
            //if (!ShowConfirmation("Are you sure you want to remove", "ProductRemove"))
            //    return;


            ////Remove product
            //MessageBox.Show("Not Implemented");

            //_product = null;

        }
        private void OnFileExit( object sender, EventArgs e )
        {
            Close();
        }
        private void OnHelpAbout( object sender, EventArgs e )
        {
            //MessageBox.Show(this, "Not Implemented", "HelpAbout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
        //private bool ShowConfirmation( string message, string title )
        //{
        //    //return MessageBox.Show(this, message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
        //}

        private void MainForm_Load( object sender, EventArgs e )
        {

        }

        private void textBox6_TextChanged( object sender, EventArgs e )
        {

        }

        private void textBox1_TextChanged( object sender, EventArgs e )
        {

        }

        private void textBox2_TextChanged( object sender, EventArgs e )
        {

        }

        private void textBox3_TextChanged( object sender, EventArgs e )
        {

        }

        private void textBox4_TextChanged( object sender, EventArgs e )
        {

        }

        private void textBox5_TextChanged( object sender, EventArgs e )
        {

        }

        private void label1_Click( object sender, EventArgs e )
        {

        }

        private void label2_Click( object sender, EventArgs e )
        {

        }

        private void label3_Click( object sender, EventArgs e )
        {

        }

        private void label4_Click( object sender, EventArgs e )
        {

        }

        private void label5_Click( object sender, EventArgs e )
        {

        }

        private void label6_Click( object sender, EventArgs e )
        {

        }

        private void button1_Click( object sender, EventArgs e )
        {

        }

        private void button2_Click( object sender, EventArgs e )
        {

        }

        private void checkBox1_CheckedChanged( object sender, EventArgs e )
        {

        }
    }
}
