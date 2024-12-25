namespace _35Threading
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.btnStartT1 = new System.Windows.Forms.Button();
            this.btnStartT2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 17;
            this.listBox1.Location = new System.Drawing.Point(23, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(155, 276);
            this.listBox1.TabIndex = 0;
            // 
            // listBox2
            // 
            this.listBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 17;
            this.listBox2.Location = new System.Drawing.Point(405, 12);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(155, 276);
            this.listBox2.TabIndex = 1;
            // 
            // btnStartT1
            // 
            this.btnStartT1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.btnStartT1.Location = new System.Drawing.Point(227, 12);
            this.btnStartT1.Name = "btnStartT1";
            this.btnStartT1.Size = new System.Drawing.Size(128, 31);
            this.btnStartT1.TabIndex = 2;
            this.btnStartT1.Text = "Start T1";
            this.btnStartT1.UseVisualStyleBackColor = true;
            this.btnStartT1.Click += new System.EventHandler(this.btnStartT1_Click);
            // 
            // btnStartT2
            // 
            this.btnStartT2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.btnStartT2.Location = new System.Drawing.Point(227, 58);
            this.btnStartT2.Name = "btnStartT2";
            this.btnStartT2.Size = new System.Drawing.Size(128, 31);
            this.btnStartT2.TabIndex = 3;
            this.btnStartT2.Text = "Start T2";
            this.btnStartT2.UseVisualStyleBackColor = true;
            this.btnStartT2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 407);
            this.Controls.Add(this.btnStartT2);
            this.Controls.Add(this.btnStartT1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button btnStartT1;
        private System.Windows.Forms.Button btnStartT2;
    }
}

