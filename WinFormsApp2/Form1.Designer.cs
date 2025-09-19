namespace WinFormsApp2
{
    partial class Form1 { 
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.TextBox txtShift;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.Label lblResult;
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
            this.txtInput = new System.Windows.Forms.TextBox();
            this.txtShift = new System.Windows.Forms.TextBox();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblEnterMessage = new System.Windows.Forms.Label();
            this.lblEnterShift = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(130, 50);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(150, 22);
            this.txtInput.TabIndex = 0;

            // 
            // txtShift
            // 
            this.txtShift.Location = new System.Drawing.Point(130, 90);
            this.txtShift.Name = "txtShift";
            this.txtShift.Size = new System.Drawing.Size(50, 22);
            this.txtShift.TabIndex = 1;

            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(60, 140);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(80, 30);
            this.btnEncrypt.TabIndex = 2;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);

            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Location = new System.Drawing.Point(160, 140);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(80, 30);
            this.btnDecrypt.TabIndex = 3;
            this.btnDecrypt.Text = "Decrypt";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);

            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(60, 190);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(50, 17);
            this.lblResult.TabIndex = 4;
            this.lblResult.Text = "Result:";

            // 
            // lblEnterMessage
            // 
            this.lblEnterMessage.AutoSize = true;
            this.lblEnterMessage.Location = new System.Drawing.Point(60, 50);
            this.lblEnterMessage.Name = "lblEnterMessage";
            this.lblEnterMessage.Size = new System.Drawing.Size(60, 17);
            this.lblEnterMessage.TabIndex = 5;
            this.lblEnterMessage.Text = "Message:";

            // 
            // lblEnterShift
            // 
            this.lblEnterShift.AutoSize = true;
            this.lblEnterShift.Location = new System.Drawing.Point(60, 90);
            this.lblEnterShift.Name = "lblEnterShift";
            this.lblEnterShift.Size = new System.Drawing.Size(70, 17);
            this.lblEnterShift.TabIndex = 6;
            this.lblEnterShift.Text = "Shift Key:";

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 250);
            this.Controls.Add(this.lblEnterShift);
            this.Controls.Add(this.lblEnterMessage);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.txtShift);
            this.Controls.Add(this.txtInput);
            this.Name = "Form1";
            this.Text = "Caesar Cipher";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}