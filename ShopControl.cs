using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using TitaniumControlsApp.Properties;

namespace TitaniumControlsApp
{
    public partial class ShopControl : UserControl
    {
        public ShopControl()
        {
            InitializeComponent();
        }

        private void ShopControl_Load(object sender, EventArgs e)
        {
            insertList();
        }

        private void insertList()
        {
            ProductCard[] productsList = new ProductCard[12];

            if (flowLayoutPanelProducts.Controls.Count > 0)
            {
                flowLayoutPanelProducts.Controls.Clear();
            }

            for (int i = 0; i < productsList.Length; i++)
            {
                var pc = new ProductCard();
                if (i%2 == 0)
                {
                    pc.ProductNameLbl = "Klawiatura mechaniczna YAMAHA s" + (i * 10);
                    pc.ProductPrize = "" + (i + 1) * (233+i);
                    pc.ProductImage = Resources.keyboard;
                }
                else
                {
                    pc.ProductNameLbl = "Myszka Razer Deathrazor X" + (i*10) + " Wireless";
                    pc.ProductPrize = "" + (i + 1) * (25+i);
                    pc.ProductImage = Resources.mouseRazer;
                }
                flowLayoutPanelProducts.Controls.Add(pc);
            }
        }
    }
}
