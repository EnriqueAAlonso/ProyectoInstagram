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
    public partial class Register : UserControl
    {
        private start owner;
        private UserService us;
        

        public void updatecs(string cs)
        {
            us = new UserService(cs);
        }

        public void setOwner(start o)
        {
            this.owner = o;

        }

        public Register()
        {
            InitializeComponent();
            
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
            string email = textBox2.Text;
            string password = textBox3.Text;
            if (IsValidEmail(email))
            {
                User u= new User(username, password, email);
                string text = us.AddUser(u);
                MessageBox.Show(text);
                if (text == "User registered correctly")
                {
                    owner.setuser(u);
                    textBox1.Text = "";
                    textBox2.Text = "";
                    

                }


                
            }
            else
            {
                MessageBox.Show("Please use a valid email account");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
