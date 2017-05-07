using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ch_4_in_class {

    // Namespace declarations

    public partial class MainForm : Form {

        // Comments
        private int numCust = 0;
        private double totalAmnt = 0;

        // reset after each customer
        private string ordSummary = string.Empty;
        private double currCustTotal = 0d;

        //Reset after each line item and customer.
        private double itemCost = 0d;



        // Constants
        private const double BdCost = 5d;
        private const double DvdCost = 4.5d;
        private const double newRelease = 1d;
        private const double MbrDisc = 0.9d;

        public MainForm() {

            InitializeComponent();
        }
        //Close Application
        private void ExitButton_Click(object sender, EventArgs e) {

            this.Close();

        }//end Close

        //Reset Current Order
        private void ClearButton_Click(object sender, EventArgs e) {
            
            NewCheckBox.Checked = false;            
            BDRadioButton.Checked = false;
            DVDRadioButton.Checked = false;
            MsgTextBox.Clear();

            itemCost = 0d;

            //resetting controls
            CalcButton.Enabled = true;
            ClearButton.Enabled = false;
            FormatGroupBox.Enabled = true;
            MsgTextBox.Clear();
            movieTextBox.Clear();
            NewCheckBox.Enabled = true;
            movieTextBox.Focus();
            

        }//End Reset

        private void CalcButton_Click(object sender, EventArgs e) {

            //Check for user input of name and dvd selection
            if (NameTextBox.Text != "" && itemCost != 0) {  // || or, && and, == equals, != not equal,  <less, >greater, <= less equal, >= greater equal,

                if (NewCheckBox.Checked)
                    itemCost += newRelease; // itemCost = itemCost + newRelease

                if (MemberCheckBox.Checked)
                    itemCost *= MbrDisc;   // itemCost = itemCost * mbrDisc

                ordSummary += itemCost.ToString("C") + Environment.NewLine; // itemCost.ToString("C") + "\r\n"; for the other option of newline in string
                currCustTotal += itemCost;

                MsgTextBox.Text = ordSummary + "\r\n\t\t Total for Order: " + currCustTotal.ToString("C");

                //set form item controls for an order - reset after order.
                CalcButton.Enabled = false;
                NewCheckBox.Enabled = false;
                

                ClearButton.Enabled = true;               
                OCButton.Enabled = true;
                SummaryButton.Visible = true;


                //Current user form controls
                NameTextBox.Enabled = false;
                MemberCheckBox.Enabled = false;
                OCButton.Visible = true;


                


            }
            else {
                MessageBox.Show("Please select a dvd and type name", "Hello", MessageBoxButtons.OK);

            }
        }

        /*
         *  if(name){
         *      if(movie){
         *          
         *          }else { 
         *          name msg
         *       }else{
         *          movie msg
         *          
         *          
         * 
         */

            private void RadioButtons_CheckedChanged(object sender, EventArgs e) {

            RadioButton formatRadios = (RadioButton)sender;

            switch (formatRadios.Name) {

                case "BDRadioButton":
                    itemCost = BdCost;
                    if (movieTextBox.Text != "") {
                        ordSummary += movieTextBox.Text;
                    } else {
                        ordSummary += "Blue Ray Disc: ";
                    }
                    break;

                case "DVDRadioButton":
                    itemCost = DvdCost;
                    if (movieTextBox.Text != "") {

                        ordSummary += movieTextBox.Text;
                    } else { 

                        ordSummary += "Standard Disc: ";

                    }

                    break;

                    

            }

            
            

        }

        private void OCButton_Click(object sender, EventArgs e)  {

            

            //Add order total to daaily total
            numCust+=1; //numCust++;
            totalAmnt += currCustTotal;

            //reset currCustTotal order dat
            currCustTotal = 0d;
            ordSummary = "";

            //reset form to start condition for new order
            ClearButton_Click(sender, e);

            //reset remainder of form controls for new customer
            MemberCheckBox.Checked = false;
            MemberCheckBox.Enabled = true;
            NameTextBox.Clear();
            NameTextBox.Enabled = true;
            OCButton.Enabled = false;
            SummaryButton.Visible = true;
            CalcButton.Enabled = false;

        }

        private void SummaryButton_Click(object sender, EventArgs e) {

            MsgTextBox.Text = "Totals for the day: \r\n\t\t " + "Number of Customers: " + 
                numCust.ToString("N") + "\r\n\t\tTotals Sales: " + totalAmnt.ToString("C");

        }
    }
}
