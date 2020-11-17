namespace TitaniumControlsApp
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.HomeBtn = new System.Windows.Forms.Button();
            this.AkcjaTxt = new System.Windows.Forms.Label();
            this.PlayBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.NicknamePlayer = new System.Windows.Forms.Label();
            this.ActivePanel = new System.Windows.Forms.Panel();
            this.ShopBtn = new System.Windows.Forms.Button();
            this.AvatarPlayer = new System.Windows.Forms.PictureBox();
            this.panelControls = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AvatarPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // HomeBtn
            // 
            this.HomeBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(16)))), ((int)(((byte)(23)))));
            this.HomeBtn.FlatAppearance.BorderSize = 0;
            this.HomeBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(204)))), ((int)(((byte)(194)))));
            this.HomeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(163)))), ((int)(((byte)(156)))));
            this.HomeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeBtn.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HomeBtn.ForeColor = System.Drawing.Color.White;
            this.HomeBtn.Image = ((System.Drawing.Image)(resources.GetObject("HomeBtn.Image")));
            this.HomeBtn.Location = new System.Drawing.Point(36, 12);
            this.HomeBtn.Name = "HomeBtn";
            this.HomeBtn.Size = new System.Drawing.Size(105, 50);
            this.HomeBtn.TabIndex = 0;
            this.HomeBtn.Text = "Home";
            this.HomeBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.HomeBtn.UseVisualStyleBackColor = true;
            this.HomeBtn.Click += new System.EventHandler(this.HomeBtn_Click);
            // 
            // AkcjaTxt
            // 
            this.AkcjaTxt.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AkcjaTxt.ForeColor = System.Drawing.Color.White;
            this.AkcjaTxt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AkcjaTxt.Location = new System.Drawing.Point(1243, 9);
            this.AkcjaTxt.Name = "AkcjaTxt";
            this.AkcjaTxt.Size = new System.Drawing.Size(62, 42);
            this.AkcjaTxt.TabIndex = 1;
            this.AkcjaTxt.Text = "Witaj,";
            this.AkcjaTxt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PlayBtn
            // 
            this.PlayBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(16)))), ((int)(((byte)(23)))));
            this.PlayBtn.FlatAppearance.BorderSize = 0;
            this.PlayBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(204)))), ((int)(((byte)(194)))));
            this.PlayBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(163)))), ((int)(((byte)(156)))));
            this.PlayBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlayBtn.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PlayBtn.ForeColor = System.Drawing.Color.White;
            this.PlayBtn.Image = ((System.Drawing.Image)(resources.GetObject("PlayBtn.Image")));
            this.PlayBtn.Location = new System.Drawing.Point(161, 12);
            this.PlayBtn.Name = "PlayBtn";
            this.PlayBtn.Size = new System.Drawing.Size(105, 50);
            this.PlayBtn.TabIndex = 0;
            this.PlayBtn.Text = "Play";
            this.PlayBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.PlayBtn.UseVisualStyleBackColor = true;
            this.PlayBtn.Click += new System.EventHandler(this.PlayBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.panel1.Controls.Add(this.NicknamePlayer);
            this.panel1.Controls.Add(this.ActivePanel);
            this.panel1.Controls.Add(this.ShopBtn);
            this.panel1.Controls.Add(this.AvatarPlayer);
            this.panel1.Controls.Add(this.HomeBtn);
            this.panel1.Controls.Add(this.AkcjaTxt);
            this.panel1.Controls.Add(this.PlayBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1424, 65);
            this.panel1.TabIndex = 2;
            // 
            // NicknamePlayer
            // 
            this.NicknamePlayer.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NicknamePlayer.ForeColor = System.Drawing.Color.White;
            this.NicknamePlayer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NicknamePlayer.Location = new System.Drawing.Point(1295, 9);
            this.NicknamePlayer.Name = "NicknamePlayer";
            this.NicknamePlayer.Size = new System.Drawing.Size(117, 42);
            this.NicknamePlayer.TabIndex = 1;
            this.NicknamePlayer.Text = "Klusek!";
            this.NicknamePlayer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ActivePanel
            // 
            this.ActivePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(204)))), ((int)(((byte)(194)))));
            this.ActivePanel.Location = new System.Drawing.Point(36, 60);
            this.ActivePanel.Name = "ActivePanel";
            this.ActivePanel.Size = new System.Drawing.Size(105, 5);
            this.ActivePanel.TabIndex = 3;
            // 
            // ShopBtn
            // 
            this.ShopBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(16)))), ((int)(((byte)(23)))));
            this.ShopBtn.FlatAppearance.BorderSize = 0;
            this.ShopBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(204)))), ((int)(((byte)(194)))));
            this.ShopBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(163)))), ((int)(((byte)(156)))));
            this.ShopBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShopBtn.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ShopBtn.ForeColor = System.Drawing.Color.White;
            this.ShopBtn.Image = ((System.Drawing.Image)(resources.GetObject("ShopBtn.Image")));
            this.ShopBtn.Location = new System.Drawing.Point(272, 12);
            this.ShopBtn.Name = "ShopBtn";
            this.ShopBtn.Size = new System.Drawing.Size(105, 50);
            this.ShopBtn.TabIndex = 0;
            this.ShopBtn.Text = "Shop";
            this.ShopBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ShopBtn.UseVisualStyleBackColor = true;
            this.ShopBtn.Click += new System.EventHandler(this.ShopBtn_Click);
            // 
            // AvatarPlayer
            // 
            this.AvatarPlayer.Image = ((System.Drawing.Image)(resources.GetObject("AvatarPlayer.Image")));
            this.AvatarPlayer.Location = new System.Drawing.Point(1196, 12);
            this.AvatarPlayer.MaximumSize = new System.Drawing.Size(40, 40);
            this.AvatarPlayer.MinimumSize = new System.Drawing.Size(40, 40);
            this.AvatarPlayer.Name = "AvatarPlayer";
            this.AvatarPlayer.Size = new System.Drawing.Size(40, 40);
            this.AvatarPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AvatarPlayer.TabIndex = 2;
            this.AvatarPlayer.TabStop = false;
            // 
            // panelControls
            // 
            this.panelControls.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControls.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(64)))));
            this.panelControls.Location = new System.Drawing.Point(0, 64);
            this.panelControls.Name = "panelControls";
            this.panelControls.Size = new System.Drawing.Size(1424, 802);
            this.panelControls.TabIndex = 3;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1424, 861);
            this.Controls.Add(this.panelControls);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1440, 900);
            this.MinimumSize = new System.Drawing.Size(1440, 900);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Titanium";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AvatarPlayer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button HomeBtn;
        private System.Windows.Forms.Label AkcjaTxt;
        private System.Windows.Forms.Button PlayBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox AvatarPlayer;
        private System.Windows.Forms.Button ShopBtn;
        private System.Windows.Forms.Panel ActivePanel;
        private System.Windows.Forms.Label NicknamePlayer;
        private System.Windows.Forms.Panel panelControls;
    }
}

