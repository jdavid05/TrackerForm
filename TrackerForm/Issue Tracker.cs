/*Purpose: Create an issue tracking form
 * Author: Joe Davidson
 * Date  : February 2016
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IssueTracker;

namespace TrackerForm
{

    public partial class frmIssueTracker : Form
    {
        #region Fields
        Tracker tracker;
        private bool nonNumberEntered = false;
        private int issueType;
        private int integerX, integerY;
        # endregion

        #region Initializers
        public frmIssueTracker()
        {
            InitializeComponent();
            this.btnUnknown.Checked = true;
            txtCoordinateX.KeyPress += new KeyPressEventHandler(keypressed);
            issueType = 0;   
        }
        #endregion

        #region Button Submit
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // Try to convert the x-coordinate string to an integer.
            bool resultX = int.TryParse(txtCoordinateX.Text, out integerX);
            // If the conversion fails:
            if (resultX == false)
            {
                // Set the x-coordinate to 0.
                integerX = 0;
            }
            // Try to convert the y-coordinate string to an integer.
            bool resultY = int.TryParse(txtCoordinateY.Text, out integerY);
            // If the conversion fails:
            if (resultY == false)
            {
                // Set the y-coordinate to 0.
                integerY = 0;
            }

            tracker = new Tracker(integerX, integerY, txtFirstName.Text,
                txtLastName.Text, Convert.ToDateTime(dtpIssueDate.Text),
                issueType, txtIssueDescription.Text);

            txtResults.Text += tracker.GetIssueDetails(true) + "\r\n\r\n";

            lblIdNumber.Text = tracker.IssueID.ToString("D3");
        }
        #endregion

        #region Button Cancel
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Radio Buttons
        private void rbnFacility_CheckedChanged(object sender, EventArgs e)
        {
            // If the Facility radio button is checked:
            if (btnFacility.Checked)
                // The issue type will be first character of the text.
                issueType = byte.Parse(btnFacility.Text.Substring(0, 1));
        }

        private void rbnSignage_CheckedChanged(object sender, EventArgs e)
        {
            // If the Signage radio button is checked:
            if (btnSignage.Checked)
                // The issue type will be first character of the text.
                issueType = byte.Parse(btnSignage.Text.Substring(0, 1));
        }

        private void rbnRoad_CheckedChanged(object sender, EventArgs e)
        {
            // If the Road radio button is checked:
            if (btnRoad.Checked)
                // The issue type will be first character of the text.
                issueType = byte.Parse(btnRoad.Text.Substring(0, 1));
        }

        private void rbnUnknown_CheckedChanged(object sender, EventArgs e)
        {
            // If the Unknown radio button is checked:
            if (btnUnknown.Checked)
                // The issue type will be first character of the text.
                issueType = byte.Parse(btnUnknown.Text.Substring(0, 1));
        }
        #endregion

        #region Events
        private void keypressed(Object o, KeyPressEventArgs e)
        {
            // If the ENTER key is pressed:
            if (e.KeyChar == (char)Keys.Return)
            {
                // Set the Handled key to true.
                e.Handled = true;
            }
        }
        
        private void Coordinate_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            // Prevent the user from entering non-numeric characters.
            // If the key entered is a number from the top of the keyboard or the '-' key:
            if ((e.KeyCode < Keys.D0 && e.KeyCode != Keys.OemMinus) || 
                (e.KeyCode > Keys.D9 && e.KeyCode != Keys.OemMinus))
            {
                // If the key entered is a number from the number pad or the '-' key:
                if ((e.KeyCode < Keys.NumPad0 && e.KeyCode != Keys.Subtract) || 
                    (e.KeyCode > Keys.NumPad9 && e.KeyCode != Keys.Subtract))
                {
                    // If the key entered is a backspace:
                    if (e.KeyCode != Keys.Back)
                    {
                        // Set the flag to true and prevent the character from being entered.
                        nonNumberEntered = true;
                        e.SuppressKeyPress = true;
                    }
                }
            }
            //Prevent the user from entering special characters.
            //If the key pressed is shift:
            if (Control.ModifierKeys == Keys.Shift)
            {
                // Set the flag to true and prevent the character from being entered.
                nonNumberEntered = true;
                e.SuppressKeyPress = true;
            }
        }

        private void Coordinate_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            // If the key being entered is not a number:
            if (nonNumberEntered == true)
            {
                // Set the Handled key to true.
                e.Handled = true;
            }
        }
        #endregion
    }
}
