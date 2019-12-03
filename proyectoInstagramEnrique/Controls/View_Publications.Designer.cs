namespace proyectoFinal.Controls
{
    partial class View_Publications
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
            this.viewPublication1 = new proyectoFinal.Controls.ViewPublication();
            this.viewPublication2 = new proyectoFinal.Controls.ViewPublication();
            this.viewPublication3 = new proyectoFinal.Controls.ViewPublication();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // viewPublication1
            // 
            this.viewPublication1.Location = new System.Drawing.Point(14, 47);
            this.viewPublication1.Name = "viewPublication1";
            this.viewPublication1.Size = new System.Drawing.Size(371, 504);
            this.viewPublication1.TabIndex = 0;
            // 
            // viewPublication2
            // 
            this.viewPublication2.Location = new System.Drawing.Point(391, 47);
            this.viewPublication2.Name = "viewPublication2";
            this.viewPublication2.Size = new System.Drawing.Size(371, 504);
            this.viewPublication2.TabIndex = 1;
            // 
            // viewPublication3
            // 
            this.viewPublication3.Location = new System.Drawing.Point(768, 47);
            this.viewPublication3.Name = "viewPublication3";
            this.viewPublication3.Size = new System.Drawing.Size(371, 504);
            this.viewPublication3.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button1.Font = new System.Drawing.Font("Mistral", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(412, 579);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 60);
            this.button1.TabIndex = 3;
            this.button1.Text = "<";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button2.Font = new System.Drawing.Font("Mistral", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(520, 579);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(70, 60);
            this.button2.TabIndex = 4;
            this.button2.Text = ">";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // View_Publications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.viewPublication3);
            this.Controls.Add(this.viewPublication2);
            this.Controls.Add(this.viewPublication1);
            this.Name = "View_Publications";
            this.Size = new System.Drawing.Size(1179, 708);
            this.ResumeLayout(false);

        }

        #endregion

        private ViewPublication viewPublication1;
        private ViewPublication viewPublication2;
        private ViewPublication viewPublication3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}
