using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitnessTracker2._0
{
    public partial class CreateAcnt : Form
    {
        public static string username = "";
        public static string password = "";
        static bool ValidatePassword(string passWord)
        {
            int validConditions = 0;
            foreach (char c in passWord)
            {
                if (c >= 'a' && c <= 'z')
                {
                    validConditions++;
                    break;
                }
            }
            foreach (char c in passWord)
            {
                if (c >= 'A' && c <= 'Z')
                {
                    validConditions++;
                    break;
                }
            }
            if (validConditions == 0 || validConditions == 1) return false;
            foreach (char c in passWord)
            {
                if (c >= '0' && c <= '9')
                {
                    validConditions++;
                    break;
                }
            }
            if (validConditions == 2) return false;
            if (validConditions == 3)
            {
                char[] special = { '@', '#', '$', '%', '^', '&', '+', '=' }; // or whatever
                if (passWord.IndexOfAny(special) == -1) return false;
            }
            return true;
        }
        public CreateAcnt()
        {
            InitializeComponent();
        }

        private void CreateAccnt_Click1(object sender, EventArgs e)
        {
            Console.WriteLine(ValidatePassword(pwd.Text).ToString());
            if (userName.Text == "")
                MessageBox.Show("Please do enter user name it is mandatory!", "Validation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            else if (pwd.Text == "")
                MessageBox.Show("Password Mandatory!", "Password Validation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            else if (pwd.Text.Length < 6)
                MessageBox.Show("Minimum 6 characters required", "Password Validation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            else if (!ValidatePassword(pwd.Text))
                MessageBox.Show("Check the criteria for password; Minimum 1 special character, number and Uppercase alphabet", "Password Validatation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (newPwd.Text != pwd.Text)
                MessageBox.Show("Re enter password carefully!");
            else
            {
                
                MessageBox.Show("Please enter all essential details now in Profile section !!","Fill up details now or later",MessageBoxButtons.OK,MessageBoxIcon.Information);

                username = userName.Text;
                password = pwd.Text;
                Program.userName = username;

                

            }


        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
