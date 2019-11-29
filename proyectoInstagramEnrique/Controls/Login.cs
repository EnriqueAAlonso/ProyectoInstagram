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
    public partial class Login : UserControl
    {
        public Login()
        {
            InitializeComponent();
        }
        private start owner;
        private UserService us;
        
        public void setOwner(start o)
        {
            this.owner = o;
            
        }
        public void updatecs(string cs)
        {
            us = new UserService(cs);
        }
        bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;

                if (us.loginUser(username, password))
                {
                    MessageBox.Show("Login successful");
                    User u = us.getUser(username);
                    owner.setuser(u);
                }

                else MessageBox.Show("Login failed");
            
        }
    }
}
