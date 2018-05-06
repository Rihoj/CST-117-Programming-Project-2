using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CST_117_Programming_Exercise
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            var checked_texts = this.Controls.OfType<CheckBox>()
                                        .Where(c => c.Checked)
                                        .OrderBy(c => c.Text)
                                        .Select(c => c.Text);

            var positions = String.Join(", ", checked_texts);
            String title = (maleRadioButton.Checked) ? "Mr. " : (femaleRadioButton.Checked) ? "Ms." : "Mr/Ms.";
            MessageBox.Show("Thank you for your application "+title+" "+ nameTextBox.Text + " of "+raceListBox.Text+", we will review the positions your applied for (" + positions + ")", "Thank you");
        }
    }
}
