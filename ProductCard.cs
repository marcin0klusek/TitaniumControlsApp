using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace TitaniumControlsApp
{
    public partial class ProductCard : UserControl
    {
        public ProductCard()
        {
            InitializeComponent();
        }

        private string _productName;
        private string _productPrize;
        private Image _productImage;

        [Category("Custom Props")]
        public string ProductNameLbl
        {
            get { return _productName; }
            set { _productName = value; ProductNameTxt.Text = value; }
        }


        [Category("Custom Props")]
        public string ProductPrize
        {
            get { return _productPrize; }
            set { _productPrize = value; ProductPrizeTxt.Text = value + " PLN";  }
        }

        [Category("Custom Props")]
        public Image ProductImage
        {
            get { return _productImage; }
            set { _productImage = value; ProductImageBox.Image = value; }
        }

    }
}
