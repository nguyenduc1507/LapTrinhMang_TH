namespace Server
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
            this.lb1 = new System.Windows.Forms.Label();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.lb2 = new System.Windows.Forms.Label();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Location = new System.Drawing.Point(13, 15);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(94, 13);
            this.lb1.TabIndex = 0;
            this.lb1.Text = "Lựa chọn của bạn";
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(112, 12);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(209, 20);
            this.txt1.TabIndex = 1;
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(30, 60);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(101, 100);
            this.btn1.TabIndex = 2;
            this.btn1.Text = "Kéo";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(137, 60);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(98, 100);
            this.btn2.TabIndex = 3;
            this.btn2.Text = "Bao";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(241, 60);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(93, 99);
            this.btn3.TabIndex = 4;
            this.btn3.Text = "Búa";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.Location = new System.Drawing.Point(14, 180);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(44, 13);
            this.lb2.TabIndex = 5;
            this.lb2.Text = "Kết quả";
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(64, 180);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(257, 20);
            this.txt2.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 224);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.lb2);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.lb1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.TextBox txt2;
    }
}

