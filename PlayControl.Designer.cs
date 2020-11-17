namespace TitaniumControlsApp
{
    partial class PlayControl
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayControl));
            this.minsLbl = new System.Windows.Forms.Label();
            this.secsLbl = new System.Windows.Forms.Label();
            this.labelDots = new System.Windows.Forms.Label();
            this.acceptBtn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.PanelDashboard = new System.Windows.Forms.Panel();
            this.matchmakingBtn = new System.Windows.Forms.Button();
            this.PlayButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ReadyUp = new System.Windows.Forms.Timer(this.components);
            this.toolTip5v5 = new System.Windows.Forms.ToolTip(this.components);
            this.GameReadyLbl = new System.Windows.Forms.Label();
            this.readyTimer = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PanelDashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // minsLbl
            // 
            this.minsLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.minsLbl.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.minsLbl.Location = new System.Drawing.Point(214, 244);
            this.minsLbl.Name = "minsLbl";
            this.minsLbl.Size = new System.Drawing.Size(40, 36);
            this.minsLbl.TabIndex = 1;
            this.minsLbl.Text = "00";
            this.minsLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // secsLbl
            // 
            this.secsLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.secsLbl.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.secsLbl.Location = new System.Drawing.Point(260, 244);
            this.secsLbl.Name = "secsLbl";
            this.secsLbl.Size = new System.Drawing.Size(45, 36);
            this.secsLbl.TabIndex = 1;
            this.secsLbl.Text = "00";
            this.secsLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelDots
            // 
            this.labelDots.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelDots.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelDots.Location = new System.Drawing.Point(251, 244);
            this.labelDots.Name = "labelDots";
            this.labelDots.Size = new System.Drawing.Size(19, 36);
            this.labelDots.TabIndex = 1;
            this.labelDots.Text = ":";
            this.labelDots.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // acceptBtn
            // 
            this.acceptBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.acceptBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.acceptBtn.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.acceptBtn.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.acceptBtn.Location = new System.Drawing.Point(745, 645);
            this.acceptBtn.Name = "acceptBtn";
            this.acceptBtn.Size = new System.Drawing.Size(193, 48);
            this.acceptBtn.TabIndex = 3;
            this.acceptBtn.Text = "POTWIERDŹ";
            this.acceptBtn.UseVisualStyleBackColor = false;
            this.acceptBtn.Visible = false;
            this.acceptBtn.Click += new System.EventHandler(this.ReadyUpBtn_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // PanelDashboard
            // 
            this.PanelDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.PanelDashboard.Controls.Add(this.matchmakingBtn);
            this.PanelDashboard.Controls.Add(this.secsLbl);
            this.PanelDashboard.Controls.Add(this.labelDots);
            this.PanelDashboard.Controls.Add(this.minsLbl);
            this.PanelDashboard.Controls.Add(this.PlayButton);
            this.PanelDashboard.Controls.Add(this.label3);
            this.PanelDashboard.Controls.Add(this.label2);
            this.PanelDashboard.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelDashboard.Location = new System.Drawing.Point(0, 0);
            this.PanelDashboard.Name = "PanelDashboard";
            this.PanelDashboard.Size = new System.Drawing.Size(305, 791);
            this.PanelDashboard.TabIndex = 4;
            // 
            // matchmakingBtn
            // 
            this.matchmakingBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(9)))), ((int)(((byte)(8)))));
            this.matchmakingBtn.FlatAppearance.BorderSize = 0;
            this.matchmakingBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.matchmakingBtn.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.matchmakingBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.matchmakingBtn.Image = ((System.Drawing.Image)(resources.GetObject("matchmakingBtn.Image")));
            this.matchmakingBtn.Location = new System.Drawing.Point(0, 167);
            this.matchmakingBtn.Name = "matchmakingBtn";
            this.matchmakingBtn.Size = new System.Drawing.Size(305, 34);
            this.matchmakingBtn.TabIndex = 1;
            this.matchmakingBtn.Text = "CS:GO 5v5 PREMIUM";
            this.matchmakingBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.matchmakingBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.toolTip5v5.SetToolTip(this.matchmakingBtn, "Rozgrywka 5v5 dostępna wkrótce!");
            this.matchmakingBtn.UseVisualStyleBackColor = false;
            // 
            // PlayButton
            // 
            this.PlayButton.FlatAppearance.BorderSize = 0;
            this.PlayButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(204)))), ((int)(((byte)(194)))));
            this.PlayButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(204)))), ((int)(((byte)(194)))));
            this.PlayButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlayButton.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PlayButton.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.PlayButton.Image = ((System.Drawing.Image)(resources.GetObject("PlayButton.Image")));
            this.PlayButton.Location = new System.Drawing.Point(0, 207);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(305, 34);
            this.PlayButton.TabIndex = 1;
            this.PlayButton.Text = "ARENA WERYFIKACYJNA";
            this.PlayButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.PlayButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.PlayButton.UseVisualStyleBackColor = true;
            this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Corbel", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(0, 20);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.label3.Size = new System.Drawing.Size(305, 39);
            this.label3.TabIndex = 0;
            this.label3.Text = "DASHBOARD";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Corbel", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(0, 125);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.label2.Size = new System.Drawing.Size(305, 39);
            this.label2.TabIndex = 0;
            this.label2.Text = "MATCHMAKING";
            // 
            // ReadyUp
            // 
            this.ReadyUp.Enabled = true;
            this.ReadyUp.Interval = 1000;
            this.ReadyUp.Tick += new System.EventHandler(this.ReadyUp_Tick);
            // 
            // toolTip5v5
            // 
            this.toolTip5v5.AutomaticDelay = 100;
            this.toolTip5v5.AutoPopDelay = 5000;
            this.toolTip5v5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.toolTip5v5.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.toolTip5v5.InitialDelay = 100;
            this.toolTip5v5.OwnerDraw = true;
            this.toolTip5v5.ReshowDelay = 20;
            this.toolTip5v5.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip5v5.ToolTipTitle = "Rozgrywka 5v5";
            // 
            // GameReadyLbl
            // 
            this.GameReadyLbl.AutoSize = true;
            this.GameReadyLbl.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GameReadyLbl.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.GameReadyLbl.Location = new System.Drawing.Point(664, 562);
            this.GameReadyLbl.Name = "GameReadyLbl";
            this.GameReadyLbl.Size = new System.Drawing.Size(357, 40);
            this.GameReadyLbl.TabIndex = 5;
            this.GameReadyLbl.Text = "POTWIERDŹ GOTOWOŚĆ";
            this.GameReadyLbl.Visible = false;
            // 
            // readyTimer
            // 
            this.readyTimer.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.readyTimer.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.readyTimer.Location = new System.Drawing.Point(721, 602);
            this.readyTimer.Name = "readyTimer";
            this.readyTimer.Size = new System.Drawing.Size(235, 40);
            this.readyTimer.TabIndex = 5;
            this.readyTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.readyTimer.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(304, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1120, 508);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // PlayControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.readyTimer);
            this.Controls.Add(this.GameReadyLbl);
            this.Controls.Add(this.PanelDashboard);
            this.Controls.Add(this.acceptBtn);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Name = "PlayControl";
            this.Size = new System.Drawing.Size(1424, 791);
            this.Load += new System.EventHandler(this.PlayControl_Load);
            this.Leave += new System.EventHandler(this.PlayControl_Leave);
            this.PanelDashboard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label minsLbl;
        private System.Windows.Forms.Label secsLbl;
        private System.Windows.Forms.Label labelDots;
        private System.Windows.Forms.Button acceptBtn;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel PanelDashboard;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button PlayButton;
        private System.Windows.Forms.Timer ReadyUp;
        private System.Windows.Forms.Button matchmakingBtn;
        private System.Windows.Forms.ToolTip toolTip5v5;
        private System.Windows.Forms.Label GameReadyLbl;
        private System.Windows.Forms.Label readyTimer;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
