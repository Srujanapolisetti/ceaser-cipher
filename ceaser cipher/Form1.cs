using System;
using System.Windows.Forms;

namespace ceaser_cipher
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
                txtResult.Text = cipherText;  // Display result in TextBox
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
    }
}
