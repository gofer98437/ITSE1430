using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nile.Windows
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        protected override void OnLoad( EventArgs e )
        {
            base.OnLoad(e);

            //PlayingWithProductMembers();

        }
        private void PlayingWithProductMembers()
        {
            var product = new Product();

            Decimal.TryParse("123", out var price);
            product.Price = price;

            var name = product.Name;
            product.Name = "Product A";
            product.Price = 50;

            product.IsDiscontinued = true;


            //product.ActualPrice = 10;
            var price2 = product.ActualPrice;


            var error = product.Validate();
            var str = product.ToString();

            var productB = new Product();
            //productB.SetName("Product B");
            error = productB.Validate();


        }

        private void fileToolStripMenuItem_Click( object sender, EventArgs e )
        {

        }

        private void OnProductAdd( object sender, EventArgs e )
        {
            var form = new ProductDetailForm();
            form.Text = "Add Product";
            //Show the form modally
            var result = form.ShowDialog(this);
            if (result != DialogResult.OK)
                return;
            _product = form.Product;
        }
        private void OnProductEdit( object sender, EventArgs e )
        {
            MessageBox.Show(this, "Not Implemented", "ProductEdit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
        private void OnProductRemove( object sender, EventArgs e )
        {
            if(!ShowConfirmation("Are you sure you want to remove", "ProductRemove"))
                return;

            //Remove product
            MessageBox.Show("Not Implemented");

        }


        private void OnFileExit( object sender, EventArgs e )
        {
            MessageBox.Show(this, "Not Implemented", "FileExit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        private void OnHelpAbout( object sender, EventArgs e )
        {
            MessageBox.Show(this, "Not Implemented", "HelpAbout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
        //#endregion

        private bool ShowConfirmation(string message, string title)
        {
            return MessageBox.Show(this, message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
        }
        private Product _product;
    }
}
