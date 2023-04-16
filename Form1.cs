/* Allan Delos Santos
 * Student Assignment program
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Assignment3.Classes;
using System.Threading;

namespace Assignment3
{
    /// <summary>
    /// Student Assignment program
    /// Program stores max of 10 students' names (defaulted Student #1, etc.)
    /// Stores students assignments (max 99) and
    /// Each assignment can have a score set (default 0).
    /// Displays all students, their assignments and scores, average and grade
    /// </summary>

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            lblDisplayStudentError.Text = "";
            lblArrayCreateError.Text = "";
            lblAssScoreError.Text = "";
        }

        #region Variables

        /// <summary>
        /// Array holds Student Names (max 10)
        /// </summary>
        private String[] aArrayStudent = null;

        /// <summary>
        /// Multidimensional array. 
        /// Row is determined by # of students,
        /// Columns is determined by # of assignments each student has,
        /// Holds assignment scores
        /// </summary>
        private int[,] aArrayAssignment = new int[0, 0];

        /// <summary>
        /// Integer used as an iterator for array navigation
        /// </summary>
        private int iCurr = 0;

        /// <summary>
        /// StringBuilder declaration used to be continuously used for strings appended to the scoreboard richtextbox
        /// </summary>
        StringBuilder scoreboard;
        
        /// <summary>
        /// StringBuilder declaration used to update the scoreboard
        /// </summary>
        StringBuilder updatescoreboard;

        /// <summary>
        /// Variable to hold user input for integers
        /// </summary>
        private int iUserInput;

        #endregion

        #region Methods

        /// <summary>
        /// Formats the richtextbox to show column titles for student data
        /// </summary>
        private void RichTextBoxDefault()
        {
            scoreboard = new StringBuilder();
            scoreboard.Append("Student\t\t");

            for (int i = 0; i < aArrayAssignment.GetLength(1); i++)
            {
                scoreboard.Append("#" + (i + 1) + "\t");
            }

            scoreboard.Append("AVG\t" + "GRADE");

            rtxtbxScoreDisplay.Text = scoreboard.ToString();
        }

        #region Student and Assignment Array Creation

        /// <summary>
        /// Method for creating an Array of Student Names (max 10).
        /// Takes an integer parameter from user input to determine array size between 1 - 10.
        /// </summary>
        private bool CreateArrayStudent()
        {
            if (CheckArrayStudentSize(ConvertStringToInt(txtCreateArrayStudent.Text)))
            {
                aArrayStudent = new string[iUserInput];
                SetStudentDefault(iUserInput);

                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// Method for Setting the Names of a newly created Student Array
        /// to Default names: Student #1, 2, 3, etc.
        /// </summary>
        /// <param name="size"></param>
        private void SetStudentDefault(int size)
        {
            for (int i = 0; i < size; i++)
            {
                aArrayStudent[i] = "Student #" + (i + 1);
            }
        }
        /// <summary>
        /// Verifies user input by checking that number entered is between 1 - 10,
        /// to create Student Array
        /// Verifies if Student array is null
        /// Displays error message when false.
        /// </summary>
        /// <param name="bIsInt"></param>
        /// <returns></returns>
        private bool CheckArrayStudentSize(bool bIsInt)
        {
            if (bIsInt)
            {
                if (iUserInput <= 10)
                {
                    return true;
                }
                else
                {
                    lblArrayCreateError.Text += "Only a max of 10 Students is allowed.";
                    return false;
                }
            }
            else if (ArrayIsNull())
            {
                lblArrayCreateError.Text += "Error. Please enter the number of students.";
                return false;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// Displays all student names in student array as a string.
        /// </summary>
        /// <returns></returns>
        private String StudentToString(int index)
        {
            return ("\n" + aArrayStudent[index] + "\t");
        }

        /// <summary>
        /// Creates a Multidimensional array to store student assignment scores
        /// returns true if successfully created
        /// </summary>
        private bool CreateArrayAssignment()
        {
            if (CheckArrayAssignmentSize(ConvertStringToInt(txtCreateArrayAssignment.Text)))
            {
                aArrayAssignment = new int[aArrayStudent.Length, iUserInput];
                SetAssScoreDefault();

                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// Validates user input to create Assignment array
        /// is a number and does not exceed the max of 99
        /// Verifies if Assignment array is null
        /// </summary>
        /// <param name="bIsInt"></param>
        /// <returns></returns>
        private bool CheckArrayAssignmentSize(bool bIsInt)
        {
            if (bIsInt)
            {
                if (iUserInput <= 99)
                {
                    return true;
                }
                else
                {
                    lblArrayCreateError.Text += "\nOnly a max of 99 assignments is allowed.";
                    return false;
                }
            }
            else if (ArrayIsNull())
            {
                lblArrayCreateError.Text += "Error. Please enter the number of assignments.";
                return false;
            }
            else
            {
                lblArrayCreateError.Text += "Error. Please enter a number.";
                return false;
            }
        }

        /// <summary>
        /// Method checks if Student or Assignment array is empty/null
        /// if so returns true
        /// </summary>
        /// <returns></returns>
        private bool ArrayIsNull()
        {
            if ((aArrayStudent == null) || (aArrayAssignment == null))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Method when Submit Counts button is clicked.
        /// Calls methods to create Student and Assignment Arrays.
        /// Calls method to validate input is a number.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnArrayCreate_Click(object sender, EventArgs e)
        {
            ClearBoard();
            ClearError();
            SetArrayAsNull();

            if (CreateArrayStudent() && CreateArrayAssignment())
            {
                UpdateAssRange();
                DisplayStudent(0);
            }

            
        }
        #endregion

        #region Student name manipulation

        /// <summary>
        /// Display the student name using Student array and iCurr as the index.
        /// </summary>
        private void DisplayStudent(int index)
        {
            lblStudentDisplay.Text = aArrayStudent[index] + ":";
        }

        /// <summary>
        /// Displays the first student in the Student array.
        /// </summary>
        private void DisplayStudentFirst()
        {
            if (!ArrayIsNull())
            {
                iCurr = 0;

                if (DisplayStudentError())
                {
                    DisplayStudent(iCurr);
                }
            }
            
        }
        /// <summary>
        /// Displays the previous student from what's currently being displayed.
        /// </summary>
        private void DisplayStudentPrev()
        {
            if (!ArrayIsNull())
            {
                iCurr--;

                if (DisplayStudentError())
                {
                    DisplayStudent(iCurr);
                }
            }
        }
        /// <summary>
        /// Displays the next student from what's currently being displayed.
        /// </summary>
        private void DisplayStudentNext()
        {
            if (!ArrayIsNull())
            {
                iCurr++;

                if (DisplayStudentError())
                {
                    DisplayStudent(iCurr);
                }
            }
        }
        /// <summary>
        /// Displays the last student in the Student array.
        /// </summary>
        private void DisplayStudentLast()
        {
            if (!ArrayIsNull())
            {
                iCurr = aArrayStudent.Length - 1;

                if (DisplayStudentError())
                {
                    DisplayStudent(iCurr);
                }
            }
        }

        /// <summary>
        /// Displays an error label if the user tries to navigate past the bounds
        /// of the Student array.
        /// </summary>
        /// <returns></returns>
        private bool DisplayStudentError()
        {
            lblDisplayStudentError.Text = "";

            if (aArrayStudent.Length == 1)
            {
                lblDisplayStudentError.Text = "Only one Student submitted.";
                return false;
            }
            if (aArrayStudent == null)
            {
                lblDisplayStudentError.Text = "No Students to display.";
                return false;
            }
            else if (iCurr < 0)
            {
                iCurr++;
                lblDisplayStudentError.Text = "No previous Student to display.";
                return false;
            }
            else if (aArrayStudent.Length < iCurr + 1)
            {
                iCurr--;
                lblDisplayStudentError.Text = "No next Student to display.";
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// Method updates the Student Name of the Student currently displayed,
        /// taken from User input.
        /// </summary>
        private void StudentSave()
        {
            if (!ArrayIsNull())
            {
                if (txtStudentSave.Text != "")
                {
                    txtStudentSave.Text.Trim();
                    aArrayStudent[iCurr] = txtStudentSave.Text;
                    DisplayStudent(iCurr);
                    txtStudentSave.Text = "";
                }
                else
                {
                    lblDisplayStudentError.Text = "No new name entered. Nothing updated. ";
                }
            }
        }

        /// <summary>
        /// Method when First Student button is clicked.
        /// Displays the first student in the Student array,
        /// if not already displaying.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStudentFirst_Click(object sender, EventArgs e)
        {
            DisplayStudentFirst();
        }

        /// <summary>
        /// Method when Prev Student button is clicked.
        /// Displays the previous student from the current being displayed.
        /// Displays an error when there are no more previous students to display.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStudentPrev_Click(object sender, EventArgs e)
        {
            DisplayStudentPrev();
        }

        /// <summary>
        /// Method when Next Student button is clicked.
        /// Displays the next student from the current being displayed.
        /// Displays an error when there are no more next students to display.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStudentNext_Click(object sender, EventArgs e)
        {
            DisplayStudentNext();
        }

        /// <summary>
        /// Method when Last Student button is clicked.
        /// Displays the last student in the Student array,
        /// if not already.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStudentLast_Click(object sender, EventArgs e)
        {
            DisplayStudentLast();
        }

        /// <summary>
        /// Method when Save Name button is clicked.
        /// Using User input, Updates Student name stored at current index
        /// and Displays the updated name.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStudentSave_Click(object sender, EventArgs e)
        {
            StudentSave();
        }

        #endregion

        #region Student assignment manipulation

        /// <summary>
        /// Method updates the assignment range to correctly reflect
        /// the lower and high boundary of the Assignment array 
        /// displayed on the AssNum label.
        /// </summary>
        private void UpdateAssRange()
        {
            lblAssNum.Text = "Enter Assignment Number ( "
                + (aArrayAssignment.GetLowerBound(1) + 1)
                + " - "
                + (aArrayAssignment.GetUpperBound(1) + 1)
                + " ): ";
        }

        /// <summary>
        /// Sets all assignment scores in the Assignment array to 0
        /// </summary>
        private void SetAssScoreDefault()
        {
            for (int row = 0; row < aArrayAssignment.GetUpperBound(0); row++)
            {
                for (int column = 0; column < aArrayAssignment.GetUpperBound(1); column++)
                {
                    aArrayAssignment[row, column] = 0;
                }
            }
        }

        /// <summary>
        /// Method verifies user input for the assignment number is both anumber and a valid number between 1 
        /// and the number of assignments the user declared at the beginning of the program.
        /// </summary>
        /// <param name="bIsInt"></param>
        /// <returns></returns>
        private bool CheckAssignmentNum(bool bIsInt)
        {
            if (bIsInt)
            {
                if (1 <= iUserInput && iUserInput <= aArrayAssignment.GetUpperBound(1) + 1)
                {
                    return true;
                }
                else
                {
                    lblAssScoreError.Text += "Must be a number between 1 - " + (aArrayAssignment.GetUpperBound(1) + 1) + ". ";
                    return false;
                }
            }
            else if (txtAssNum.Text == "")
            {
                lblAssScoreError.Text += "No Assignment number entered. ";
                return false;
            }
            else
            {
                lblAssScoreError.Text += "Please enter an assignment number. ";
                return false;
            }
        }

        /// <summary>
        /// Method verifies user input for the assignment score is both a number and a valid number between 0 - 100,
        /// otherwise displays an error.
        /// </summary>
        /// <param name="bIsInt"></param>
        /// <returns></returns>
        private bool CheckScore(bool bIsInt)
        {
            if (bIsInt)
            {
                if (0 <= iUserInput && iUserInput <= 100)
                {
                    return true;
                }
                else
                {
                    lblAssScoreError.Text += "Score must be between 0 - 100. ";
                    return false;
                }
            }
            else if (txtAssScore.Text == "")
            {
                lblAssScoreError.Text += "No Assignment score entered. ";
                return false;
            }
            else
            {
                lblAssScoreError.Text += "Please enter a score number. ";
                return false;
            }
        }

        /// <summary>
        /// Method takes user input for the assignment number and what score it will be updated as user input,
        /// if input is either empty or not an acceptable number, displays an error and does not update.
        /// </summary>
        private void UpdateAssignmentScore()
        {
            if (CheckAssignmentNum(ConvertStringToInt(txtAssNum.Text))) {
                int iAssNum = iUserInput - 1;

                if (CheckScore(ConvertStringToInt(txtAssScore.Text))) {
                    aArrayAssignment[iCurr, iAssNum] = iUserInput;

                    txtAssNum.Text = "";
                    txtAssScore.Text = "";
                }
                else
                {
                    lblAssScoreError.Text += "Nothing updated. ";
                }
            }
            else
            {
                lblAssScoreError.Text += "Nothing updated. ";
            }
        }

        /// <summary>
        /// Method to display score at certain index of Assignment array as string.
        /// </summary>
        /// <param name="row"></param>
        /// <param name="column"></param>
        /// <returns></returns>
        private String AssignmentToString(int row, int column)
        {
            return (aArrayAssignment[row, column].ToString() + "\t");
        }

        /// <summary>
        /// Method when Save score button is pressed,
        /// Saves the updated score to the assignment specified by user input
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAssScoreSave_Click(object sender, EventArgs e)
        {
            lblAssScoreError.Text = "";

            UpdateAssignmentScore();
        }

        #endregion

        #region Score Display

        /// <summary>
        /// Method to display/update the scoreboard richtextbox to display the student, 
        /// the # of assignments, each respective score, 
        /// the student's avg of all scores, and their letter grade
        /// </summary>
        private string ScoreDisplay()
        {
            string sScoreboard = "";

            if (!ArrayIsNull())
            {
                RichTextBoxDefault();
                updatescoreboard = new StringBuilder();
                double avg;

                for (int row = 0; row < aArrayStudent.Length; row++)
                {
                    updatescoreboard.Append(StudentToString(row));

                    for (int column = 0; column < aArrayAssignment.GetUpperBound(1) + 1; column++)
                    {
                        updatescoreboard.Append(AssignmentToString(row, column));
                    }
                    avg = CalculateAssignmentAvg(row);
                    updatescoreboard.Append(AssignmentAvgToString(avg));
                    updatescoreboard.Append(CalculateGrade(avg));
                }

                sScoreboard += updatescoreboard.ToString();

                return sScoreboard;
            }
            else
            {
                return "";
            }
        }

        /// <summary>
        /// Method calculates the assignment average of the student at the index passed in.
        /// </summary>
        /// <param name="student"></param>
        /// <returns></returns>
        private double CalculateAssignmentAvg(int student)
        {
            double dTotalScore = 0;
            double dTotalNum = aArrayAssignment.GetUpperBound(1) + 1;

            for (int assignment = 0; assignment < aArrayAssignment.GetUpperBound(1) + 1; assignment++)
            {
                dTotalScore += aArrayAssignment[student, assignment];
            }

            return (dTotalScore / dTotalNum);
        }

        /// <summary>
        /// Method returns a string using the double passed in,
        /// meant for use with an avg passed in to display on scoreboard
        /// </summary>
        /// <param name="avg"></param>
        /// <returns></returns>
        private String AssignmentAvgToString(double avg)
        {
            return String.Format("{0:00.00}", avg.ToString()) + "\t";
            
        }

        /// <summary>
        /// Method determines and returns a letter Grade using the passed in double.
        /// </summary>
        /// <param name="avg"></param>
        /// <returns></returns>
        private String CalculateGrade(double avg)
        {
            if (93 <= avg)
            {
                return "A";
            }
            else if (90 <= avg && avg <= 92.9)
            {
                return "A-";
            }
            else if (87 <= avg && avg <= 89.9)
            {
                return "B+";
            }
            else if (83 <= avg && avg <= 86.9)
            {
                return "B";
            }
            else if (80 <= avg && avg <= 82.9)
            {
                return "B-";
            }
            else if (77 <= avg && avg <= 79.9)
            {
                return "C+";
            }
            else if (73 <= avg && avg <= 76.9)
            {
                return "C";
            }
            else if (70 <= avg && avg <= 72.9)
            {
                return "C-";
            }
            else if (67 <= avg && avg <= 69.9)
            {
                return "D+";
            }
            else if (63 <= avg && avg <= 66.9)
            {
                return "D";
            }
            else if (60 <= avg && avg <= 62.9)
            {
                return "D-";
            }
            else
            {
                return "E";
            }
        }

        /// <summary>
        /// Method for when the Score display button is pressed.
        /// Calls score display method to display student info onto
        /// the scoreboard richtextbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnScoreDisplay_Click(object sender, EventArgs e)
        {
            if (ScoreDisplay() != "")
            {
                rtxtbxScoreDisplay.Text += ScoreDisplay();
            }
        }
        #endregion

        /// <summary>
        /// Method for converting user input as string to int,
        /// Used mainly for User input validation
        /// </summary>
        /// <param name="sInput"></param>
        /// <returns></returns>
        private bool ConvertStringToInt(String sInput)
        {
            bool bResultConvert = int.TryParse(sInput, out iUserInput);

            if (bResultConvert)
            {
                return true;
            }
            else if (sInput == null)
            {
                return false;
            }
            else
            {
                return false;
            }
        }

        #region Reset
        /// <summary>
        /// Method clears the richtextbox displaying student info
        /// </summary>
        private void ClearBoard()
        {
            rtxtbxScoreDisplay.Text = "";
        }
        /// <summary>
        /// Method clears all error labels
        /// </summary>
        private void ClearError()
        {
            lblArrayCreateError.Text = "";
            lblAssScoreError.Text = "";
            lblDisplayStudentError.Text = "";
        }
        /// <summary>
        /// Method clears all textboxes
        /// </summary>
        private void ClearTextbox()
        {
            txtAssNum.Text = "";
            txtAssScore.Text = "";
            txtCreateArrayAssignment.Text = "";
            txtCreateArrayStudent.Text = "";
            txtStudentSave.Text = "";
        }
        /// <summary>
        /// Method sets all global integer variables to zero
        /// </summary>
        private void ClearVar()
        {
            iCurr = 0;
            iUserInput = 0;
        }
        /// <summary>
        /// Method sets the student and assignment arrays as null.
        /// </summary>
        private void SetArrayAsNull()
        {
            aArrayStudent = null;
            aArrayAssignment = null;
        }
        /// <summary>
        /// Method resets all variables, labels, textboxes, and arrays to their initial state.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReset_Click(object sender, EventArgs e)
        {
            ClearBoard();
            ClearError();
            ClearTextbox();
            ClearVar();
            SetArrayAsNull();
        }
        #endregion

        #endregion

        #region New Variables for Assignment 7
        /// <summary>
        /// File object
        /// </summary>
        clsFile newFile;
        /// <summary>
        /// Delegate used to dispay a message on the UI thread
        /// </summary>
        private delegate void DisplayMessageDelegate();


        #endregion

        #region New Methods for Assignment 7
        /// <summary>
        /// Method for when Output to file button is pressed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFileOut_Click(object sender, EventArgs e)
        {
            try
            {
                lblFileError.Text = "";

                string fileName = txtFileName.Text;

                if (fileName.Length > 0)
                {
                    // Call methods to generate score
                    RichTextBoxDefault();
                    rtxtbxScoreDisplay.Text += ScoreDisplay();

                    // Create File
                    newFile = new clsFile();

                    // Fill file with generated score
                    newFile.Name = fileName;
                    newFile.Scoreboard = rtxtbxScoreDisplay.Text;
                    rtxtbxScoreDisplay.Text = "";
                    txtFileName.Text = "";

                    // Display message that file writing has began
                    lblFileError.Text = "Writing to file.";
                    btnFileOut.Enabled = false;
                    // Create background thread to write file
                    backgroundWorker1.RunWorkerAsync();

                }
                else
                {
                    lblFileError.Text = "Enter an unused file name.";
                }
            }
            catch (Exception ex)
            {
                HandleError(MethodInfo.GetCurrentMethod().DeclaringType.Name,
                    MethodInfo.GetCurrentMethod().Name, ex.Message);
            }
        }
        /// <summary>
        /// Method used to update the label that file creation has completed.
        /// </summary>
        private void DisplayFinishMessage()
        {
            lblFileError.Text = "Finshed Writing to File.";
        }

        /// <summary>
        /// Method for Handling Errors
        /// Top level method when called displays a message to the user with the error,
        /// If an error occurs when displaying, save a file into the C drive with the Exception message.
        /// </summary>
        /// <param name="sClass"></param>
        /// <param name="sMethod"></param>
        /// <param name="sMessage"></param>
        private void HandleError(string sClass, string sMethod, string sMessage)
        {
            try
            {
                MessageBox.Show(sClass + "." + sMethod + " -> " + sMessage);
            }
            catch (System.Exception ex)
            {
                System.IO.File.AppendAllText(@"C:\Users\Public\Error.txt", Environment.NewLine + "HandleError Exception: " + ex.Message);
            }
        }

        /// <summary>
        /// Handles the DoWork event from the backgroundWorker
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                // Create New thread for file creation
                newFile.CreateFile();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// The backgroundWorker has completed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                // Invoke delete to display File creation completion
                lblFileError.Invoke(new DisplayMessageDelegate(DisplayFinishMessage));
                btnFileOut.Enabled = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Handles backgroundWorker Progress
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            try
            {
                lblFileError.Text = "Writing to file.";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
    }
}
