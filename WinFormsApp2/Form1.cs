using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            try
            {
                string plainText = txtInput.Text;
                int shiftKey = int.Parse(txtShift.Text);

                string cipherText = Encrypt(plainText, shiftKey);
                lblResult.Text = "Encrypted: " + cipherText;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            try
            {
                string cipherText = txtInput.Text;
                int shiftKey = int.Parse(txtShift.Text);

                string plainText = Decrypt(cipherText, shiftKey);
                lblResult.Text = "Decrypted: " + plainText;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private string Encrypt(string input, int shift)
        {
            string result = string.Empty;

            foreach (char c in input)
            {
                if (char.IsLetter(c))
                {
                    char offset = char.IsUpper(c) ? 'A' : 'a';
                    result += (char)(((c + shift - offset) % 26) + offset);
                }
                else
                {
                    result += c; // Keep non-letter characters unchanged
                }
            }

            return result;
        }
        private string Decrypt(string input, int shift)
        {
            return Encrypt(input, 26 - shift); // Decryption is just shifting back
        }
    }
}
