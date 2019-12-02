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
            openFileDialog1.Filter = "JPG (.jpg)|*.jpg";
        }
       
        public void update(User u, UserService us)
        {
            user = u;
            usService = us;
            label3.Text = user.username;
            label4.Text = user.email;
            if (user.pPicturePath != null)
            {

                img = Image.FromFile(user.pPicturePath);
                
                pictureBox1.Image = new Bitmap(img);
            }

            textBox1.Text = user.bio;


        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            
            user.setImg(new Bitmap(pictureBox1.Image));
            user.bio = textBox1.Text;
            usService.updatePicture(user);
            usService.updateDesc(user);
            pictureBox1.Image = user.profilePicture;
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
                    img = Image.FromFile(file);
                    if (file.Substring(file.Length - 3) == "jpg") imgType = 1;
                    else if ((file.Substring(file.Length - 3) == "bmp")) imgType = 2;
                    else imgType = 3;
                    pictureBox1.Image = img;
                }
                catch (IOException)
                {
                }
            }
        }
    }
    
}
