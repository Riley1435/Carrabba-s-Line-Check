using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AesEncDec;
using System.IO;

namespace RestarauntLineCheck
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            RegisterForm regForm = new RegisterForm();
            regForm.Show();
        }
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (textBoxUsername.Text.Length < 3 || textBoxPassword.Text.Length < 6)
            {
                MessageBox.Show("Username of Passowrd is invalid, Username must be longer than 3 and password longer than 6.");
            }
            else
            {

                ///
                ///LINEAR SEARCH REQUIREMENT FOR SCHOOL.
                ///

                string dUser = textBoxUsername.Text;
                string[] files = GetFileNames();
                if (!FileLinearSearch(files, dUser))
                {
                    MessageBox.Show("User not found", dUser);
                }
                ///
                ///
                ///
                else
                {
                    var sr = new StreamReader("data\\" + dUser + "\\data.ls");

                    string encryptUsername = sr.ReadLine();
                    string encryptPassword = sr.ReadLine();
                    sr.Close();

                    string decryptUsername = AesCryptography.Decrypt(encryptUsername);
                    string decryptPassword = AesCryptography.Decrypt(encryptPassword);

                    if (decryptUsername == textBoxUsername.Text && decryptPassword == textBoxPassword.Text)
                    {
                        MessageBox.Show($"You are now loggin in as: " + textBoxUsername.Text);
                        FormMain formMain = new FormMain(textBoxUsername.Text);
                        this.Hide();
                        formMain.Show();
                    }
                    else
                    {
                        MessageBox.Show("Username or Password is incorrect");
                    }
                }
            }
        }
        private string[] GetFileNames()
        {
            List<string> directNames = new List<string>();
            foreach (var file in System.IO.Directory.GetDirectories(@"data\\"))
            {
                directNames.Add(file.Remove(0, 6));
            }
            string[] names = directNames.ToArray();
            return names;
        }
        private bool FileLinearSearch(string[] arr, string search)
        {
            int count = 0;
            while (count < arr.Length)
            {
                if (search == arr[count])
                {
                    return true;
                }
                else
                {
                    count++;
                }
            }
            return false;
        }
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
