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
    public partial class ProductDetailForm : Form
    {
        public ProductDetailForm()
        {
            InitializeComponent();
        }

        public Product Product { get; set; }

        private void label2_Click( object sender, EventArgs e )
        {

        }

        private void textBox1_TextChanged( object sender, EventArgs e )
        {

        }

        private void OnCancel( object sender, EventArgs e )
        {
        }

        private void OnSave( object sender, EventArgs e )
        {
            //create product
            var product = new Product();
            product.Name = ProductName.Text;
            product.Description = ProductDescription.Text;
            product.Price = ConvertToPrice(ProductPrice);
            product.IsDiscontinued = BoxDiscont.Checked;

            Product = product;
            DialogResult = DialogResult.OK;
            Close();
        }

        private decimal ConvertToPrice (TextBox control)
        {
            if (Decimal.TryParse(control.Text, out var price))
                return price;

            return -1;
        }

        private void ProductPrice_TextChanged( object sender, EventArgs e )
        {

        }
    }
}
