
namespace Assignment3
{
    partial class Form1
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
            this.lblArrayStudent = new System.Windows.Forms.Label();
            this.txtCreateArrayStudent = new System.Windows.Forms.TextBox();
            this.btnArrayCreate = new System.Windows.Forms.Button();
            this.lblArrayCreateError = new System.Windows.Forms.Label();
            this.rtxtbxScoreDisplay = new System.Windows.Forms.RichTextBox();
            this.lblArrayAssignment = new System.Windows.Forms.Label();
            this.txtCreateArrayAssignment = new System.Windows.Forms.TextBox();
            this.btnStudentFirst = new System.Windows.Forms.Button();
            this.btnStudentLast = new System.Windows.Forms.Button();
            this.btnStudentNext = new System.Windows.Forms.Button();
            this.lblStudentDisplay = new System.Windows.Forms.Label();
            this.txtStudentSave = new System.Windows.Forms.TextBox();
            this.btnStudentSave = new System.Windows.Forms.Button();
            this.lblDisplayStudentError = new System.Windows.Forms.Label();
            this.btnStudentPrev = new System.Windows.Forms.Button();
            this.lblAssNum = new System.Windows.Forms.Label();
            this.txtAssNum = new System.Windows.Forms.TextBox();
            this.lblAssScore = new System.Windows.Forms.Label();
            this.txtAssScore = new System.Windows.Forms.TextBox();
            this.lblAssScoreError = new System.Windows.Forms.Label();
            this.btnScoreDisplay = new System.Windows.Forms.Button();
            this.btnAssScoreSave = new System.Windows.Forms.Button();
            this.groupArrayCreate = new System.Windows.Forms.GroupBox();
            this.groupNavigate = new System.Windows.Forms.GroupBox();
            this.groupStudent = new System.Windows.Forms.GroupBox();
            this.groupAssignment = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.groupArrayCreate.SuspendLayout();
            this.groupNavigate.SuspendLayout();
            this.groupStudent.SuspendLayout();
            this.groupAssignment.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblArrayStudent
            // 
            this.lblArrayStudent.AutoSize = true;
            this.lblArrayStudent.Location = new System.Drawing.Point(26, 33);
            this.lblArrayStudent.Name = "lblArrayStudent";
            this.lblArrayStudent.Size = new System.Drawing.Size(138, 17);
            this.lblArrayStudent.TabIndex = 0;
            this.lblArrayStudent.Text = "Number of Students:";
            // 
            // txtCreateArrayStudent
            // 
            this.txtCreateArrayStudent.Location = new System.Drawing.Point(170, 33);
            this.txtCreateArrayStudent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCreateArrayStudent.Name = "txtCreateArrayStudent";
            this.txtCreateArrayStudent.Size = new System.Drawing.Size(89, 22);
            this.txtCreateArrayStudent.TabIndex = 1;
            // 
            // btnArrayCreate
            // 
            this.btnArrayCreate.Location = new System.Drawing.Point(305, 43);
            this.btnArrayCreate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnArrayCreate.Name = "btnArrayCreate";
            this.btnArrayCreate.Size = new System.Drawing.Size(113, 41);
            this.btnArrayCreate.TabIndex = 2;
            this.btnArrayCreate.Text = "Submit Counts";
            this.btnArrayCreate.UseVisualStyleBackColor = true;
            this.btnArrayCreate.Click += new System.EventHandler(this.btnArrayCreate_Click);
            // 
            // lblArrayCreateError
            // 
            this.lblArrayCreateError.AutoSize = true;
            this.lblArrayCreateError.Location = new System.Drawing.Point(171, 9);
            this.lblArrayCreateError.Name = "lblArrayCreateError";
            this.lblArrayCreateError.Size = new System.Drawing.Size(79, 17);
            this.lblArrayCreateError.TabIndex = 3;
            this.lblArrayCreateError.Text = "Error Label";
            // 
            // rtxtbxScoreDisplay
            // 
            this.rtxtbxScoreDisplay.Location = new System.Drawing.Point(41, 475);
            this.rtxtbxScoreDisplay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtxtbxScoreDisplay.Name = "rtxtbxScoreDisplay";
            this.rtxtbxScoreDisplay.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtxtbxScoreDisplay.Size = new System.Drawing.Size(870, 156);
            this.rtxtbxScoreDisplay.TabIndex = 4;
            this.rtxtbxScoreDisplay.Text = "";
            // 
            // lblArrayAssignment
            // 
            this.lblArrayAssignment.AutoSize = true;
            this.lblArrayAssignment.Location = new System.Drawing.Point(2, 67);
            this.lblArrayAssignment.Name = "lblArrayAssignment";
            this.lblArrayAssignment.Size = new System.Drawing.Size(162, 17);
            this.lblArrayAssignment.TabIndex = 5;
            this.lblArrayAssignment.Text = "Number of Assignments:";
            // 
            // txtCreateArrayAssignment
            // 
            this.txtCreateArrayAssignment.Location = new System.Drawing.Point(170, 67);
            this.txtCreateArrayAssignment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCreateArrayAssignment.Name = "txtCreateArrayAssignment";
            this.txtCreateArrayAssignment.Size = new System.Drawing.Size(89, 22);
            this.txtCreateArrayAssignment.TabIndex = 6;
            // 
            // btnStudentFirst
            // 
            this.btnStudentFirst.Location = new System.Drawing.Point(33, 27);
            this.btnStudentFirst.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStudentFirst.Name = "btnStudentFirst";
            this.btnStudentFirst.Size = new System.Drawing.Size(162, 46);
            this.btnStudentFirst.TabIndex = 7;
            this.btnStudentFirst.Text = "<< First Student";
            this.btnStudentFirst.UseVisualStyleBackColor = true;
            this.btnStudentFirst.Click += new System.EventHandler(this.btnStudentFirst_Click);
            // 
            // btnStudentLast
            // 
            this.btnStudentLast.Location = new System.Drawing.Point(617, 27);
            this.btnStudentLast.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStudentLast.Name = "btnStudentLast";
            this.btnStudentLast.Size = new System.Drawing.Size(162, 46);
            this.btnStudentLast.TabIndex = 7;
            this.btnStudentLast.Text = ">> Last Student";
            this.btnStudentLast.UseVisualStyleBackColor = true;
            this.btnStudentLast.Click += new System.EventHandler(this.btnStudentLast_Click);
            // 
            // btnStudentNext
            // 
            this.btnStudentNext.Location = new System.Drawing.Point(426, 27);
            this.btnStudentNext.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStudentNext.Name = "btnStudentNext";
            this.btnStudentNext.Size = new System.Drawing.Size(162, 46);
            this.btnStudentNext.TabIndex = 7;
            this.btnStudentNext.Text = "> Next Student";
            this.btnStudentNext.UseVisualStyleBackColor = true;
            this.btnStudentNext.Click += new System.EventHandler(this.btnStudentNext_Click);
            // 
            // lblStudentDisplay
            // 
            this.lblStudentDisplay.AutoSize = true;
            this.lblStudentDisplay.Location = new System.Drawing.Point(6, 35);
            this.lblStudentDisplay.Name = "lblStudentDisplay";
            this.lblStudentDisplay.Size = new System.Drawing.Size(81, 17);
            this.lblStudentDisplay.TabIndex = 8;
            this.lblStudentDisplay.Text = "Student #1:";
            // 
            // txtStudentSave
            // 
            this.txtStudentSave.Location = new System.Drawing.Point(101, 32);
            this.txtStudentSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtStudentSave.Name = "txtStudentSave";
            this.txtStudentSave.Size = new System.Drawing.Size(435, 22);
            this.txtStudentSave.TabIndex = 9;
            // 
            // btnStudentSave
            // 
            this.btnStudentSave.Location = new System.Drawing.Point(571, 27);
            this.btnStudentSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStudentSave.Name = "btnStudentSave";
            this.btnStudentSave.Size = new System.Drawing.Size(105, 38);
            this.btnStudentSave.TabIndex = 10;
            this.btnStudentSave.Text = "Save Name";
            this.btnStudentSave.UseVisualStyleBackColor = true;
            this.btnStudentSave.Click += new System.EventHandler(this.btnStudentSave_Click);
            // 
            // lblDisplayStudentError
            // 
            this.lblDisplayStudentError.AutoSize = true;
            this.lblDisplayStudentError.Location = new System.Drawing.Point(135, 235);
            this.lblDisplayStudentError.Name = "lblDisplayStudentError";
            this.lblDisplayStudentError.Size = new System.Drawing.Size(79, 17);
            this.lblDisplayStudentError.TabIndex = 11;
            this.lblDisplayStudentError.Text = "Error Label";
            // 
            // btnStudentPrev
            // 
            this.btnStudentPrev.Location = new System.Drawing.Point(226, 27);
            this.btnStudentPrev.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStudentPrev.Name = "btnStudentPrev";
            this.btnStudentPrev.Size = new System.Drawing.Size(168, 46);
            this.btnStudentPrev.TabIndex = 12;
            this.btnStudentPrev.Text = "< Prev Student";
            this.btnStudentPrev.UseVisualStyleBackColor = true;
            this.btnStudentPrev.Click += new System.EventHandler(this.btnStudentPrev_Click);
            // 
            // lblAssNum
            // 
            this.lblAssNum.AutoSize = true;
            this.lblAssNum.Location = new System.Drawing.Point(10, 46);
            this.lblAssNum.Name = "lblAssNum";
            this.lblAssNum.Size = new System.Drawing.Size(228, 17);
            this.lblAssNum.TabIndex = 13;
            this.lblAssNum.Text = "Enter Assignment Number ( 0 - 0 ):";
            // 
            // txtAssNum
            // 
            this.txtAssNum.Location = new System.Drawing.Point(244, 46);
            this.txtAssNum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAssNum.Name = "txtAssNum";
            this.txtAssNum.Size = new System.Drawing.Size(89, 22);
            this.txtAssNum.TabIndex = 14;
            // 
            // lblAssScore
            // 
            this.lblAssScore.AutoSize = true;
            this.lblAssScore.Location = new System.Drawing.Point(112, 70);
            this.lblAssScore.Name = "lblAssScore";
            this.lblAssScore.Size = new System.Drawing.Size(126, 17);
            this.lblAssScore.TabIndex = 15;
            this.lblAssScore.Text = "Assignment Score:";
            // 
            // txtAssScore
            // 
            this.txtAssScore.Location = new System.Drawing.Point(244, 73);
            this.txtAssScore.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAssScore.Name = "txtAssScore";
            this.txtAssScore.Size = new System.Drawing.Size(89, 22);
            this.txtAssScore.TabIndex = 16;
            // 
            // lblAssScoreError
            // 
            this.lblAssScoreError.AutoSize = true;
            this.lblAssScoreError.Location = new System.Drawing.Point(241, 18);
            this.lblAssScoreError.Name = "lblAssScoreError";
            this.lblAssScoreError.Size = new System.Drawing.Size(79, 17);
            this.lblAssScoreError.TabIndex = 17;
            this.lblAssScoreError.Text = "Error Label";
            // 
            // btnScoreDisplay
            // 
            this.btnScoreDisplay.Location = new System.Drawing.Point(395, 430);
            this.btnScoreDisplay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnScoreDisplay.Name = "btnScoreDisplay";
            this.btnScoreDisplay.Size = new System.Drawing.Size(127, 41);
            this.btnScoreDisplay.TabIndex = 18;
            this.btnScoreDisplay.Text = "Display Scores";
            this.btnScoreDisplay.UseVisualStyleBackColor = true;
            this.btnScoreDisplay.Click += new System.EventHandler(this.btnScoreDisplay_Click);
            // 
            // btnAssScoreSave
            // 
            this.btnAssScoreSave.Location = new System.Drawing.Point(358, 50);
            this.btnAssScoreSave.Name = "btnAssScoreSave";
            this.btnAssScoreSave.Size = new System.Drawing.Size(108, 37);
            this.btnAssScoreSave.TabIndex = 19;
            this.btnAssScoreSave.Text = "Save Score";
            this.btnAssScoreSave.UseVisualStyleBackColor = true;
            this.btnAssScoreSave.Click += new System.EventHandler(this.btnAssScoreSave_Click);
            // 
            // groupArrayCreate
            // 
            this.groupArrayCreate.Controls.Add(this.btnArrayCreate);
            this.groupArrayCreate.Controls.Add(this.lblArrayStudent);
            this.groupArrayCreate.Controls.Add(this.lblArrayAssignment);
            this.groupArrayCreate.Controls.Add(this.txtCreateArrayStudent);
            this.groupArrayCreate.Controls.Add(this.txtCreateArrayAssignment);
            this.groupArrayCreate.Controls.Add(this.lblArrayCreateError);
            this.groupArrayCreate.Location = new System.Drawing.Point(41, 12);
            this.groupArrayCreate.Name = "groupArrayCreate";
            this.groupArrayCreate.Size = new System.Drawing.Size(532, 107);
            this.groupArrayCreate.TabIndex = 20;
            this.groupArrayCreate.TabStop = false;
            this.groupArrayCreate.Text = "Counts";
            // 
            // groupNavigate
            // 
            this.groupNavigate.Controls.Add(this.btnStudentFirst);
            this.groupNavigate.Controls.Add(this.btnStudentPrev);
            this.groupNavigate.Controls.Add(this.btnStudentNext);
            this.groupNavigate.Controls.Add(this.btnStudentLast);
            this.groupNavigate.Location = new System.Drawing.Point(37, 142);
            this.groupNavigate.Name = "groupNavigate";
            this.groupNavigate.Size = new System.Drawing.Size(811, 90);
            this.groupNavigate.TabIndex = 21;
            this.groupNavigate.TabStop = false;
            this.groupNavigate.Text = "Navigate";
            // 
            // groupStudent
            // 
            this.groupStudent.Controls.Add(this.lblStudentDisplay);
            this.groupStudent.Controls.Add(this.txtStudentSave);
            this.groupStudent.Controls.Add(this.btnStudentSave);
            this.groupStudent.Location = new System.Drawing.Point(37, 255);
            this.groupStudent.Name = "groupStudent";
            this.groupStudent.Size = new System.Drawing.Size(811, 64);
            this.groupStudent.TabIndex = 22;
            this.groupStudent.TabStop = false;
            this.groupStudent.Text = "Student Info";
            // 
            // groupAssignment
            // 
            this.groupAssignment.Controls.Add(this.lblAssNum);
            this.groupAssignment.Controls.Add(this.lblAssScore);
            this.groupAssignment.Controls.Add(this.txtAssNum);
            this.groupAssignment.Controls.Add(this.txtAssScore);
            this.groupAssignment.Controls.Add(this.btnAssScoreSave);
            this.groupAssignment.Controls.Add(this.lblAssScoreError);
            this.groupAssignment.Location = new System.Drawing.Point(41, 325);
            this.groupAssignment.Name = "groupAssignment";
            this.groupAssignment.Size = new System.Drawing.Size(810, 100);
            this.groupAssignment.TabIndex = 23;
            this.groupAssignment.TabStop = false;
            this.groupAssignment.Text = "Assignment Info";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(637, 43);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(179, 64);
            this.btnReset.TabIndex = 24;
            this.btnReset.Text = "Reset Scores";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 642);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.groupAssignment);
            this.Controls.Add(this.groupStudent);
            this.Controls.Add(this.lblDisplayStudentError);
            this.Controls.Add(this.groupNavigate);
            this.Controls.Add(this.groupArrayCreate);
            this.Controls.Add(this.btnScoreDisplay);
            this.Controls.Add(this.rtxtbxScoreDisplay);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Scores";
            this.groupArrayCreate.ResumeLayout(false);
            this.groupArrayCreate.PerformLayout();
            this.groupNavigate.ResumeLayout(false);
            this.groupStudent.ResumeLayout(false);
            this.groupStudent.PerformLayout();
            this.groupAssignment.ResumeLayout(false);
            this.groupAssignment.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblArrayStudent;
        private System.Windows.Forms.TextBox txtCreateArrayStudent;
        private System.Windows.Forms.Button btnArrayCreate;
        private System.Windows.Forms.Label lblArrayCreateError;
        private System.Windows.Forms.RichTextBox rtxtbxScoreDisplay;
        private System.Windows.Forms.Label lblArrayAssignment;
        private System.Windows.Forms.TextBox txtCreateArrayAssignment;
        private System.Windows.Forms.Button btnStudentFirst;
        private System.Windows.Forms.Button btnStudentLast;
        private System.Windows.Forms.Button btnStudentNext;
        private System.Windows.Forms.Label lblStudentDisplay;
        private System.Windows.Forms.TextBox txtStudentSave;
        private System.Windows.Forms.Button btnStudentSave;
        private System.Windows.Forms.Label lblDisplayStudentError;
        private System.Windows.Forms.Button btnStudentPrev;
        private System.Windows.Forms.Label lblAssNum;
        private System.Windows.Forms.TextBox txtAssNum;
        private System.Windows.Forms.Label lblAssScore;
        private System.Windows.Forms.TextBox txtAssScore;
        private System.Windows.Forms.Label lblAssScoreError;
        private System.Windows.Forms.Button btnScoreDisplay;
        private System.Windows.Forms.Button btnAssScoreSave;
        private System.Windows.Forms.GroupBox groupArrayCreate;
        private System.Windows.Forms.GroupBox groupNavigate;
        private System.Windows.Forms.GroupBox groupStudent;
        private System.Windows.Forms.GroupBox groupAssignment;
        private System.Windows.Forms.Button btnReset;
    }
}

