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
    public partial class userPanel : UserControl
    {
        private User us;
        public userPanel()
        {
            InitializeComponent();

        }

        public void update(User user)
        {
            us = user;
            pictureBox1.Image = Image.FromFile(us.pPicturePath);
            label1.Text = us.username;
        }

        public void clear()
        {
            us = null;
            pictureBox1.Image = null;

        }

       

        public User getUser()
        {
            return us;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
