﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using proyectoFinal.Classes;
namespace proyectoFinal.Controls
{
    public partial class MakePublication : UserControl
    {
        private User user;
        private UserService usServ;
        private TestForm owner;
        private PubBuilder pub;
        public MakePublication()
        {
            InitializeComponent();
            openFileDialog1.Filter = "JPG (.jpg)|*.jpg|BMP (.bmp)|*.bmp|PNG (.png)|*.png";
        }

        public void update(User us, UserService userS)
        {
            textBox1.Text = "";
            pictureBox1.Image = null;
            user = us;
            usServ = userS;

        }

        public void setOwner(TestForm t)
        {
            owner = t;
        }

        public void clear()
        {
            textBox1.Text = "";
            pictureBox1.Image = null;
            user = null;
            usServ = null;
        }

        private Image img;
        private string desc;
        private void button1_Click(object sender, EventArgs e)
        {
            int size = -1;
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                string file = openFileDialog1.FileName;
                try
                {
                    img= Image.FromFile(file);
                    pictureBox1.Image = img;
                }
                catch (IOException)
                {
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            desc = textBox1.Text;
            pub=new Publication();
            pub.createPublication(desc,img,user);
            user.Publish((Publication)pub,usServ);
            this.clear();
            this.Hide();
            owner.userInterface();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pub=new Story();
            pub.createPublication(desc, img, user);
            user.PublishStory((Story)pub, usServ);
            this.clear();
            owner.userInterface();

        }
    }
}
