namespace proyectoFinal.Controls
{
    partial class TestForm
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.updateProfile1 = new proyectoFinal.Controls.UpdateProfile();
            this.makePublication1 = new proyectoFinal.Controls.MakePublication();
            this.profileView1 = new proyectoFinal.Controls.ProfileView();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.viewStory1 = new proyectoFinal.Controls.ViewStory();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button1.Font = new System.Drawing.Font("Mistral", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(12, 70);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 63);
            this.button1.TabIndex = 10;
            this.button1.Text = "Log Out";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // updateProfile1
            // 
            this.updateProfile1.Location = new System.Drawing.Point(138, 60);
            this.updateProfile1.Name = "updateProfile1";
            this.updateProfile1.Size = new System.Drawing.Size(579, 550);
            this.updateProfile1.TabIndex = 8;
            this.updateProfile1.Load += new System.EventHandler(this.updateProfile1_Load);
            // 
            // makePublication1
            // 
            this.makePublication1.Location = new System.Drawing.Point(129, 70);
            this.makePublication1.Name = "makePublication1";
            this.makePublication1.Size = new System.Drawing.Size(570, 566);
            this.makePublication1.TabIndex = 7;
            // 
            // profileView1
            // 
            this.profileView1.Location = new System.Drawing.Point(138, 70);
            this.profileView1.Name = "profileView1";
            this.profileView1.Size = new System.Drawing.Size(402, 625);
            this.profileView1.TabIndex = 11;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button2.Font = new System.Drawing.Font("Mistral", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(12, 155);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 90);
            this.button2.TabIndex = 12;
            this.button2.Text = "Make Publication";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button3.Font = new System.Drawing.Font("Mistral", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(12, 271);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 90);
            this.button3.TabIndex = 13;
            this.button3.Text = "Check Profile";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button4.Font = new System.Drawing.Font("Mistral", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.Location = new System.Drawing.Point(12, 381);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(120, 90);
            this.button4.TabIndex = 14;
            this.button4.Text = "Edit Profile";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button5.Font = new System.Drawing.Font("Mistral", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button5.Location = new System.Drawing.Point(12, 477);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(120, 90);
            this.button5.TabIndex = 15;
            this.button5.Text = "View Own Story";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // viewStory1
            // 
            this.viewStory1.Location = new System.Drawing.Point(164, 75);
            this.viewStory1.Name = "viewStory1";
            this.viewStory1.Size = new System.Drawing.Size(376, 464);
            this.viewStory1.TabIndex = 16;
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.viewStory1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.updateProfile1);
            this.Controls.Add(this.makePublication1);
            this.Controls.Add(this.profileView1);
            this.Name = "TestForm";
            this.Size = new System.Drawing.Size(678, 854);
            this.ResumeLayout(false);

        }

        #endregion
        private MakePublication makePublication1;
        private UpdateProfile updateProfile1;
        private System.Windows.Forms.Button button1;
        private ProfileView profileView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private ViewStory viewStory1;
    }
}
