namespace TitaniumControlsApp
{
    partial class ProductCard
    {
        /// <summary> 
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductCard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.BuyBtn = new System.Windows.Forms.Button();
            this.ProductPrizeTxt = new System.Windows.Forms.Label();
            this.ProductNameTxt = new System.Windows.Forms.Label();
            this.ProductImageBox = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductImageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.panel1.Controls.Add(this.BuyBtn);
            this.panel1.Controls.Add(this.ProductPrizeTxt);
            this.panel1.Controls.Add(this.ProductNameTxt);
            this.panel1.Controls.Add(this.ProductImageBox);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(164, 260);
            this.panel1.TabIndex = 0;
            // 
            // BuyBtn
            // 
            this.BuyBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(47)))), ((int)(((byte)(54)))));
            this.BuyBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BuyBtn.FlatAppearance.BorderSize = 0;
            this.BuyBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(189)))), ((int)(((byte)(222)))));
            this.BuyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BuyBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BuyBtn.ForeColor = System.Drawing.Color.White;
            this.BuyBtn.Image = ((System.Drawing.Image)(resources.GetObject("BuyBtn.Image")));
            this.BuyBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BuyBtn.Location = new System.Drawing.Point(10, 216);
            this.BuyBtn.Name = "BuyBtn";
            this.BuyBtn.Size = new System.Drawing.Size(140, 24);
            this.BuyBtn.TabIndex = 3;
            this.BuyBtn.Text = "KUP TERAZ";
            this.BuyBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BuyBtn.UseVisualStyleBackColor = false;
            // 
            // ProductPrizeTxt
            // 
            this.ProductPrizeTxt.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ProductPrizeTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(47)))), ((int)(((byte)(54)))));
            this.ProductPrizeTxt.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ProductPrizeTxt.ForeColor = System.Drawing.Color.White;
            this.ProductPrizeTxt.Location = new System.Drawing.Point(1, 182);
            this.ProductPrizeTxt.Name = "ProductPrizeTxt";
            this.ProductPrizeTxt.Size = new System.Drawing.Size(165, 22);
            this.ProductPrizeTxt.TabIndex = 2;
            this.ProductPrizeTxt.Text = "999.20 PLN";
            this.ProductPrizeTxt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ProductNameTxt
            // 
            this.ProductNameTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.ProductNameTxt.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ProductNameTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(242)))), ((int)(((byte)(238)))));
            this.ProductNameTxt.Location = new System.Drawing.Point(-1, 133);
            this.ProductNameTxt.Name = "ProductNameTxt";
            this.ProductNameTxt.Size = new System.Drawing.Size(164, 42);
            this.ProductNameTxt.TabIndex = 1;
            this.ProductNameTxt.Text = "Bardzo długa nazwa tego produktu";
            this.ProductNameTxt.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ProductImageBox
            // 
            this.ProductImageBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProductImageBox.Image = ((System.Drawing.Image)(resources.GetObject("ProductImageBox.Image")));
            this.ProductImageBox.Location = new System.Drawing.Point(-1, -1);
            this.ProductImageBox.Name = "ProductImageBox";
            this.ProductImageBox.Size = new System.Drawing.Size(167, 131);
            this.ProductImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ProductImageBox.TabIndex = 0;
            this.ProductImageBox.TabStop = false;
            // 
            // ProductCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(11);
            this.Name = "ProductCard";
            this.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Size = new System.Drawing.Size(163, 256);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ProductImageBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label ProductNameTxt;
        private System.Windows.Forms.PictureBox ProductImageBox;
        private System.Windows.Forms.Label ProductPrizeTxt;
        private System.Windows.Forms.Button BuyBtn;
    }
}
