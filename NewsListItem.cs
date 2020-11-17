using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace TitaniumControlsApp
{
    public partial class NewsListItem : UserControl
    {
        public NewsListItem()
        {
            InitializeComponent();
        }




        #region Properties

        private string _nickname;
        private string _datepost;
        private string _textPost;
        private Image _avatarPost;

        [Category("Custom Props")]
        public string Nickname
        {
            get { return _nickname; }
            set { _nickname = value; nicknameLbl.Text = value; }
        }

        [Category("Custom Props")]
        public string DatePost
        {
            get { return _datepost; }
            set { _datepost = value; dateLbl.Text = value; }
        }

        [Category("Custom Props")]
        public string TextPost
        {
            get { return _textPost; }
            set { _textPost = value; postTextBox.Text = value; }
        }

        [Category("Custom Props")]
        public Image AvatarPost
        {
            get { return _avatarPost; }
            set { _avatarPost = value; avatarPictureBox.Image = value; }
        }


        #endregion



    }
}
