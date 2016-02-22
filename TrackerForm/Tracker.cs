/*Purpose: Issue Tracking 
 * Author: Kathleen Stewart
 * Date: Feb 2016
 * Edited by: Joe Davidson
 * Date: Feb 2016
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace IssueTracker
{
    /// <summary>
    /// Tracker class records and verifies all information related to tracking infrastructure issues
    /// </summary>
    class Tracker
    {
        #region Fields
        private Point pt;
        private string firstName;
        private string lastName;
        private int issueID;
        private DateTime issueDate;
        private int issueType;
        private string issueDesc;

        //constants
        public static int CurrentID = 1;
        readonly string[] typeDesc = new string[] 
        { "Unknown","Facility","Signage","Road"};

        #endregion

        #region Properties
        public int IssueID
        {
            get { return issueID; }
        }
        public string FirstName { 
            get { return firstName; } 
            set { firstName = value; }}
        public string LastName {
            get { return lastName; }
            set { lastName = value; }
        }
        public DateTime IssueDate
        {
            get { return issueDate; }
            set
            {
                DateTime now = DateTime.Today;
                DateTime lastYear = now.AddYears(-1);

                if (value > now) issueDate = now;
                else if (value < lastYear) issueDate = lastYear;
                else issueDate = value;
            }
        }
        public int IssueType
        {
            get { return issueType; }
            set
            {
                if ((value < 0) || (value >= typeDesc.Length)) { issueType = 0; }
                else issueType = value;
            }
        }
        public Point Point { get { return pt; } set { Point = value; } }
        #endregion

        #region Constructors

        /// <summary>
        /// Initial constructor - all fields
        /// </summary>
        /// <param name="x">X coordinate</param>
        /// <param name="y">Y coordinate</param>
        /// <param name="fname">Reporter's first name</param>
        /// <param name="lname">Reporter's last name</param>
        /// <param name="idate">Issue Date</param>
        /// <param name="itype">Type of Issue</param>
        /// <param name="idesc">Details of issue</param>
        public Tracker(int x, int y, string fname, string lname, DateTime idate, int itype, string idesc)
        {
            pt.X = x;
            pt.Y = y;
            FirstName = fname;
            LastName = lname;
            IssueDate = idate;
            IssueType = itype;
            issueDesc = idesc;
            issueID = incrementID();
        }

        /// <summary>
        /// Second Constructor - unspecified fields default
        /// </summary>
        /// <param name="x">X coordinate</param>
        /// <param name="y">Y coordinate</param>
        /// <param name="itype">Type of Issue</param>
        /// <param name="idesc">Details of issue</param>
        public Tracker(int x, int y, int itype, string idesc) :
            this(x, y, "", "Unknown", DateTime.Today, itype, idesc) { }
        #endregion

        #region Public Methods
        /// <summary>
        /// Return the description associated with the issue type number
        /// </summary>
        /// <returns>the issue description</returns>
        public string GetIssueType()
        {
            return typeDesc[IssueType];
        }

        /// <summary>
        /// Create a string of the issue fields
        /// </summary>
        /// <returns>a description of the issue</returns>
        public string GetIssueDetails()
        {
            return "Coordinates: " + pt.ToString()
                + " Issue Type: " + GetIssueType()
                + " \r\nDescription: " + issueDesc;
        }

        /// <summary>
        /// Add name and date to the issue description
        /// </summary>
        /// <param name="bAll">specify true to include name and date</param>
        /// <returns>complete issue description</returns>
        public string GetIssueDetails(bool bAll)
        {
            return GetIssueDetails() +
                "\r\nName: " + FirstName + " " + LastName
                + " Date: " + IssueDate.ToShortDateString();
        }
        #endregion

        #region Private Methods

        private static int incrementID()
        {
            return CurrentID++;
        }
        #endregion
    }
}
