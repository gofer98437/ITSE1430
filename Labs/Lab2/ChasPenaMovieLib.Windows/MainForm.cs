using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChasPena.MovieLib;

namespace ChasPenaMovieLib.Windows
{
    public partial class MainForm : Form
    {
        private Film movie;

        public MainForm()
        {
            InitializeComponent();

        }

        private void OnLoad( object sender, EventArgs e )
        {
            base.OnLoad(e);
        }

        /// <summary>
        /// To use the method in the class, the class must be initialized first.
        ///MyCar NewCar = new MyCar();
        ///NewCar.Manufacturer("Audi");
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 

        private void FilmDetails_Load( object sender, EventArgs e )
        {
            base.OnLoad(e);

        }

        private void OnAdd( object sender, EventArgs e )
        {
            var button = sender as ToolStripMenuItem;

            var form = new FilmDetails("Add Product");
            //form.Text = "Add Product";
            //Show the form modally
            var result = form.ShowDialog(this);
            if (result != DialogResult.OK)
                return;        

        }
        private void OnEdit( object sender, EventArgs e )
        {
            if (movie == null)
                return;
            var form = new FilmDetails(movie);
            //form.Text = "Edit Product";
            //form.Product = _product;

            //Show the form modally
            var result = form.ShowDialog(this);
            if (result != DialogResult.OK)
                return;
        }
        private void OnRemove( object sender, EventArgs e )
        {
            movie = null;
            return;
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

        private void FileExit( object sender, ToolStripItemClickedEventArgs e )
        {

        }

        private void textBox1_TextChanged( object sender, EventArgs e )
        {

        }

        private void textBox4_TextChanged( object sender, EventArgs e )
        {

        }

        private void textBox3_TextChanged( object sender, EventArgs e )
        {

        }

        private void textBox2_TextChanged( object sender, EventArgs e )
        {

        }

        private void checkBox1_CheckedChanged( object sender, EventArgs e )
        {

        }

        private void button2_Click( object sender, EventArgs e )
        {

        }

        private void button1_Click( object sender, EventArgs e )
        {

        }
    }
}
