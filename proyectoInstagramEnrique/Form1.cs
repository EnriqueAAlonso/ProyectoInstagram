using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using proyectoFinal.Classes;
using proyectoFinal.Controls;
using System.Drawing;
namespace proyectoInstagramEnrique
{
    public partial class Form1 : Form
    {
        private User currentUser;
        public string connectionStr = "data source=COMPENSATOR\\SQLEXPRESS02;initial catalog=fakeInstagram; integrated security = True";
        public Form1()
        {
            InitializeComponent();
            this.Icon =  new Icon("instagramLogo.ico");

            start1.setOwner(this);
            start1.Show();
            this.Height = 550;
            this.Width = 1000;
            testForm1.setOwner(this);
            testForm1.Hide();
            testForm1.updatecs(connectionStr);
        }

        public void login()
        {
            this.currentUser = null;
            this.Height = 550;
            this.Width = 1000;
            start1.Show();
            testForm1.Hide();


        }

        public void UserInt()
        {
            this.Height = 750;
            this.Width = 600;
            start1.Hide();
            testForm1.Show();
        }

        public void SetUser(User u)
        {
            currentUser = u;
            start1.Hide();
            testForm1.Show();
            testForm1.update(currentUser);
            this.UserInt();
            
        }
    }
}
