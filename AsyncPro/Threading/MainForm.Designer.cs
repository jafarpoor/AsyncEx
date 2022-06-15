namespace Threading
{
    partial class MainForm
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
            this.Startbtn = new System.Windows.Forms.Button();
            this.Stopbtn = new System.Windows.Forms.Button();
            this.textOutPut = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Startbtn
            // 
            this.Startbtn.Location = new System.Drawing.Point(12, 12);
            this.Startbtn.Name = "Startbtn";
            this.Startbtn.Size = new System.Drawing.Size(108, 27);
            this.Startbtn.TabIndex = 0;
            this.Startbtn.Text = "Start";
            this.Startbtn.UseVisualStyleBackColor = true;
            this.Startbtn.Click += new System.EventHandler(this.Startbtn_Click);
            // 
            // Stopbtn
            // 
            this.Stopbtn.Location = new System.Drawing.Point(126, 12);
            this.Stopbtn.Name = "Stopbtn";
            this.Stopbtn.Size = new System.Drawing.Size(108, 27);
            this.Stopbtn.TabIndex = 1;
            this.Stopbtn.Text = "Stop";
            this.Stopbtn.UseVisualStyleBackColor = true;
            this.Stopbtn.Click += new System.EventHandler(this.Stopbtn_Click);
            // 
            // textOutPut
            // 
            this.textOutPut.Location = new System.Drawing.Point(8, 65);
            this.textOutPut.Multiline = true;
            this.textOutPut.Name = "textOutPut";
            this.textOutPut.Size = new System.Drawing.Size(782, 352);
            this.textOutPut.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textOutPut);
            this.Controls.Add(this.Stopbtn);
            this.Controls.Add(this.Startbtn);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Startbtn;
        private Button Stopbtn;
        private TextBox textOutPut;
    }
}