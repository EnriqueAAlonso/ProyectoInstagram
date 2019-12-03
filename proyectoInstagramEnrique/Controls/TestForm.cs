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
using proyectoInstagramEnrique;

namespace proyectoFinal.Controls
{
    public partial class TestForm : UserControl
    {
        private User currentUser;
        private UserService us;
        private Form1 owner;
        public TestForm()
        {
            InitializeComponent();
            makePublication1.Hide();
            updateProfile1.Hide();
            profileView1.Show();
            
        }

        public void setOwner(Form1 o)
        {
            owner = o;
            
        }

        public void updatecs(string cs)
        {
            us=new UserService(cs);
        }

        public void update(User u)
        {
            
            currentUser = u;
            u.updatePublications(us);
            currentUser.Clone(us.getPosts(currentUser), us.getFollowers(currentUser), us.getFollowing(currentUser));
            makePublication1.update(currentUser, us);
            updateProfile1.update(currentUser, us);
            label1.Text = "Welcome " + currentUser.username;
            label1.Show();
            profileView1.Show();
            profileView1.sendUser(currentUser);
            


        }

        public void clear()
        {
            currentUser = null;
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
        }
        

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void updateProfile1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            currentUser = null;
            owner.login();
        }
    }
}
