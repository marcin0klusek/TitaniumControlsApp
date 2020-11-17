namespace TitaniumControlsApp
{
    partial class NewsListItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewsListItem));
            this.avatarPictureBox = new System.Windows.Forms.PictureBox();
            this.nicknameLbl = new System.Windows.Forms.Label();
            this.dateLbl = new System.Windows.Forms.Label();
            this.postTextBox = new System.Windows.Forms.TextBox();
            this.ShareIcon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.avatarPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShareIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // avatarPictureBox
            // 
            this.avatarPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("avatarPictureBox.Image")));
            this.avatarPictureBox.Location = new System.Drawing.Point(10, 10);
            this.avatarPictureBox.Name = "avatarPictureBox";
            this.avatarPictureBox.Size = new System.Drawing.Size(40, 40);
            this.avatarPictureBox.TabIndex = 0;
            this.avatarPictureBox.TabStop = false;
            // 
            // nicknameLbl
            // 
            this.nicknameLbl.AutoSize = true;
            this.nicknameLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nicknameLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(242)))), ((int)(((byte)(238)))));
            this.nicknameLbl.Location = new System.Drawing.Point(56, 10);
            this.nicknameLbl.Margin = new System.Windows.Forms.Padding(0);
            this.nicknameLbl.Name = "nicknameLbl";
            this.nicknameLbl.Size = new System.Drawing.Size(146, 21);
            this.nicknameLbl.TabIndex = 1;
            this.nicknameLbl.Text = "Polish Pro League";
            // 
            // dateLbl
            // 
            this.dateLbl.AutoSize = true;
            this.dateLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(242)))), ((int)(((byte)(238)))));
            this.dateLbl.Location = new System.Drawing.Point(56, 31);
            this.dateLbl.Name = "dateLbl";
            this.dateLbl.Size = new System.Drawing.Size(95, 15);
            this.dateLbl.TabIndex = 2;
            this.dateLbl.Text = "02/04/2005 21:37";
            // 
            // postTextBox
            // 
            this.postTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(47)))), ((int)(((byte)(54)))));
            this.postTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.postTextBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.postTextBox.Enabled = false;
            this.postTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.postTextBox.Location = new System.Drawing.Point(10, 61);
            this.postTextBox.MaxLength = 336;
            this.postTextBox.Multiline = true;
            this.postTextBox.Name = "postTextBox";
            this.postTextBox.ReadOnly = true;
            this.postTextBox.Size = new System.Drawing.Size(469, 75);
            this.postTextBox.TabIndex = 3;
            this.postTextBox.Text = resources.GetString("postTextBox.Text");
            // 
            // ShareIcon
            // 
            this.ShareIcon.Image = ((System.Drawing.Image)(resources.GetObject("ShareIcon.Image")));
            this.ShareIcon.Location = new System.Drawing.Point(455, 10);
            this.ShareIcon.Name = "ShareIcon";
            this.ShareIcon.Size = new System.Drawing.Size(24, 24);
            this.ShareIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ShareIcon.TabIndex = 4;
            this.ShareIcon.TabStop = false;
            // 
            // NewsListItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.Controls.Add(this.ShareIcon);
            this.Controls.Add(this.postTextBox);
            this.Controls.Add(this.dateLbl);
            this.Controls.Add(this.nicknameLbl);
            this.Controls.Add(this.avatarPictureBox);
            this.Name = "NewsListItem";
            this.Size = new System.Drawing.Size(489, 150);
            ((System.ComponentModel.ISupportInitialize)(this.avatarPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShareIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox avatarPictureBox;
        private System.Windows.Forms.Label nicknameLbl;
        private System.Windows.Forms.Label dateLbl;
        private System.Windows.Forms.TextBox postTextBox;
        private System.Windows.Forms.PictureBox ShareIcon;
    }
}
