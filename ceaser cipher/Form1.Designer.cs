namespace ceaser_cipher
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.TextBox txtShift;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label lblEnterMessage;
        private System.Windows.Forms.Label lblEnterShift;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            txtInput = new System.Windows.Forms.TextBox();
            txtShift = new System.Windows.Forms.TextBox();
            btnEncrypt = new System.Windows.Forms.Button();
            txtResult = new System.Windows.Forms.TextBox();
            lblEnterMessage = new System.Windows.Forms.Label();
            lblEnterShift = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // txtInput
            // 
            txtInput.Location = new System.Drawing.Point(253, 47);
            txtInput.Name = "txtInput";
            txtInput.Size = new System.Drawing.Size(132, 23);
            txtInput.TabIndex = 0;
            txtInput.Text = "rgsrd";
            // 
            // txtShift
            // 
            txtShift.Location = new System.Drawing.Point(253, 81);
            txtShift.Name = "txtShift";
            txtShift.Size = new System.Drawing.Size(132, 23);
            txtShift.TabIndex = 1;
            txtShift.Text = "33";
            // 
            // btnEncrypt
            // 
            btnEncrypt.Location = new System.Drawing.Point(234, 137);
            btnEncrypt.Name = "btnEncrypt";
            btnEncrypt.Size = new System.Drawing.Size(70, 28);
            btnEncrypt.TabIndex = 2;
            btnEncrypt.Text = "Encrypt";
            btnEncrypt.UseVisualStyleBackColor = true;
            btnEncrypt.Click += btnEncrypt_Click;
            // 
            // txtResult
            // 
            txtResult.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            txtResult.Location = new System.Drawing.Point(253, 202);
            txtResult.Name = "txtResult";
            txtResult.ReadOnly = true;
            txtResult.Size = new System.Drawing.Size(132, 23);
            txtResult.TabIndex = 3;
            txtResult.Text = "encrypted";
            // 
            // lblEnterMessage
            // 
            lblEnterMessage.AutoSize = true;
            lblEnterMessage.Location = new System.Drawing.Point(169, 50);
            lblEnterMessage.Name = "lblEnterMessage";
            lblEnterMessage.Size = new System.Drawing.Size(60, 15);
            lblEnterMessage.TabIndex = 4;
            lblEnterMessage.Text = "Plain Text:";
            // 
            // lblEnterShift
            // 
            lblEnterShift.AutoSize = true;
            lblEnterShift.Location = new System.Drawing.Point(169, 89);
            lblEnterShift.Name = "lblEnterShift";
            lblEnterShift.Size = new System.Drawing.Size(29, 15);
            lblEnterShift.TabIndex = 5;
            lblEnterShift.Text = "Key:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(126, 205);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(112, 15);
            label1.TabIndex = 6;
            label1.Text = "Encrypted message:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.ActiveBorder;
            ClientSize = new System.Drawing.Size(596, 397);
            Controls.Add(label1);
            Controls.Add(lblEnterShift);
            Controls.Add(lblEnterMessage);
            Controls.Add(txtResult);
            Controls.Add(btnEncrypt);
            Controls.Add(txtShift);
            Controls.Add(txtInput);
            Name = "Form1";
            Text = "Caesar Cipher";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label label1;
    }
}
