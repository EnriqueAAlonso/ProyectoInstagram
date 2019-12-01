using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace proyectoFinal.Controls
{
    public partial class MakePublication : UserControl
    {
        public MakePublication()
        {
            InitializeComponent();
            openFileDialog1.Filter = "JPG (.jpg)|*.jpg|BMP (.bmp)|*.bmp|GIF (.gif)|*.gif|PNG (.png)|*.png";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int size = -1;
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                string file = openFileDialog1.FileName;
                try
                {
                    string text = File.ReadAllText(file);
                    size = text.Length;
                }
                catch (IOException)
                {
                }
            }
        }
    }
}
