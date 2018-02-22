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

        public ProductDetailForm(string title) : this()
        {
            InitializeComponent();
            Text = title;
        }
        public ProductDetailForm(Product product) : this("Edit Product")
        {
            //InitializeComponent();
            Product = Product;
        }

        public Product Product { get; set; }

        //public virtual DialogResult ShowDialogEx()
        //{
        //    return ShowDialog();
        //}

        //public abstract DialogResult ShowDialogEx();

        protected override void OnLoad( EventArgs e )
        {
            base.OnLoad(e);

            if (Product != null)
            {
                _name.Text = Product.Name;
                _description.Text = Product.Description;
                _price.Text = Product.Price.ToString();
                BoxDiscont.Checked = Product.IsDiscontinued;
            }
            ValidateChildren();
        }

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
            //force validation of childs controls
            if (!ValidateChildren())
                return;

            //create product
            var product = new Product();
            product.Name = _name.Text;
            product.Description = _description.Text;
            product.Price = ConvertToPrice(_price);
            product.IsDiscontinued = BoxDiscont.Checked;

            var message = product.Validate();
            if (!String.IsNullOrEmpty(message))
            {
                DisplayError(message);
                return;
            }


            Product = product;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void DisplayError(string message)
        {
            MessageBox.Show(this, message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void ProductDetailForm_Load( object sender, EventArgs e )
        {

        }

        private void _name_Validating( object sender, CancelEventArgs e )
        {
            var textbox = sender as TextBox;

            if (String.IsNullOrEmpty(textbox.Text))
            {
                _errorProvider.SetError(textbox, "Nameis req");
                e.Cancel = true;
            } else
                _errorProvider.SetError(textbox, "");

            
        }

        private void _price_Validating( object sender, CancelEventArgs e )
        {
            var textbox = sender as TextBox;

            var price = ConvertToPrice(textbox);

            if (String.IsNullOrEmpty(textbox.Text))
            {
                _errorProvider.SetError(textbox, "Price must be >= 0");
                e.Cancel = true;
            } else
                _errorProvider.SetError(textbox, "");

            
        }
    }
}
