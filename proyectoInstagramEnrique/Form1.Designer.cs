using System.Drawing;

namespace proyectoInstagramEnrique
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.testForm1 = new proyectoFinal.Controls.TestForm();
            this.start1 = new proyectoFinal.Controls.start();
            this.SuspendLayout();
            // 
            // testForm1
            // 
            this.testForm1.Location = new System.Drawing.Point(12, -3);
            this.testForm1.Name = "testForm1";
            this.testForm1.Size = new System.Drawing.Size(963, 775);
            this.testForm1.TabIndex = 1;
            // 
            // start1
            // 
            this.start1.Location = new System.Drawing.Point(4, 12);
            this.start1.Name = "start1";
            this.start1.Size = new System.Drawing.Size(1077, 425);
            this.start1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 880);
            this.Controls.Add(this.testForm1);
            this.Controls.Add(this.start1);
            this.Name = "Form1";
            this.Text = "Instagram";
            this.ResumeLayout(false);

        }

        #endregion

        private proyectoFinal.Controls.start start1;
        private proyectoFinal.Controls.TestForm testForm1;
    }
}

