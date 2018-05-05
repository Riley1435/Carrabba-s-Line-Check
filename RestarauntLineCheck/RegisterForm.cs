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
   public partial class RegisterForm : Form
   {
      public RegisterForm()
      {
         InitializeComponent();
      }

      //Encrypts username and password and logs it into a directory.
      //checks if directory exists before creation to ensure no
      //duplicate users are created
      private void buttonRegister_Click(object sender, EventArgs e)
      {
         if (textBoxUsername.Text.Length < 3 || textBoxPassword.Text.Length < 6)
         {
            MessageBox.Show("Username of Passowrd is too short, please enter a username greater than 3 characters and a password greater than 6");
            textBoxUsername.Text = "";
            textBoxPassword.Text = "";
         }
         else
         {
            string dUser = textBoxUsername.Text;
            if (Directory.Exists("data\\" + dUser))
            {
               MessageBox.Show("This username already exists, please try a different username.");
               textBoxUsername.Text = "";
               textBoxPassword.Text = "";
            }
            else
            {
               Directory.CreateDirectory("data\\" + dUser);

               var sw = new StreamWriter("Data\\" + dUser + "\\data.ls");

               string encryptUsername = AesCryptography.Encrypt(textBoxUsername.Text);
               string encryptPassword = AesCryptography.Encrypt(textBoxPassword.Text);

               sw.WriteLine(encryptUsername);
               sw.WriteLine(encryptPassword);
               sw.Close();

               MessageBox.Show("Account successfully created, please save your username and password somewhere safe");
               this.Close();
            }
         }
      }

      private void textBoxUsername_TextChanged(object sender, EventArgs e)
      {

      }

      private void buttonBack_Click(object sender, EventArgs e)
      {
         this.Close();
      }

      private void buttonExit_Click(object sender, EventArgs e)
      {
         Application.Exit();
      }

      private void pictureBox1_Click(object sender, EventArgs e)
      {

      }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
