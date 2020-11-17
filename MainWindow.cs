using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TitaniumControlsApp
{
    public partial class MainWindow : Form
    {

        public MainWindow()
        {
            InitializeComponent();
        }


        private void HomeBtn_Click(object sender, EventArgs e)
        {
            panelControls.Controls.Clear();
            HomeControl home = new HomeControl();
            panelControls.Controls.Add(home);
            home.Show();
            ActivePanel.Location = new Point(HomeBtn.Location.X, ActivePanel.Location.Y);
        }

        private void PlayBtn_Click(object sender, EventArgs e)
        {
            panelControls.Controls.Clear();
            PlayControl play = new PlayControl();
            panelControls.Controls.Add(play);
            play.Show();
            ActivePanel.Location = new Point(PlayBtn.Location.X, ActivePanel.Location.Y);
        }

        private void ShopBtn_Click(object sender, EventArgs e)
        {
            panelControls.Controls.Clear();
            ShopControl shop = new ShopControl();
            panelControls.Controls.Add(shop);
            shop.Show();
            ActivePanel.Location = new Point(ShopBtn.Location.X, ActivePanel.Location.Y);
        }
        private void RoundPlayerAvatar()
        {
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(0, 0, AvatarPlayer.Width - 3, AvatarPlayer.Height - 3);
            Region rg = new Region(gp);
            AvatarPlayer.Region = rg;
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            RoundPlayerAvatar();
            panelControls.BringToFront();
            HomeBtn_Click(null, null);
        }
    }
}
