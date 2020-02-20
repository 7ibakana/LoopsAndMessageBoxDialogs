using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoopsAndMessageBoxDialogs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnWhile_Click(object sender, EventArgs e)
        {
            /*Gives a dialog box that initiates a while loop based on the response of the user and 
            then starts executing the the Messagebox's based on the users selection of the Dialog Result*/
            DialogResult selected = MessageBox.Show("Do you want to see some MessageBox dialogs?", "While", MessageBoxButtons.YesNo); 

            while (selected == DialogResult.Yes)
            {
                selected = MessageBox.Show("Here's a MessageBox. Do you want another?", "While", MessageBoxButtons.YesNo);
            }
        }

        private void btnDoWhile_Click(object sender, EventArgs e)
        {
            DialogResult selected; /*The dialogResult for a future act is selected to Yes 
            then it prompts the MessageBox to ask which MessageButton you want to select and repeats based on user selection*/

            do
            {
                selected = MessageBox.Show("Do you want another MessageBox?", "Do While", MessageBoxButtons.YesNo);
            } while (selected == DialogResult.Yes);
        }

        private void btnFor_Click(object sender, EventArgs e)
        {
            int numbers = Convert.ToInt32(txtM.Text); //takes the txtM input and converts it into an int variable
            if (numbers > 0) //if the numbers entered greater than 0
                for (int m = 1; m <= numbers; m++) /*for every number we would initialize the for loop to start at 1, 
                    boolean expression executes every time until its equal to the number entered and its done with the increment expression addint to 1*/
                {

                    MessageBox.Show("Here's MessageBox " + m);
                }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
