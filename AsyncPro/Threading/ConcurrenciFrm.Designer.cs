namespace Threading
{
    partial class ConcurrenciFrm
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Asyncbtn = new System.Windows.Forms.Button();
            this.txt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(208, 49);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 27);
            this.textBox1.TabIndex = 0;
            // 
            // Asyncbtn
            // 
            this.Asyncbtn.Location = new System.Drawing.Point(12, 12);
            this.Asyncbtn.Name = "Asyncbtn";
            this.Asyncbtn.Size = new System.Drawing.Size(135, 43);
            this.Asyncbtn.TabIndex = 0;
            this.Asyncbtn.Text = "Async";
            this.Asyncbtn.UseVisualStyleBackColor = true;
            this.Asyncbtn.Click += new System.EventHandler(this.Asyncbtn_Click);
            // 
            // txt
            // 
            this.txt.Location = new System.Drawing.Point(24, 75);
            this.txt.Multiline = true;
            this.txt.Name = "txt";
            this.txt.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt.Size = new System.Drawing.Size(579, 283);
            this.txt.TabIndex = 1;
            // 
            // ConcurrenciFrm
            // 
            this.ClientSize = new System.Drawing.Size(618, 391);
            this.Controls.Add(this.txt);
            this.Controls.Add(this.Asyncbtn);
            this.Name = "ConcurrenciFrm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private Button Asyncbtn;
        private TextBox txt;
    }
}