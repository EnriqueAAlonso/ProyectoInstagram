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
            this.start1 = new proyectoFinal.Controls.start();
            this.testForm1 = new proyectoFinal.Controls.TestForm();
            this.makePublication1 = new proyectoFinal.Controls.MakePublication();
            this.SuspendLayout();
            // 
            // start1
            // 
            this.start1.Location = new System.Drawing.Point(18, 12);
            this.start1.Name = "start1";
            this.start1.Size = new System.Drawing.Size(1077, 425);
            this.start1.TabIndex = 0;
            // 
            // testForm1
            // 
            this.testForm1.Location = new System.Drawing.Point(12, -3);
            this.testForm1.Name = "testForm1";
            this.testForm1.Size = new System.Drawing.Size(963, 550);
            this.testForm1.TabIndex = 1;
            // 
            // makePublication1
            // 
            this.makePublication1.Location = new System.Drawing.Point(19, 8);
            this.makePublication1.Name = "makePublication1";
            this.makePublication1.Size = new System.Drawing.Size(983, 538);
            this.makePublication1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 559);
            this.Controls.Add(this.makePublication1);
            this.Controls.Add(this.testForm1);
            this.Controls.Add(this.start1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private proyectoFinal.Controls.start start1;
        private proyectoFinal.Controls.TestForm testForm1;
        private proyectoFinal.Controls.MakePublication makePublication1;
    }
}

