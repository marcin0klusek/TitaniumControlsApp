using TitaniumControlsApp.Properties;

namespace TitaniumControlsApp
{
    partial class HomeControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeControl));
            this.PlayerAvatar = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.postBtn = new System.Windows.Forms.Button();
            this.postTextBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.insta = new System.Windows.Forms.PictureBox();
            this.facebook = new System.Windows.Forms.PictureBox();
            this.twitter = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanelNews = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerAvatar)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.insta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facebook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.twitter)).BeginInit();
            this.SuspendLayout();
            // 
            // PlayerAvatar
            // 
            this.PlayerAvatar.Image = ((System.Drawing.Image)(resources.GetObject("PlayerAvatar.Image")));
            this.PlayerAvatar.Location = new System.Drawing.Point(11, 9);
            this.PlayerAvatar.Name = "PlayerAvatar";
            this.PlayerAvatar.Size = new System.Drawing.Size(40, 40);
            this.PlayerAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PlayerAvatar.TabIndex = 0;
            this.PlayerAvatar.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.panel1.Controls.Add(this.postBtn);
            this.panel1.Controls.Add(this.postTextBox);
            this.panel1.Controls.Add(this.PlayerAvatar);
            this.panel1.Location = new System.Drawing.Point(475, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(521, 90);
            this.panel1.TabIndex = 1;
            // 
            // postBtn
            // 
            this.postBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(112)))), ((int)(((byte)(110)))));
            this.postBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.postBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(16)))), ((int)(((byte)(23)))));
            this.postBtn.FlatAppearance.BorderSize = 0;
            this.postBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(46)))), ((int)(((byte)(63)))));
            this.postBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.postBtn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.postBtn.ForeColor = System.Drawing.Color.White;
            this.postBtn.Location = new System.Drawing.Point(453, 55);
            this.postBtn.Name = "postBtn";
            this.postBtn.Size = new System.Drawing.Size(57, 27);
            this.postBtn.TabIndex = 0;
            this.postBtn.Text = "POST";
            this.postBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.postBtn.UseVisualStyleBackColor = false;
            this.postBtn.Click += new System.EventHandler(this.postBtn_Click);
            // 
            // postTextBox
            // 
            this.postTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(47)))), ((int)(((byte)(54)))));
            this.postTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.postTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.postTextBox.Location = new System.Drawing.Point(57, 9);
            this.postTextBox.MaxLength = 336;
            this.postTextBox.Multiline = true;
            this.postTextBox.Name = "postTextBox";
            this.postTextBox.PlaceholderText = "Post to your friends & followers...";
            this.postTextBox.Size = new System.Drawing.Size(453, 40);
            this.postTextBox.TabIndex = 1;
            this.postTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.postTextBox_KeyDown);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.panel2.Controls.Add(this.pictureBox4);
            this.panel2.Controls.Add(this.insta);
            this.panel2.Controls.Add(this.facebook);
            this.panel2.Controls.Add(this.twitter);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(475, 144);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(521, 45);
            this.panel2.TabIndex = 3;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(476, 11);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(24, 24);
            this.pictureBox4.TabIndex = 1;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // insta
            // 
            this.insta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.insta.Image = ((System.Drawing.Image)(resources.GetObject("insta.Image")));
            this.insta.Location = new System.Drawing.Point(446, 11);
            this.insta.Name = "insta";
            this.insta.Size = new System.Drawing.Size(24, 24);
            this.insta.TabIndex = 1;
            this.insta.TabStop = false;
            this.insta.Click += new System.EventHandler(this.insta_Click);
            // 
            // facebook
            // 
            this.facebook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.facebook.Image = ((System.Drawing.Image)(resources.GetObject("facebook.Image")));
            this.facebook.Location = new System.Drawing.Point(416, 11);
            this.facebook.Name = "facebook";
            this.facebook.Size = new System.Drawing.Size(24, 24);
            this.facebook.TabIndex = 1;
            this.facebook.TabStop = false;
            this.facebook.Click += new System.EventHandler(this.facebook_Click);
            // 
            // twitter
            // 
            this.twitter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.twitter.Image = ((System.Drawing.Image)(resources.GetObject("twitter.Image")));
            this.twitter.Location = new System.Drawing.Point(386, 11);
            this.twitter.Name = "twitter";
            this.twitter.Size = new System.Drawing.Size(24, 24);
            this.twitter.TabIndex = 1;
            this.twitter.TabStop = false;
            this.twitter.Click += new System.EventHandler(this.twitter_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(386, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Śledź nas na mediach społecznościowych -- ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanelNews
            // 
            this.flowLayoutPanelNews.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanelNews.Location = new System.Drawing.Point(475, 206);
            this.flowLayoutPanelNews.Name = "flowLayoutPanelNews";
            this.flowLayoutPanelNews.Size = new System.Drawing.Size(521, 585);
            this.flowLayoutPanelNews.TabIndex = 4;
            // 
            // HomeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanelNews);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "HomeControl";
            this.Size = new System.Drawing.Size(1424, 791);
            this.Load += new System.EventHandler(this.HomeControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PlayerAvatar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.insta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facebook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.twitter)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PlayerAvatar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox postTextBox;
        private System.Windows.Forms.Button postBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox insta;
        private System.Windows.Forms.PictureBox facebook;
        private System.Windows.Forms.PictureBox twitter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelNews;
    }
}
