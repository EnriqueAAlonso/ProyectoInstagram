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

namespace proyectoInstagramEnrique
{
    public partial class Form1 : Form
    {
        private User currentUser;
        public string connectionStr = "data source=COMPENSATOR\\SQLEXPRESS02;initial catalog=fakeInstagram; integrated security = True";
        public Form1()
        {
            InitializeComponent();
            start1.setOwner(this);
            start1.Show();
            testForm1.Hide();
            testForm1.updatecs(connectionStr);
        }

        public void SetUser(User u)
        {
            currentUser = u;
            start1.Hide();
            testForm1.Show();
            testForm1.update(currentUser);
            
        }
    }
}
