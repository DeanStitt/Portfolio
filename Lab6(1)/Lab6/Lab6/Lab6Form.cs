// Lab 6
// CIS 199-xx
// Due: 10/27/2019
// By: Andrew L. Wright (Students use Grading ID)

// This application explores the use of parallel arrays and
// range matching. The app calculates a typing student's
// grade in a course based on their achieved words per minute.

using System;
using System.Windows.Forms;

namespace Lab6
{
    public partial class Lab6Form : Form
    {
        public Lab6Form()
        {
            InitializeComponent();
        }

        // Calculates and displayed grade earned using parallel
        // arrays and range matching
        private void CalcButton_Click(object sender, EventArgs e)
        {
            int wordsPerMinute; // Student's WPM score
            string grade = "F"; // Student's grade
            bool found = false; // Found match yet?
            int index;          // Array index for search
            
            // Parallel arrays for range matching
            int[] wpmLowerLimits = { 0, 16, 31, 51, 76 };  // Lower limits of WPM ranges
            string[] grades = { "F", "D", "C", "B", "A" }; // Possible grades

            if (int.TryParse(wpmTxt.Text, out wordsPerMinute) && wordsPerMinute >= 0)
            {
                index = wpmLowerLimits.Length - 1; // Start from end of array
                while (index >= 0 && !found)
                {
                    if (wordsPerMinute >= wpmLowerLimits[index]) // Found it!
                        found = true;
                    else
                        --index;
                }

                if (found)
                    grade = grades[index];

                gradeOutputLbl.Text = grade; // Send output to label
            }
            else // Invalid input
            {
                MessageBox.Show("Invalid input! Try again!");
            }
        }
    }
}
