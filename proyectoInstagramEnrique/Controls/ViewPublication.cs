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
    public partial class ViewPublication : UserControl
    {
        public ViewPublication()
        {
            InitializeComponent();
        }

        private User user;
        private UserService thisUS;
        private Publication thisPub;
        public void UpdateView(Publication pub, UserService uS, User u)
        {
            thisPub = pub;
            thisUS = uS;
            user = u;
            this.pictureBox1.Image = pub.image;
            this.label1.Text = thisUS.getLikes(pub.id).ToString()+" likes";
            if (thisUS.liked(pub.id, user)) label2.ForeColor = Color.Pink;
            else label2.ForeColor = Color.Black;
        }
    }
}
