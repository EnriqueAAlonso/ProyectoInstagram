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
    public partial class View_Publications : UserControl
    {
        public View_Publications()
        {
            InitializeComponent();
        }

        private User currentUser;
        private UserService userService;
        private List<string> posts;
        private ProfileIterator pI;
        public void update(User u, UserService us)
        {
            currentUser = u;
            userService = us;
            pI = new ProfileIterator(u.publication,3);
            pI.resetIterator();
            posts=new List<string>();
            posts = pI.getProfiles();
            getPosts();

        }

        public void getPosts()
        {
            viewPublication1.Hide();
            viewPublication2.Hide();
            viewPublication3.Hide();
            if(pI.next())button2.Show();
            else button2.Hide();
            if (pI.back()) button1.Show();
            else button1.Hide();
            if (posts.Count > 0)
            {
                viewPublication1.UpdateView(userService.getPost(posts[0]),userService,currentUser, currentUser);
                viewPublication1.Show();
            }
            if (posts.Count > 1)
            {
                viewPublication2.UpdateView(userService.getPost(posts[1]), userService, currentUser, currentUser);
                viewPublication2.Show();
            }
            if (posts.Count > 2)
            {
                viewPublication3.UpdateView(userService.getPost(posts[2]), userService, currentUser,currentUser);
                viewPublication3.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pI.navigateBack();
            posts = pI.getProfiles();
            getPosts();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pI.navigateFront();
            posts = pI.getProfiles();
            getPosts();
        }
    }
}
