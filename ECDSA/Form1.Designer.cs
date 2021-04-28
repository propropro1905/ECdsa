
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
            this.output = new System.Windows.Forms.RichTextBox();
            this.Sign = new System.Windows.Forms.Button();
            this.verify = new System.Windows.Forms.Button();
            this.ECDSAType = new System.Windows.Forms.ComboBox();
            this.signtype = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ECbit = new System.Windows.Forms.ComboBox();
            this.namedCurves = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.privatekey = new System.Windows.Forms.RichTextBox();
            this.publickey = new System.Windows.Forms.RichTextBox();
            this.privatekey_label = new System.Windows.Forms.Label();
            this.Publickey_label = new System.Windows.Forms.Label();
            this.message = new System.Windows.Forms.RichTextBox();
            this.message_label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.clear_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // output
            // 
            this.output.Location = new System.Drawing.Point(337, 12);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(575, 550);
            this.output.TabIndex = 3;
            this.output.Text = "";
            // 
            // Sign
            // 
            this.Sign.Location = new System.Drawing.Point(12, 539);
            this.Sign.Name = "Sign";
            this.Sign.Size = new System.Drawing.Size(103, 23);
            this.Sign.TabIndex = 7;
            this.Sign.Text = "Sign";
            this.Sign.UseVisualStyleBackColor = true;
            this.Sign.Click += new System.EventHandler(this.sign_Click);
            // 
            // verify
            // 
            this.verify.Location = new System.Drawing.Point(228, 539);
            this.verify.Name = "verify";
            this.verify.Size = new System.Drawing.Size(103, 23);
            this.verify.TabIndex = 8;
            this.verify.Text = "Verify";
            this.verify.UseVisualStyleBackColor = true;
            this.verify.Click += new System.EventHandler(this.verify_Click);
            // 
            // ECDSAType
            // 
            this.ECDSAType.FormattingEnabled = true;
            this.ECDSAType.Items.AddRange(new object[] {
            "ECDSA",
            "ECGDSA"});
            this.ECDSAType.Location = new System.Drawing.Point(12, 85);
            this.ECDSAType.Name = "ECDSAType";
            this.ECDSAType.Size = new System.Drawing.Size(319, 21);
            this.ECDSAType.TabIndex = 9;
            this.ECDSAType.SelectedIndexChanged += new System.EventHandler(this.ECDSAType_SelectedIndexChanged);
            // 
            // signtype
            // 
            this.signtype.AutoSize = true;
            this.signtype.Location = new System.Drawing.Point(9, 69);
            this.signtype.Name = "signtype";
            this.signtype.Size = new System.Drawing.Size(91, 13);
            this.signtype.TabIndex = 10;
            this.signtype.Text = "Type of Signature";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Chose your Elliptic Curve";
            // 
            // ECbit
            // 
            this.ECbit.FormattingEnabled = true;
            this.ECbit.Items.AddRange(new object[] {
            "112 bits",
            "128 bits",
            "160 bits",
            "192 bits",
            "224 bits",
            "256 bits",
            "384 bits",
            "521 bits"});
            this.ECbit.Location = new System.Drawing.Point(12, 45);
            this.ECbit.Name = "ECbit";
            this.ECbit.Size = new System.Drawing.Size(154, 21);
            this.ECbit.TabIndex = 13;
            this.ECbit.SelectedIndexChanged += new System.EventHandler(this.bitCurves_SelectedIndexChanged);
            // 
            // namedCurves
            // 
            this.namedCurves.FormattingEnabled = true;
            this.namedCurves.Location = new System.Drawing.Point(177, 45);
            this.namedCurves.Name = "namedCurves";
            this.namedCurves.Size = new System.Drawing.Size(154, 21);
            this.namedCurves.TabIndex = 14;
            this.namedCurves.SelectedIndexChanged += new System.EventHandler(this.namedCurves_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 112);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(159, 153);
            this.button2.TabIndex = 15;
            this.button2.Text = "Generate Key Pair";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.GenerateKeyPair_Click);
            // 
            // privatekey
            // 
            this.privatekey.Location = new System.Drawing.Point(177, 128);
            this.privatekey.Name = "privatekey";
            this.privatekey.Size = new System.Drawing.Size(154, 59);
            this.privatekey.TabIndex = 16;
            this.privatekey.Text = "";
            // 
            // publickey
            // 
            this.publickey.Location = new System.Drawing.Point(177, 206);
            this.publickey.Name = "publickey";
            this.publickey.Size = new System.Drawing.Size(154, 59);
            this.publickey.TabIndex = 17;
            this.publickey.Text = "";
            // 
            // privatekey_label
            // 
            this.privatekey_label.AutoSize = true;
            this.privatekey_label.Location = new System.Drawing.Point(174, 112);
            this.privatekey_label.Name = "privatekey_label";
            this.privatekey_label.Size = new System.Drawing.Size(61, 13);
            this.privatekey_label.TabIndex = 18;
            this.privatekey_label.Text = "Private Key";
            // 
            // Publickey_label
            // 
            this.Publickey_label.AutoSize = true;
            this.Publickey_label.Location = new System.Drawing.Point(174, 190);
            this.Publickey_label.Name = "Publickey_label";
            this.Publickey_label.Size = new System.Drawing.Size(57, 13);
            this.Publickey_label.TabIndex = 19;
            this.Publickey_label.Text = "Public Key";
            // 
            // message
            // 
            this.message.Location = new System.Drawing.Point(12, 284);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(319, 249);
            this.message.TabIndex = 20;
            this.message.Text = "";
            // 
            // message_label
            // 
            this.message_label.AutoSize = true;
            this.message_label.Location = new System.Drawing.Point(12, 268);
            this.message_label.Name = "message_label";
            this.message_label.Size = new System.Drawing.Size(50, 13);
            this.message_label.TabIndex = 21;
            this.message_label.Text = "Message";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Number of bits";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(177, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Named curve";
            // 
            // clear_btn
            // 
            this.clear_btn.Location = new System.Drawing.Point(121, 539);
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.Size = new System.Drawing.Size(101, 23);
            this.clear_btn.TabIndex = 24;
            this.clear_btn.Text = "Clear";
            this.clear_btn.UseVisualStyleBackColor = true;
            this.clear_btn.Click += new System.EventHandler(this.clear_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 574);
            this.Controls.Add(this.clear_btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.message_label);
            this.Controls.Add(this.message);
            this.Controls.Add(this.Publickey_label);
            this.Controls.Add(this.privatekey_label);
            this.Controls.Add(this.publickey);
            this.Controls.Add(this.privatekey);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.namedCurves);
            this.Controls.Add(this.ECbit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.signtype);
            this.Controls.Add(this.ECDSAType);
            this.Controls.Add(this.verify);
            this.Controls.Add(this.Sign);
            this.Controls.Add(this.output);
            this.Name = "Form1";
            this.Text = "ECDSA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox output;
        private System.Windows.Forms.Button Sign;
        private System.Windows.Forms.Button verify;
        private System.Windows.Forms.ComboBox ECDSAType;
        private System.Windows.Forms.Label signtype;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ECbit;
        private System.Windows.Forms.ComboBox namedCurves;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RichTextBox privatekey;
        private System.Windows.Forms.RichTextBox publickey;
        private System.Windows.Forms.Label privatekey_label;
        private System.Windows.Forms.Label Publickey_label;
        private System.Windows.Forms.RichTextBox message;
        private System.Windows.Forms.Label message_label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button clear_btn;
    }
}

