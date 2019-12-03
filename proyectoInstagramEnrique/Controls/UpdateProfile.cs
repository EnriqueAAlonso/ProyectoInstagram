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
using System.Drawing;
using System.IO;
namespace proyectoFinal.Controls
{
    public partial class UpdateProfile : UserControl
    {
        private Image img;
        private User user;
        private UserService usService;
        public UpdateProfile()
        {
            InitializeComponent();
            openFileDialog1.Filter = "JPG (.jpg)|*.jpg|BMP (.bmp)|*.bmp|PNG (.png)|*.png";
        }
       
        public void update(User u, UserService us)
        {
            user = u;
            usService = us;
            label3.Text = user.username;
            label4.Text = user.email;
            if (user.pPicturePath != null)
            {
                
                pictureBox1.Image = Image.FromFile(user.pPicturePath);
            }

            textBox1.Text = user.bio;


        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            
            
            
            user.bio = textBox1.Text;
            
            usService.updateDesc(user);
        }

        private int imgType = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            int size = -1;
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                string file = openFileDialog1.FileName;
                try
                {
                    pictureBox1.Image.Dispose();
                    pictureBox1.Image = null;
                   
                   
                    pictureBox1.Image = Image.FromFile(file);
                }
                catch (IOException)
                {
                }
            }
        }

        public void clear()
        {
            this.textBox1.Text = "";
            this.pictureBox1.Image = null;
            this.user = null;
            this.usService = null;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            user.setImg(pictureBox1.Image);
            usService.updatePicture(user);

            pictureBox1.Image.Dispose();
            pictureBox1.Image = null;

            pictureBox1.Image = Image.FromFile(user.pPicturePath);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.clear();
            this.Hide();
        }
    }
    
}
