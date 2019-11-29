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
    public partial class start : UserControl
    {
        private Form1 owner;
        private User actual;
        private bool log = true;
        private string connectionstring;
        public start()
        {
            InitializeComponent();
            login1.setOwner(this);
            register1.setOwner(this);
            login1.Show();
            
            register1.Hide();

        }

        public void setuser(User u)
        {
            actual = u;
            owner.SetUser(actual);
            this.Hide();

        }

        public void setOwner(Form1 o)
        {
            owner = o;
            connectionstring = o.connectionStr;
            login1.updatecs(connectionstring);
            register1.updatecs(connectionstring);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (log)
            {
                log = false;
                login1.Hide();
                register1.Show();
                button1.Text = "Log in";
            }
            else
            {
                log = true;
                login1.Show();
                register1.Hide();
                button1.Text = "Register";
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
