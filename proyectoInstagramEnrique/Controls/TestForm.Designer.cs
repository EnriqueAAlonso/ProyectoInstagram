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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.updateProfile1 = new proyectoFinal.Controls.UpdateProfile();
            this.makePublication1 = new proyectoFinal.Controls.MakePublication();
            this.profileView1 = new proyectoFinal.Controls.ProfileView();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mistral", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(90, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 38);
            this.label1.TabIndex = 9;
            this.label1.Text = "label1";
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
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // updateProfile1
            // 
            this.updateProfile1.Location = new System.Drawing.Point(138, 31);
            this.updateProfile1.Name = "updateProfile1";
            this.updateProfile1.Size = new System.Drawing.Size(579, 550);
            this.updateProfile1.TabIndex = 8;
            this.updateProfile1.Load += new System.EventHandler(this.updateProfile1_Load);
            // 
            // makePublication1
            // 
            this.makePublication1.Location = new System.Drawing.Point(138, 15);
            this.makePublication1.Name = "makePublication1";
            this.makePublication1.Size = new System.Drawing.Size(570, 566);
            this.makePublication1.TabIndex = 7;
            // 
            // profileView1
            // 
            this.profileView1.Location = new System.Drawing.Point(138, 65);
            this.profileView1.Name = "profileView1";
            this.profileView1.Size = new System.Drawing.Size(402, 625);
            this.profileView1.TabIndex = 11;
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.profileView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.updateProfile1);
            this.Controls.Add(this.makePublication1);
            this.Name = "TestForm";
            this.Size = new System.Drawing.Size(618, 693);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MakePublication makePublication1;
        private UpdateProfile updateProfile1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private ProfileView profileView1;
    }
}
