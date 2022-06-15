namespace Threading
{
    partial class TaskFrm
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
            this.Taskbtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Cancelbtn = new System.Windows.Forms.Button();
            this.Linqbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Taskbtn
            // 
            this.Taskbtn.Location = new System.Drawing.Point(21, 12);
            this.Taskbtn.Name = "Taskbtn";
            this.Taskbtn.Size = new System.Drawing.Size(92, 31);
            this.Taskbtn.TabIndex = 0;
            this.Taskbtn.Text = "Start Task";
            this.Taskbtn.UseVisualStyleBackColor = true;
            this.Taskbtn.Click += new System.EventHandler(this.Taskbtn_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(34, 66);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(739, 318);
            this.textBox1.TabIndex = 1;
            // 
            // Cancelbtn
            // 
            this.Cancelbtn.Location = new System.Drawing.Point(119, 12);
            this.Cancelbtn.Name = "Cancelbtn";
            this.Cancelbtn.Size = new System.Drawing.Size(92, 31);
            this.Cancelbtn.TabIndex = 2;
            this.Cancelbtn.Text = "cancel Task";
            this.Cancelbtn.UseVisualStyleBackColor = true;
            this.Cancelbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // Linqbtn
            // 
            this.Linqbtn.Location = new System.Drawing.Point(218, 12);
            this.Linqbtn.Name = "Linqbtn";
            this.Linqbtn.Size = new System.Drawing.Size(92, 31);
            this.Linqbtn.TabIndex = 3;
            this.Linqbtn.Text = "Parallel Linq";
            this.Linqbtn.UseVisualStyleBackColor = true;
            this.Linqbtn.Click += new System.EventHandler(this.Linqbtn_Click);
            // 
            // TaskFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 421);
            this.Controls.Add(this.Linqbtn);
            this.Controls.Add(this.Cancelbtn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Taskbtn);
            this.Name = "TaskFrm";
            this.Text = "TaskFrm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Taskbtn;
        private TextBox textBox1;
        private Button Cancelbtn;
        private Button Linqbtn;
    }
}