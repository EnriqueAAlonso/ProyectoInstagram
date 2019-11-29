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
            currentUser.following =new List<string>();
            var following=us.getFollowing(currentUser);
            foreach (var person in following)
            {
                currentUser.following.Add(person);
            }

            comboBox1.DataSource = currentUser.following;
            var followers= us.getFollowers(u);
            currentUser.followers=new List<string>();
            foreach (var person in followers)
            {
                currentUser.followers.Add(person);
            }
            foreach (var f in currentUser.followers)
            {
                textBox1.AppendText(f+Environment.NewLine);
            }
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var val = comboBox1.Text;
            if (val != null)
            {
                us.unFollow(currentUser.username,val);
                update(currentUser);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var val = textBox2.Text;
            if (val != null)
            {
                if (us.follow(currentUser.username, textBox2.Text))
                {
                    MessageBox.Show("Follow Successful");
                    update(currentUser);
                }
                else
                {
                    MessageBox.Show("follow unsuccessful");
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
