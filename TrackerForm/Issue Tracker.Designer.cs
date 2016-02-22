/*Purpose: Create an issue tracking form
 * Author: Joe Davidson
 * Date  : February 2016
 */
namespace TrackerForm
{
    partial class frmIssueTracker
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpIssueType = new System.Windows.Forms.GroupBox();
            this.btnUnknown = new System.Windows.Forms.RadioButton();
            this.btnRoad = new System.Windows.Forms.RadioButton();
            this.btnSignage = new System.Windows.Forms.RadioButton();
            this.btnFacility = new System.Windows.Forms.RadioButton();
            this.lblIssueDescription = new System.Windows.Forms.Label();
            this.txtIssueDescription = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblIssueDate = new System.Windows.Forms.Label();
            this.dtpIssueDate = new System.Windows.Forms.DateTimePicker();
            this.lblIssueID = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblIdNumber = new System.Windows.Forms.Label();
            this.txtResults = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblResults = new System.Windows.Forms.Label();
            this.lblCoordinateX = new System.Windows.Forms.Label();
            this.lblCoordinateY = new System.Windows.Forms.Label();
            this.txtCoordinateX = new System.Windows.Forms.TextBox();
            this.txtCoordinateY = new System.Windows.Forms.TextBox();
            this.lblCoordinateYFormat = new System.Windows.Forms.Label();
            this.lblCoordinateXFormat = new System.Windows.Forms.Label();
            this.lblDateFormat = new System.Windows.Forms.Label();
            this.lblDescriptionFormat = new System.Windows.Forms.Label();
            this.grpIssueType.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpIssueType
            // 
            this.grpIssueType.Controls.Add(this.btnUnknown);
            this.grpIssueType.Controls.Add(this.btnRoad);
            this.grpIssueType.Controls.Add(this.btnSignage);
            this.grpIssueType.Controls.Add(this.btnFacility);
            this.grpIssueType.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpIssueType.Location = new System.Drawing.Point(13, 231);
            this.grpIssueType.Margin = new System.Windows.Forms.Padding(4);
            this.grpIssueType.Name = "grpIssueType";
            this.grpIssueType.Padding = new System.Windows.Forms.Padding(4);
            this.grpIssueType.Size = new System.Drawing.Size(515, 61);
            this.grpIssueType.TabIndex = 5;
            this.grpIssueType.TabStop = false;
            this.grpIssueType.Text = "Issue Type";
            // 
            // btnUnknown
            // 
            this.btnUnknown.AutoSize = true;
            this.btnUnknown.Location = new System.Drawing.Point(386, 26);
            this.btnUnknown.Margin = new System.Windows.Forms.Padding(4);
            this.btnUnknown.Name = "btnUnknown";
            this.btnUnknown.Size = new System.Drawing.Size(102, 24);
            this.btnUnknown.TabIndex = 20;
            this.btnUnknown.TabStop = true;
            this.btnUnknown.Text = "0-Unknown";
            this.btnUnknown.UseVisualStyleBackColor = true;
            this.btnUnknown.CheckedChanged += new System.EventHandler(this.rbnUnknown_CheckedChanged);
            // 
            // btnRoad
            // 
            this.btnRoad.AutoSize = true;
            this.btnRoad.Location = new System.Drawing.Point(272, 26);
            this.btnRoad.Margin = new System.Windows.Forms.Padding(4);
            this.btnRoad.Name = "btnRoad";
            this.btnRoad.Size = new System.Drawing.Size(76, 24);
            this.btnRoad.TabIndex = 19;
            this.btnRoad.TabStop = true;
            this.btnRoad.Text = "3-Road";
            this.btnRoad.UseVisualStyleBackColor = true;
            this.btnRoad.CheckedChanged += new System.EventHandler(this.rbnRoad_CheckedChanged);
            // 
            // btnSignage
            // 
            this.btnSignage.AutoSize = true;
            this.btnSignage.Location = new System.Drawing.Point(139, 26);
            this.btnSignage.Margin = new System.Windows.Forms.Padding(4);
            this.btnSignage.Name = "btnSignage";
            this.btnSignage.Size = new System.Drawing.Size(95, 24);
            this.btnSignage.TabIndex = 18;
            this.btnSignage.TabStop = true;
            this.btnSignage.Text = "2-Signage";
            this.btnSignage.UseVisualStyleBackColor = true;
            this.btnSignage.CheckedChanged += new System.EventHandler(this.rbnSignage_CheckedChanged);
            // 
            // btnFacility
            // 
            this.btnFacility.AutoSize = true;
            this.btnFacility.Location = new System.Drawing.Point(14, 26);
            this.btnFacility.Margin = new System.Windows.Forms.Padding(4);
            this.btnFacility.Name = "btnFacility";
            this.btnFacility.Size = new System.Drawing.Size(86, 24);
            this.btnFacility.TabIndex = 17;
            this.btnFacility.TabStop = true;
            this.btnFacility.Text = "1-Facility";
            this.btnFacility.UseVisualStyleBackColor = true;
            this.btnFacility.CheckedChanged += new System.EventHandler(this.rbnFacility_CheckedChanged);
            // 
            // lblIssueDescription
            // 
            this.lblIssueDescription.AutoSize = true;
            this.lblIssueDescription.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIssueDescription.Location = new System.Drawing.Point(15, 251);
            this.lblIssueDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIssueDescription.Name = "lblIssueDescription";
            this.lblIssueDescription.Size = new System.Drawing.Size(0, 17);
            this.lblIssueDescription.TabIndex = 6;
            // 
            // txtIssueDescription
            // 
            this.txtIssueDescription.BackColor = System.Drawing.SystemColors.Window;
            this.txtIssueDescription.Location = new System.Drawing.Point(20, 346);
            this.txtIssueDescription.Margin = new System.Windows.Forms.Padding(4);
            this.txtIssueDescription.MaxLength = 250;
            this.txtIssueDescription.Multiline = true;
            this.txtIssueDescription.Name = "txtIssueDescription";
            this.txtIssueDescription.Size = new System.Drawing.Size(507, 76);
            this.txtIssueDescription.TabIndex = 7;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(20, 46);
            this.lblFirstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(84, 20);
            this.lblFirstName.TabIndex = 8;
            this.lblFirstName.Text = "First Name ";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(152, 45);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(4);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(371, 25);
            this.txtFirstName.TabIndex = 9;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(20, 83);
            this.lblLastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(83, 20);
            this.lblLastName.TabIndex = 10;
            this.lblLastName.Text = "Last Name ";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(152, 82);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(4);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(372, 25);
            this.txtLastName.TabIndex = 11;
            // 
            // lblIssueDate
            // 
            this.lblIssueDate.AutoSize = true;
            this.lblIssueDate.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIssueDate.Location = new System.Drawing.Point(20, 194);
            this.lblIssueDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIssueDate.Name = "lblIssueDate";
            this.lblIssueDate.Size = new System.Drawing.Size(85, 20);
            this.lblIssueDate.TabIndex = 12;
            this.lblIssueDate.Text = "Issue Date  ";
            // 
            // dtpIssueDate
            // 
            this.dtpIssueDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpIssueDate.Location = new System.Drawing.Point(152, 190);
            this.dtpIssueDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpIssueDate.Name = "dtpIssueDate";
            this.dtpIssueDate.Size = new System.Drawing.Size(127, 25);
            this.dtpIssueDate.TabIndex = 13;
            // 
            // lblIssueID
            // 
            this.lblIssueID.AutoSize = true;
            this.lblIssueID.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIssueID.Location = new System.Drawing.Point(20, 9);
            this.lblIssueID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIssueID.Name = "lblIssueID";
            this.lblIssueID.Size = new System.Drawing.Size(84, 20);
            this.lblIssueID.TabIndex = 14;
            this.lblIssueID.Text = "Issue ID      ";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSubmit.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(281, 633);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(4);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(111, 31);
            this.btnSubmit.TabIndex = 15;
            this.btnSubmit.Text = "Add Issue";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(421, 633);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(111, 31);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblIdNumber
            // 
            this.lblIdNumber.AutoSize = true;
            this.lblIdNumber.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdNumber.Location = new System.Drawing.Point(153, 9);
            this.lblIdNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdNumber.Name = "lblIdNumber";
            this.lblIdNumber.Size = new System.Drawing.Size(33, 20);
            this.lblIdNumber.TabIndex = 18;
            this.lblIdNumber.Text = "000";
            // 
            // txtResults
            // 
            this.txtResults.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResults.Location = new System.Drawing.Point(20, 476);
            this.txtResults.Margin = new System.Windows.Forms.Padding(4);
            this.txtResults.Multiline = true;
            this.txtResults.Name = "txtResults";
            this.txtResults.ReadOnly = true;
            this.txtResults.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtResults.Size = new System.Drawing.Size(505, 130);
            this.txtResults.TabIndex = 19;
            this.txtResults.WordWrap = false;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(20, 309);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(85, 20);
            this.lblDescription.TabIndex = 20;
            this.lblDescription.Text = "Description";
            // 
            // lblResults
            // 
            this.lblResults.AutoSize = true;
            this.lblResults.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResults.Location = new System.Drawing.Point(20, 439);
            this.lblResults.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(55, 20);
            this.lblResults.TabIndex = 21;
            this.lblResults.Text = "Results";
            // 
            // lblCoordinateX
            // 
            this.lblCoordinateX.AutoSize = true;
            this.lblCoordinateX.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoordinateX.Location = new System.Drawing.Point(20, 120);
            this.lblCoordinateX.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCoordinateX.Name = "lblCoordinateX";
            this.lblCoordinateX.Size = new System.Drawing.Size(98, 20);
            this.lblCoordinateX.TabIndex = 22;
            this.lblCoordinateX.Text = "X-Coordinate";
            // 
            // lblCoordinateY
            // 
            this.lblCoordinateY.AutoSize = true;
            this.lblCoordinateY.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoordinateY.Location = new System.Drawing.Point(20, 157);
            this.lblCoordinateY.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCoordinateY.Name = "lblCoordinateY";
            this.lblCoordinateY.Size = new System.Drawing.Size(97, 20);
            this.lblCoordinateY.TabIndex = 23;
            this.lblCoordinateY.Text = "Y-Coordinate";
            // 
            // txtCoordinateX
            // 
            this.txtCoordinateX.Location = new System.Drawing.Point(152, 119);
            this.txtCoordinateX.Margin = new System.Windows.Forms.Padding(4);
            this.txtCoordinateX.Name = "txtCoordinateX";
            this.txtCoordinateX.Size = new System.Drawing.Size(127, 25);
            this.txtCoordinateX.TabIndex = 24;
            this.txtCoordinateX.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Coordinate_KeyDown);
            // 
            // txtCoordinateY
            // 
            this.txtCoordinateY.Location = new System.Drawing.Point(152, 156);
            this.txtCoordinateY.Margin = new System.Windows.Forms.Padding(4);
            this.txtCoordinateY.Name = "txtCoordinateY";
            this.txtCoordinateY.Size = new System.Drawing.Size(127, 25);
            this.txtCoordinateY.TabIndex = 25;
            this.txtCoordinateY.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Coordinate_KeyDown);
            // 
            // lblCoordinateYFormat
            // 
            this.lblCoordinateYFormat.AutoSize = true;
            this.lblCoordinateYFormat.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoordinateYFormat.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblCoordinateYFormat.Location = new System.Drawing.Point(288, 162);
            this.lblCoordinateYFormat.Name = "lblCoordinateYFormat";
            this.lblCoordinateYFormat.Size = new System.Drawing.Size(173, 13);
            this.lblCoordinateYFormat.TabIndex = 26;
            this.lblCoordinateYFormat.Text = "Positive and negative numbers only";
            // 
            // lblCoordinateXFormat
            // 
            this.lblCoordinateXFormat.AutoSize = true;
            this.lblCoordinateXFormat.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoordinateXFormat.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblCoordinateXFormat.Location = new System.Drawing.Point(288, 125);
            this.lblCoordinateXFormat.Name = "lblCoordinateXFormat";
            this.lblCoordinateXFormat.Size = new System.Drawing.Size(173, 13);
            this.lblCoordinateXFormat.TabIndex = 27;
            this.lblCoordinateXFormat.Text = "Positive and negative numbers only";
            // 
            // lblDateFormat
            // 
            this.lblDateFormat.AutoSize = true;
            this.lblDateFormat.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateFormat.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblDateFormat.Location = new System.Drawing.Point(288, 194);
            this.lblDateFormat.Name = "lblDateFormat";
            this.lblDateFormat.Size = new System.Drawing.Size(120, 13);
            this.lblDateFormat.TabIndex = 28;
            this.lblDateFormat.Text = "Format: \"MM/DD/YYYY\"";
            // 
            // lblDescriptionFormat
            // 
            this.lblDescriptionFormat.AutoSize = true;
            this.lblDescriptionFormat.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescriptionFormat.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblDescriptionFormat.Location = new System.Drawing.Point(112, 314);
            this.lblDescriptionFormat.Name = "lblDescriptionFormat";
            this.lblDescriptionFormat.Size = new System.Drawing.Size(323, 13);
            this.lblDescriptionFormat.TabIndex = 29;
            this.lblDescriptionFormat.Text = "Please write a brief description of the issue in 250 characters or less";
            // 
            // frmIssueTracker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(545, 677);
            this.Controls.Add(this.lblDescriptionFormat);
            this.Controls.Add(this.lblDateFormat);
            this.Controls.Add(this.lblCoordinateXFormat);
            this.Controls.Add(this.lblCoordinateYFormat);
            this.Controls.Add(this.txtCoordinateY);
            this.Controls.Add(this.txtCoordinateX);
            this.Controls.Add(this.lblCoordinateY);
            this.Controls.Add(this.lblCoordinateX);
            this.Controls.Add(this.lblResults);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.txtResults);
            this.Controls.Add(this.lblIdNumber);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblIssueID);
            this.Controls.Add(this.dtpIssueDate);
            this.Controls.Add(this.lblIssueDate);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.txtIssueDescription);
            this.Controls.Add(this.lblIssueDescription);
            this.Controls.Add(this.grpIssueType);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmIssueTracker";
            this.Text = "Issue Tracker";
            this.grpIssueType.ResumeLayout(false);
            this.grpIssueType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpIssueType;
        private System.Windows.Forms.Label lblIssueDescription;
        private System.Windows.Forms.TextBox txtIssueDescription;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblIssueDate;
        private System.Windows.Forms.DateTimePicker dtpIssueDate;
        private System.Windows.Forms.Label lblIssueID;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.RadioButton btnUnknown;
        private System.Windows.Forms.RadioButton btnRoad;
        private System.Windows.Forms.RadioButton btnSignage;
        private System.Windows.Forms.RadioButton btnFacility;
        private System.Windows.Forms.Label lblIdNumber;
        private System.Windows.Forms.TextBox txtResults;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblResults;
        private System.Windows.Forms.Label lblCoordinateX;
        private System.Windows.Forms.Label lblCoordinateY;
        private System.Windows.Forms.TextBox txtCoordinateX;
        private System.Windows.Forms.TextBox txtCoordinateY;
        private System.Windows.Forms.Label lblCoordinateYFormat;
        private System.Windows.Forms.Label lblCoordinateXFormat;
        private System.Windows.Forms.Label lblDateFormat;
        private System.Windows.Forms.Label lblDescriptionFormat;
    }
}

