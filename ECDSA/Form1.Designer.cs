
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.ECDSAtab = new System.Windows.Forms.TabPage();
            this.Elgamaltab = new System.Windows.Forms.TabPage();
            this.MStab = new System.Windows.Forms.TabPage();
            this.BobButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.ELgamalBobPrivateKey = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ElgammaBobPublicKey = new System.Windows.Forms.RichTextBox();
            this.ElgamalEncryption = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.ECDSAtab.SuspendLayout();
            this.Elgamaltab.SuspendLayout();
            this.SuspendLayout();
            // 
            // output
            // 
            this.output.Location = new System.Drawing.Point(360, 45);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(552, 517);
            this.output.TabIndex = 3;
            this.output.Text = "";
            // 
            // Sign
            // 
            this.Sign.Location = new System.Drawing.Point(55, 277);
            this.Sign.Name = "Sign";
            this.Sign.Size = new System.Drawing.Size(103, 23);
            this.Sign.TabIndex = 7;
            this.Sign.Text = "Sign";
            this.Sign.UseVisualStyleBackColor = true;
            this.Sign.Click += new System.EventHandler(this.sign_Click);
            // 
            // verify
            // 
            this.verify.Location = new System.Drawing.Point(164, 277);
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
            this.ECDSAType.Location = new System.Drawing.Point(9, 40);
            this.ECDSAType.Name = "ECDSAType";
            this.ECDSAType.Size = new System.Drawing.Size(319, 21);
            this.ECDSAType.TabIndex = 9;
            this.ECDSAType.SelectedIndexChanged += new System.EventHandler(this.ECDSAType_SelectedIndexChanged);
            // 
            // signtype
            // 
            this.signtype.AutoSize = true;
            this.signtype.Location = new System.Drawing.Point(6, 24);
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
            this.button2.Location = new System.Drawing.Point(9, 78);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 193);
            this.button2.TabIndex = 15;
            this.button2.Text = "Generate Key Pair";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.GenerateKeyPair_Click);
            // 
            // privatekey
            // 
            this.privatekey.Location = new System.Drawing.Point(126, 94);
            this.privatekey.Name = "privatekey";
            this.privatekey.Size = new System.Drawing.Size(205, 79);
            this.privatekey.TabIndex = 16;
            this.privatekey.Text = "";
            // 
            // publickey
            // 
            this.publickey.Location = new System.Drawing.Point(123, 192);
            this.publickey.Name = "publickey";
            this.publickey.Size = new System.Drawing.Size(208, 79);
            this.publickey.TabIndex = 17;
            this.publickey.Text = "";
            // 
            // privatekey_label
            // 
            this.privatekey_label.AutoSize = true;
            this.privatekey_label.Location = new System.Drawing.Point(120, 78);
            this.privatekey_label.Name = "privatekey_label";
            this.privatekey_label.Size = new System.Drawing.Size(61, 13);
            this.privatekey_label.TabIndex = 18;
            this.privatekey_label.Text = "Private Key";
            // 
            // Publickey_label
            // 
            this.Publickey_label.AutoSize = true;
            this.Publickey_label.Location = new System.Drawing.Point(120, 176);
            this.Publickey_label.Name = "Publickey_label";
            this.Publickey_label.Size = new System.Drawing.Size(57, 13);
            this.Publickey_label.TabIndex = 19;
            this.Publickey_label.Text = "Public Key";
            // 
            // message
            // 
            this.message.Location = new System.Drawing.Point(16, 427);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(338, 135);
            this.message.TabIndex = 20;
            this.message.Text = "";
            // 
            // message_label
            // 
            this.message_label.AutoSize = true;
            this.message_label.Location = new System.Drawing.Point(13, 411);
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
            this.clear_btn.Location = new System.Drawing.Point(360, 9);
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.Size = new System.Drawing.Size(101, 23);
            this.clear_btn.TabIndex = 24;
            this.clear_btn.Text = "Clear";
            this.clear_btn.UseVisualStyleBackColor = true;
            this.clear_btn.Click += new System.EventHandler(this.clear_btn_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.ECDSAtab);
            this.tabControl1.Controls.Add(this.Elgamaltab);
            this.tabControl1.Controls.Add(this.MStab);
            this.tabControl1.Location = new System.Drawing.Point(12, 72);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(342, 332);
            this.tabControl1.TabIndex = 25;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // ECDSAtab
            // 
            this.ECDSAtab.Controls.Add(this.signtype);
            this.ECDSAtab.Controls.Add(this.ECDSAType);
            this.ECDSAtab.Controls.Add(this.button2);
            this.ECDSAtab.Controls.Add(this.privatekey_label);
            this.ECDSAtab.Controls.Add(this.privatekey);
            this.ECDSAtab.Controls.Add(this.Publickey_label);
            this.ECDSAtab.Controls.Add(this.publickey);
            this.ECDSAtab.Controls.Add(this.verify);
            this.ECDSAtab.Controls.Add(this.Sign);
            this.ECDSAtab.Location = new System.Drawing.Point(4, 22);
            this.ECDSAtab.Name = "ECDSAtab";
            this.ECDSAtab.Padding = new System.Windows.Forms.Padding(3);
            this.ECDSAtab.Size = new System.Drawing.Size(334, 306);
            this.ECDSAtab.TabIndex = 0;
            this.ECDSAtab.Text = "ECDSA";
            this.ECDSAtab.UseVisualStyleBackColor = true;
            // 
            // Elgamaltab
            // 
            this.Elgamaltab.Controls.Add(this.button3);
            this.Elgamaltab.Controls.Add(this.ElgamalEncryption);
            this.Elgamaltab.Controls.Add(this.BobButton);
            this.Elgamaltab.Controls.Add(this.label4);
            this.Elgamaltab.Controls.Add(this.ELgamalBobPrivateKey);
            this.Elgamaltab.Controls.Add(this.label5);
            this.Elgamaltab.Controls.Add(this.ElgammaBobPublicKey);
            this.Elgamaltab.Location = new System.Drawing.Point(4, 22);
            this.Elgamaltab.Name = "Elgamaltab";
            this.Elgamaltab.Padding = new System.Windows.Forms.Padding(3);
            this.Elgamaltab.Size = new System.Drawing.Size(334, 306);
            this.Elgamaltab.TabIndex = 1;
            this.Elgamaltab.Text = "ECElgamal";
            this.Elgamaltab.UseVisualStyleBackColor = true;
            // 
            // MStab
            // 
            this.MStab.Location = new System.Drawing.Point(4, 22);
            this.MStab.Name = "MStab";
            this.MStab.Size = new System.Drawing.Size(334, 306);
            this.MStab.TabIndex = 2;
            this.MStab.Text = "Massey-omura";
            this.MStab.UseVisualStyleBackColor = true;
            // 
            // BobButton
            // 
            this.BobButton.Location = new System.Drawing.Point(9, 6);
            this.BobButton.Name = "BobButton";
            this.BobButton.Size = new System.Drawing.Size(96, 98);
            this.BobButton.TabIndex = 20;
            this.BobButton.Text = "Generate Bob\'s Key Pair";
            this.BobButton.UseVisualStyleBackColor = true;
            this.BobButton.Click += new System.EventHandler(this.BobButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(141, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Private Key";
            // 
            // ELgamalBobPrivateKey
            // 
            this.ELgamalBobPrivateKey.Location = new System.Drawing.Point(144, 22);
            this.ELgamalBobPrivateKey.Name = "ELgamalBobPrivateKey";
            this.ELgamalBobPrivateKey.Size = new System.Drawing.Size(181, 40);
            this.ELgamalBobPrivateKey.TabIndex = 21;
            this.ELgamalBobPrivateKey.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(141, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Public Key";
            // 
            // ElgammaBobPublicKey
            // 
            this.ElgammaBobPublicKey.Location = new System.Drawing.Point(144, 81);
            this.ElgammaBobPublicKey.Name = "ElgammaBobPublicKey";
            this.ElgammaBobPublicKey.Size = new System.Drawing.Size(181, 40);
            this.ElgammaBobPublicKey.TabIndex = 22;
            this.ElgammaBobPublicKey.Text = "";
            // 
            // ElgamalEncryption
            // 
            this.ElgamalEncryption.Location = new System.Drawing.Point(63, 137);
            this.ElgamalEncryption.Name = "ElgamalEncryption";
            this.ElgamalEncryption.Size = new System.Drawing.Size(75, 23);
            this.ElgamalEncryption.TabIndex = 25;
            this.ElgamalEncryption.Text = "Encrypt";
            this.ElgamalEncryption.UseVisualStyleBackColor = true;
            this.ElgamalEncryption.Click += new System.EventHandler(this.ElgamalEncryption_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(144, 137);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 26;
            this.button3.Text = "Decrypt";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.decrypt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 574);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.clear_btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.message_label);
            this.Controls.Add(this.message);
            this.Controls.Add(this.namedCurves);
            this.Controls.Add(this.ECbit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.output);
            this.Name = "Form1";
            this.Text = "s";
            this.tabControl1.ResumeLayout(false);
            this.ECDSAtab.ResumeLayout(false);
            this.ECDSAtab.PerformLayout();
            this.Elgamaltab.ResumeLayout(false);
            this.Elgamaltab.PerformLayout();
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
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage ECDSAtab;
        private System.Windows.Forms.TabPage Elgamaltab;
        private System.Windows.Forms.TabPage MStab;
        private System.Windows.Forms.Button BobButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox ELgamalBobPrivateKey;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox ElgammaBobPublicKey;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button ElgamalEncryption;
    }
}

