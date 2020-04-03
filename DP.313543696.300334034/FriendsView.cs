using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DP._313543696._300334034
{
    public partial class FriendsView : Form
    {
        #region Members
        private FacebookWrapper.ObjectModel.User m_LoggedInUser;
        #endregion

        #region Constructor
        public FriendsView(FacebookWrapper.ObjectModel.User i_LoggedInUser)
        {
            InitializeComponent();
            this.m_LoggedInUser = i_LoggedInUser;
        }

        #endregion

        private void FriendsView_Load(object sender, EventArgs e)
        {
            foreach(var friend in m_LoggedInUser.Friends)
            {
                AddPictureBoxToLayout(friend.Name, this.flowLayout_Pictures).Load(friend.PictureNormalURL);
            }
        }

        private PictureBox AddPictureBoxToLayout(string i_PicName, Panel i_DestPanel)
        {
            PictureBox picBox = new PictureBox();
            picBox.Name = "PicBox_" + i_PicName;
            picBox.Size = new System.Drawing.Size(75, 75);
            picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            picBox.Visible = true;

            i_DestPanel.Controls.Add(picBox);
            return picBox;
        }
    }
}
