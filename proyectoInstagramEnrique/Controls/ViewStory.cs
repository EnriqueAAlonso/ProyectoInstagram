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
using System.Threading;
using System.Threading.Tasks;
namespace proyectoFinal.Controls
{
    public partial class ViewStory : UserControl
    {
        private User currentUser;
        private UserService us;
        private TestForm owner;
        private bool exit = false;
        public ViewStory()
        {
            InitializeComponent();
        }

        public void updateUser(User u, UserService userserv)
        {
            currentUser = u;
            us = userserv;
            iter = 0;
        }

        public void setOwner(TestForm t)
        {
            owner = t;
        }

        private int iter = 0;
        public void run()
        {
            us.deleteStory();
            List<string> stories = us.getStories(currentUser);
            if(iter<stories.Count||iter<0) pictureBox1.Image = Image.FromFile(stories[iter]);
            else
            {
                iter = 0;
                owner.userInterface();
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            iter += 1;
            run();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            iter -= 1;
            run();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            iter = 0;
            owner.userInterface();
        }
    }
}
