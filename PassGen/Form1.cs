using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace PassGen
{
    public partial class Form1 : Form
    {
        //We don't want these characters, they are excluded
        public char[] lstExclude = new char[] { 'o', '0', 'O', 'i', 'l' };
        //Array of numbers
        public char[] lstNumbers = "0123456789".ToCharArray();
        //Array of lower case characters
        public char[] lstLowerCase = Enumerable.Range('a', 'z' - 'a' + 1).Select(i => (Char)i).ToArray();
        //Array of upper case characters
        public char[] lstUpperCase = Enumerable.Range('A', 'Z' - 'A' + 1).Select(i => (Char)i).ToArray();
        //Array of special characters
        public char[] lstSymbols = @"`-=~!@#$%^&*()_+{[}]|\\""':;<,>.?/".ToCharArray();
        //This is the password array
        List<char> lstPassword = new List<char>(new char[] { });
        //Initialize the random generator
        public Random intRandom = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            //This is going to be our password at the end
            string strPassword;
            //And it's length
            int intPassLen;
            //A temp counter
            int intCounter = 0;
            //Minimum length of our password
            int intMin = Convert.ToInt32(nMin.Value);
            //Maximum length of our password
            int intMax = Convert.ToInt32(nMax.Value);
            //The difference
            int intDiff = intMin - intMax;
            //If there is no difference between the max/min lenght
            //Then we have a static length of the password           
            if (intDiff == 0)
            {
                intPassLen = intMax;
            }  else
            {
                //If not, we'll have to generate a random length (min/max)
                intPassLen = intRandom.Next(intMin, intMax + 1);
            }
            do
            {
                //Get a random character
                char chLetter = (char)intRandom.Next(33, 127);
                //Check the conditions (uppercase/lowercase, exclusions, numerals, symbols
                if (!((lstExclude.Contains(chLetter)) ||
                    ((lstLowerCase.Contains(chLetter) && !cbLowercase.Checked)) ||
                    ((lstUpperCase.Contains(chLetter) && !cbUppercase.Checked)) ||
                    ((lstNumbers.Contains(chLetter) && !cbNumbers.Checked)) ||
                    ((lstSymbols.Contains(chLetter) && !cbSymbols.Checked))))
                {
                    //If all conditions are met, add the character to the array
                    lstPassword.Add(chLetter);
                    intCounter++;                    
                }
            // Loop until you reach the desired password length
            } while (intCounter < intPassLen);
            //Convert the array of characters to a string
            strPassword = string.Join("", lstPassword.ToArray());
            //Clear the password char array so it doesn't add up
            lstPassword.Clear();            
            //Update the texbox on the screen
            tbPassword.Text = strPassword;
            //Update the length label on the screen
            lblLength.Text = "Length:" + strPassword.Length.ToString();
        }

        private void nMin_ValueChanged(object sender, EventArgs e)
        {
            //Don't allow the min value to be bigger than the max value
            if (nMin.Value > nMax.Value) nMin.Value = nMax.Value; 
        }

        private void txtExclude_TextChanged(object sender, EventArgs e)
        {
            //Add the excluded character from the text box to the exclusion array
            lstExclude = txtExclude.Text.ToCharArray();
        }
    }
}
