using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewDrawingApp
{
    public partial class Form1 : Form
    {
        int currentPasswordLength = 0;
        Random character = new Random();

        private void passwordGenerator(int passwordLength)
        {
            string allCharacters = "123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            string randomPassword = "";

            for (int i = 0; i < passwordLength; i++)
            {
                int randomNum = character.Next(0, allCharacters.Length);
                randomPassword += allCharacters[randomNum];
            }
            PasswordLabel.Text = randomPassword;
        }

        public Form1()
        {
            InitializeComponent();
            PasswordLengthSlider.Minimum = 5;
            PasswordLengthSlider.Maximum = 20;
            passwordGenerator(5);
        }

        private void CopyPasswordButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(PasswordLabel.Text);
        }

        private void PasswordLengthSlider_Scroll(object sender, EventArgs e)
        {
            PassLengthLabel.Text = "Password Length: " + PasswordLengthSlider.Value.ToString();
            currentPasswordLength = PasswordLengthSlider.Value;
            passwordGenerator(currentPasswordLength);
        }
    }
}