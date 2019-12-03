using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using proyectoFinal.Classes;
namespace proyectoFinal.Controls
{
    public partial class ProfileView : UserControl
    {
        private User currentUser;
        public ProfileView()
        {
            InitializeComponent();
        }

        public void sendUser(User user)
        {
            currentUser = user;
            label1.Text = user.username;
            label2.Text = "Followers";
            label3.Text = "Following";
            label4.Text = user.followers.Count.ToString();
            label5.Text = user.following.Count.ToString();
            textBox1.Text = user.bio;
            pictureBox1.Image = Image.FromFile(user.pPicturePath);
        }

        public void clear()
        {
            currentUser = null;
            label1.Text = "";
            label2.Text = "Followers";
            label3.Text = "Following";
            label4.Text = "";
            label5.Text = "";
            textBox1.Text = "";
            pictureBox1.Image = null;
        }
    }
}
