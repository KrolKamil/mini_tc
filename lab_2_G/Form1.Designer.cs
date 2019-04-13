namespace lab_2_G
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
            this.minTCPanel2 = new lab_2_G.MinTCPanel();
            this.minTCPanel1 = new lab_2_G.MinTCPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // minTCPanel2
            // 
            this.minTCPanel2.CurrentPath = "";
            this.minTCPanel2.Location = new System.Drawing.Point(382, 13);
            this.minTCPanel2.Name = "minTCPanel2";
            this.minTCPanel2.Size = new System.Drawing.Size(288, 414);
            this.minTCPanel2.TabIndex = 1;
            // 
            // minTCPanel1
            // 
            this.minTCPanel1.CurrentPath = "";
            this.minTCPanel1.Location = new System.Drawing.Point(51, 13);
            this.minTCPanel1.Name = "minTCPanel1";
            this.minTCPanel1.Size = new System.Drawing.Size(316, 425);
            this.minTCPanel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(320, 218);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 45);
            this.button1.TabIndex = 2;
            this.button1.Text = "=>";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 447);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.minTCPanel2);
            this.Controls.Add(this.minTCPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private MinTCPanel minTCPanel1;
        private MinTCPanel minTCPanel2;
        private System.Windows.Forms.Button button1;
    }
}

