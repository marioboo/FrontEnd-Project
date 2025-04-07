/*using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FrontEnd_Project
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void fullName_TextChanged(object sender, EventArgs e)
        {
            // Temporarily remove event handler to prevent infinite recursion
            fullName.TextChanged -= fullName_TextChanged;

            string fullNameText = fullName.Text; // Get the current text
            string validText = Regex.Replace(fullNameText, "[^a-zA-Z ]", ""); // Remove invalid characters (anything except letters and spaces)

            if (fullNameText != validText) // If invalid characters exist
            {
                MessageBox.Show("Full name must only contain letters and spaces.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                fullName.Text = validText; // Update text without special characters or numbers
                fullName.SelectionStart = fullName.Text.Length; // Keep cursor position at the end
            }

            // Reattach event handler after modifying text
            fullName.TextChanged += fullName_TextChanged;
        }

        private void agE_TextChanged(object sender, EventArgs e)
        {
            // Temporarily remove event handler to prevent infinite recursion
            agE.TextChanged -= agE_TextChanged;

            string ageText = agE.Text; // Get the current text
            string validText = Regex.Replace(ageText, "[^0-9]", ""); // Remove any character that is not a digit

            if (ageText != validText) // If invalid characters exist
            {
                MessageBox.Show("Age must only contain numbers.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                agE.Text = validText; // Update text with only numbers
                agE.SelectionStart = agE.Text.Length; // Keep cursor position at the end
            }

            // Reattach event handler after modifying text
            agE.TextChanged += agE_TextChanged;

        }

        private void birthDay_ValueChanged(object sender, EventArgs e)
        {
            ValidateAgeWithBirthday(); // Call the validation method whenever the birthday is changed
        }
    }
}*/
/*using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrontEnd_Project
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void fullName_TextChanged(object sender, EventArgs e)
        {
            // Temporarily remove event handler to prevent infinite recursion
            fullName.TextChanged -= fullName_TextChanged;

            string fullNameText = fullName.Text; // Get the current text
            string validText = Regex.Replace(fullNameText, "[^a-zA-Z ]", ""); // Remove invalid characters (anything except letters and spaces)

            if (fullNameText != validText) // If invalid characters exist
            {
                MessageBox.Show("Full name must only contain letters and spaces.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                fullName.Text = validText; // Update text without special characters or numbers
                fullName.SelectionStart = fullName.Text.Length; // Keep cursor position at the end
            }

            // Reattach event handler after modifying text
            fullName.TextChanged += fullName_TextChanged;
        }

        // Age text box validation
        private void agE_TextChanged(object sender, EventArgs e)
        {
            string age = agE.Text;
            if (!Regex.IsMatch(age, "^[0-9]*$")) // Only allow numbers
            {
                MessageBox.Show("Age must only contain numbers.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                // Remove last invalid character
                if (age.Length > 0)
                {
                    agE.Text = age.Substring(0, age.Length - 1);
                    agE.SelectionStart = agE.Text.Length;
                }
            }

            // Validate age with birthday
            ValidateAgeWithBirthday();
        }

        // Birthday validation with age
        private void birthDay_ValueChanged(object sender, EventArgs e)
        {
            ValidateAgeWithBirthday();
        }

        // Validating age based on the birthday
        private void ValidateAgeWithBirthday()
        {
            if (DateTime.TryParse(birthDay.Text, out DateTime selectedBirthday))
            {
                DateTime currentDate = DateTime.Now;

                int age = currentDate.Year - selectedBirthday.Year;
                if (selectedBirthday > currentDate.AddYears(-age)) age--; // Adjust if birthday hasn't passed yet this year

                // If the calculated age doesn't match the entered age, show a warning
                if (agE.Text != age.ToString())
                {
                    MessageBox.Show("The entered age does not match the birthday.", "Age and Birthday Mismatch", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}*/

using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace FrontEnd_Project
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void fullName_TextChanged(object sender, EventArgs e)
        {
            // Temporarily remove event handler to prevent infinite recursion
            fullName.TextChanged -= fullName_TextChanged;

            string fullNameText = fullName.Text; // Get the current text
            string validText = Regex.Replace(fullNameText, "[^a-zA-Z ]", ""); // Remove invalid characters (anything except letters and spaces)

            if (fullNameText != validText) // If invalid characters exist
            {
                MessageBox.Show("Full name must only contain letters and spaces.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                fullName.Text = validText; // Update text without special characters or numbers
                fullName.SelectionStart = fullName.Text.Length; // Keep cursor position at the end
            }

            // Reattach event handler after modifying text
            fullName.TextChanged += fullName_TextChanged;
        }
        // Age text box validation
        private void agE_TextChanged(object sender, EventArgs e)
        {
            string age = agE.Text;
            if (!Regex.IsMatch(age, "^[0-9]*$")) // Only allow numbers
            {
                MessageBox.Show("Age must only contain numbers.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                // Remove last invalid character
                if (age.Length > 0)
                {
                    agE.Text = age.Substring(0, age.Length - 1);
                    agE.SelectionStart = agE.Text.Length;
                }
            }

            // Validate age with birthday only when both are filled
            ValidateAgeWithBirthday();
        }

        // Birthday validation with age
        private void birthDay_ValueChanged(object sender, EventArgs e)
        {
            // Validate only when both age and birthday fields are filled
            ValidateAgeWithBirthday();
        }

        // Validating age based on the birthday
        private void ValidateAgeWithBirthday()
        {
            if (string.IsNullOrEmpty(agE.Text) || birthDay.Value == null)
                return; // Don't validate if age or birthday is empty

            if (DateTime.TryParse(birthDay.Text, out DateTime selectedBirthday))
            {
                DateTime currentDate = DateTime.Now;

                int age = currentDate.Year - selectedBirthday.Year;
                if (selectedBirthday > currentDate.AddYears(-age)) age--; // Adjust if birthday hasn't passed yet this year

                // If the calculated age doesn't match the entered age, show a warning
                if (agE.Text != age.ToString())
                {
                    MessageBox.Show("The entered age does not match the birthday.", "Age and Birthday Mismatch", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        // Full name validation (letters and spaces only)
        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            // Temporarily remove event handler to prevent infinite recursion
            fullName.TextChanged -= TextBox_TextChanged;

            string fullNameText = fullName.Text;
            string validText = Regex.Replace(fullNameText, "[^a-zA-Z ]", ""); // Remove invalid characters (anything except letters and spaces)

            if (fullNameText != validText) // If invalid characters exist
            {
                MessageBox.Show("Full name must only contain letters and spaces.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                fullName.Text = validText; // Update text without special characters or numbers
                fullName.SelectionStart = fullName.Text.Length; // Keep cursor position at the end
            }

            // Reattach event handler after modifying text
            fullName.TextChanged += TextBox_TextChanged;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}