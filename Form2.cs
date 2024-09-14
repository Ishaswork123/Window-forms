using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace scientific_calculator
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void click_Click(object sender, EventArgs e)
        {
            string inputText = logical.Text;

            // Define the regular expression for logical operators
            string pattern = @"(\&\&|\|\||\!|\bAND\b|\bOR\b|\bNOT\b)";

            // Find all matches of logical operators in the input text
            MatchCollection matches = Regex.Matches(inputText, pattern, RegexOptions.IgnoreCase);

            // Clear the output RichTextBox
            output1.Clear();

            // Loop through the matches and display them in richTextBox2
            foreach (Match match in matches)
            {
                output1.AppendText($"Found logical operator: {match.Value}\n");
            }

            // If no matches found, display a message
            if (matches.Count == 0)
            {
                output1.Text = "No logical operators found.";
            }
        }



        private void logical_TextChanged(object sender, EventArgs e)
        {

        }

        private void output1_TextChanged(object sender, EventArgs e)
        {

        }

        private void submit_Click(object sender, EventArgs e)
        {
            string inputText = relational.Text;

            // Define the regular expression for relational operators
            string pattern = @"(==|!=|>=|<=|>|<)";

            // Find all matches of relational operators in the input text
            MatchCollection matches = Regex.Matches(inputText, pattern);

            // Clear the output RichTextBox
            output2.Clear();

            // Loop through the matches and display them in richTextBox2
            foreach (Match match in matches)
            {
                output2.AppendText($"Found relational operator: {match.Value}\n");
            }

            // If no matches found, display a message
            if (matches.Count == 0)
            {
                output2.Text = "No relational operators found.";
            }
        }
    }
}
 
