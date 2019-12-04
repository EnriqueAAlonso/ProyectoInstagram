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

        private bool liked = false;
        private User user;
        private User viewer;
        private UserService thisUS;
        private Publication thisPub;
        public void UpdateView(Publication pub, UserService uS, User u, User view)
        {
            viewer = view;
            thisPub = pub;
            thisUS = uS;
            user = u;
            this.pictureBox1.Image = Image.FromFile(pub.imgPath);
            this.label1.Text = thisUS.getLikes(pub).ToString()+" likes";
            if (thisUS.liked(pub.id, viewer))
            {
                label2.ForeColor = Color.Pink;
                liked = true;
            }

            else
            {
                label2.ForeColor = Color.Black;
                liked = false;
            }

            
            textBox1.Text = pub.description;

            if (viewer.username == user.username) label2.Hide();
            else label2.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            if (liked)
            {
                thisUS.removeLike(viewer,thisPub);
                label2.ForeColor = Color.Black;
                liked = false;
                this.label1.Text = thisUS.getLikes(thisPub).ToString() + " likes";
            }
            else
            {
                label2.ForeColor = Color.Pink;
                liked = true;
                thisUS.giveLike(viewer, thisPub);
                this.label1.Text = thisUS.getLikes(thisPub).ToString() + " likes";
            }
        }
    }
}
