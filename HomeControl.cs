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
    public partial class HomeControl : UserControl
    {
        public HomeControl()
        {
            InitializeComponent();
            flowlayoutpanelScrolls();
        }

        private void PublicNewPost()
        {
            if (postTextBox.Text == "")
                return;

            if ( postTextBox.Text.Length <= 336)
            {
                NewsListItem nli = CreateNewPost();
                ClearPostTextBox();
                flowLayoutPanelNews.Controls.Add(nli);
                flowLayoutPanelNews.Controls.SetChildIndex(nli, 0);
            }
        }

        private NewsListItem CreateNewPost()
        {
            NewsListItem tmp = new NewsListItem();
            tmp.AvatarPost = PlayerAvatar.Image;
            tmp.Nickname = "Marcin Klusek";
            tmp.DatePost = DateTime.Now.ToString();
            tmp.TextPost = postTextBox.Text;

            return tmp;
        }

        private void ClearPostTextBox()
        {
            postTextBox.Text = "";
            label1.Focus();
        }


        private void flowlayoutpanelScrolls()
        {
            flowLayoutPanelNews.AutoScroll = true;
            flowLayoutPanelNews.HorizontalScroll.Visible = false;
            flowLayoutPanelNews.VerticalScroll.Visible = false;
        }

        private void populateItemsFlowLayoutPanel()
        {
            NewsListItem[] newsList = new NewsListItem[3];
            if (flowLayoutPanelNews.Controls.Count > 0)
                flowLayoutPanelNews.Controls.Clear();

            for (int i = 0; i < newsList.Length; i++)
            {
                newsList[i] = new NewsListItem();
                newsList[i].AvatarPost = Resources.user;
                newsList[i].Nickname = "Polish Pro League #" + i;
                newsList[i].DatePost = DateTime.Now.ToString();
                newsList[i].TextPost =
                #region GenerowanyText
        "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vestibulum in tellus et erat fermentum efficitur vitae quis diam. Cras vitae elementum ligula. Proin volutpat enim est, nec suscipit orci blandit ultricies. Sed pharetra tincidunt laoreet. Ut a lacus suscipit, porta justo eleifend, consectetur augue. Maecenas ullamcorper, mauris ornare accumsan.";
                #endregion;
              
                flowLayoutPanelNews.Controls.Add(newsList[i]);
            }
        }

        #region SocialMedia

        private void twitter_Click(object sender, EventArgs e)
        {
            OpenUrl("https://twitter.com/klusekcs");
        }

        public static void OpenUrl(String site)
        {
            var result = MessageBox.Show("Nastąpi przekierowanie do " + site, "Ostrzeżenie o przekierowaniu", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
                System.Diagnostics.Process.Start("explorer.exe", site);
        }

        private void facebook_Click(object sender, EventArgs e)
        {
            OpenUrl("https://fb.com/klusekcs");
        }

        private void insta_Click(object sender, EventArgs e)
        {
            OpenUrl("https://instagram.com/klusek_");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            OpenUrl("https://open.spotify.com/user/kluuseek");

        }
        #endregion

        private void HomeControl_Load(object sender, EventArgs e)
        {
            populateItemsFlowLayoutPanel();
        }

        private void postBtn_Click(object sender, EventArgs e)
        {
            PublicNewPost();
        }


        private void postTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                postBtn_Click(sender, e);
                e.SuppressKeyPress = true;
            }
        }
    }
}
