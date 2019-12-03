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
            makePublication1.setOwner(this);
            viewStory1.setOwner(this);
            view_Publications1.Hide();


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
            currentUser.updatePublications(us);
            currentUser.Clone(us.getPosts(currentUser), us.getFollowers(currentUser), us.getFollowing(currentUser));
            makePublication1.update(currentUser, us);
            updateProfile1.update(currentUser, us);
            viewStory1.Hide();
            viewStory1.updateUser(currentUser,us);
            profileView1.Show();
            profileView1.sendUser(currentUser);
            view_Publications1.update(currentUser,us);
            view_Publications1.Width = 1300;



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

        private void button2_Click_1(object sender, EventArgs e)
        {
            makePost();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            userInterface();

        }

        public void userInterface()
        {
            this.update(currentUser);
            profileView1.sendUser(this.currentUser);
            profileView1.Show();
            makePublication1.clear();
            makePublication1.Hide();
            owner.UserInt();
            updateProfile1.Hide();
            updateProfile1.clear();
            viewStory1.Hide();
        }

        public void makePost()
        {
            profileView1.clear();
            profileView1.Hide();
            makePublication1.update(currentUser, us);
            makePublication1.Show();
            owner.MakePublication();
            updateProfile1.Hide();
            updateProfile1.clear();
            viewStory1.Hide();
            view_Publications1.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            updateProfile();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            viewStory();


        }

        public void updateProfile()
        {
            profileView1.clear();
            profileView1.Hide();
            makePublication1.clear();
            makePublication1.Hide();
            updateProfile1.Show();
            updateProfile1.update(currentUser, us);
            owner.UpdateProfile();
            viewStory1.Hide();
            view_Publications1.Hide();
        }

        public void viewStory()
        {
            profileView1.clear();
            profileView1.Hide();
            makePublication1.clear();
            makePublication1.Hide();
            updateProfile1.Hide();
            updateProfile1.clear();
            viewStory1.Show();
            owner.UserInt();
            viewStory1.run();
            view_Publications1.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            owner.viewPublications();
            view_Publications1.update(currentUser,us);
            view_Publications1.Show();
            profileView1.clear();
            profileView1.Hide();
            makePublication1.clear();
            makePublication1.Hide();
            updateProfile1.Hide();
            updateProfile1.clear();
            viewStory1.Hide();

        }
    }
}
