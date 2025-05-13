using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace ListTest
{

    public partial class Form1 : Form
    {
        //a string list to hold student names
        List<string> studentNames = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            studentNames.Add(inputBox.Text);
            inputBox.Text = "";
        }

        private void displayButton_Click(object sender, EventArgs e)
        {
            originalOutput.Text = $"Original ------\n\n";

            for (int i = 0; i < studentNames.Count; i++)
            {
                originalOutput.Text += studentNames[i] + "\n";
            }

            sortOutput.Text = $"Sorted ------\n\n";

            studentNames.Sort();

            for (int i = 0; i < studentNames.Count; i++)
            {
                sortOutput.Text += studentNames[i] + "\n";
            }

            reverseOutput.Text = $"Reverse -----\n\n";

            studentNames.Reverse();

            for (int i = 0; i < studentNames.Count; i++)
            {
                reverseOutput.Text += studentNames[i] + "\n";
            }

        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            string toRemove = inputBox.Text;

            if (studentNames.Contains(toRemove))
            {
                studentNames.Remove(toRemove);
                inputBox.Text = "";
                originalOutput.Text = "value removed";
                sortOutput.Text = "";
                reverseOutput.Text = "";
            }
            else
            {
                inputBox.Text = "";
                originalOutput.Text = "value not present";
                sortOutput.Text = "";
                reverseOutput.Text = "";
            }

        }
    }
}
