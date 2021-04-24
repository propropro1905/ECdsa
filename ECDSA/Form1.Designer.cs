
namespace ECDSA
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.PublicKeyY = new System.Windows.Forms.TextBox();
            this.PublicKeyX = new System.Windows.Forms.TextBox();
            this.PrivateKey = new System.Windows.Forms.TextBox();
            this.Sign = new System.Windows.Forms.Button();
            this.verify = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(64, 41);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(118, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(64, 67);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(118, 20);
            this.textBox2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(21, 103);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(225, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(563, 426);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // PublicKeyY
            // 
            this.PublicKeyY.Location = new System.Drawing.Point(21, 257);
            this.PublicKeyY.Name = "PublicKeyY";
            this.PublicKeyY.Size = new System.Drawing.Size(161, 20);
            this.PublicKeyY.TabIndex = 4;
            // 
            // PublicKeyX
            // 
            this.PublicKeyX.Location = new System.Drawing.Point(21, 231);
            this.PublicKeyX.Name = "PublicKeyX";
            this.PublicKeyX.Size = new System.Drawing.Size(161, 20);
            this.PublicKeyX.TabIndex = 5;
            // 
            // PrivateKey
            // 
            this.PrivateKey.Location = new System.Drawing.Point(21, 205);
            this.PrivateKey.Name = "PrivateKey";
            this.PrivateKey.Size = new System.Drawing.Size(161, 20);
            this.PrivateKey.TabIndex = 6;
            // 
            // Sign
            // 
            this.Sign.Location = new System.Drawing.Point(21, 176);
            this.Sign.Name = "Sign";
            this.Sign.Size = new System.Drawing.Size(75, 23);
            this.Sign.TabIndex = 7;
            this.Sign.Text = "Sign";
            this.Sign.UseVisualStyleBackColor = true;
            this.Sign.Click += new System.EventHandler(this.button2_Click);
            // 
            // verify
            // 
            this.verify.Location = new System.Drawing.Point(107, 176);
            this.verify.Name = "verify";
            this.verify.Size = new System.Drawing.Size(75, 23);
            this.verify.TabIndex = 8;
            this.verify.Text = "Verify";
            this.verify.UseVisualStyleBackColor = true;
            this.verify.Click += new System.EventHandler(this.verify_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.verify);
            this.Controls.Add(this.Sign);
            this.Controls.Add(this.PrivateKey);
            this.Controls.Add(this.PublicKeyX);
            this.Controls.Add(this.PublicKeyY);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox PublicKeyY;
        private System.Windows.Forms.TextBox PublicKeyX;
        private System.Windows.Forms.TextBox PrivateKey;
        private System.Windows.Forms.Button Sign;
        private System.Windows.Forms.Button verify;
    }
}

