using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;
using System.ComponentModel;

namespace Assignment3.Classes
{
    /// <summary>
    /// File class.
    /// </summary>
    internal class clsFile
    {
        /// <summary>
        /// Name string passed from UI
        /// </summary>
        private string name;
        /// <summary>
        /// Score string passed from UI
        /// </summary>
        private string scoreboard;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="name"></param>
        public clsFile() 
        {
            try
            {
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Public setter for the number of Student Assignments
        /// </summary>
        public string Scoreboard
        {
            set { scoreboard = value; }
        }
        /// <summary>
        /// Public setter for file name
        /// </summary>
        public string Name
        {
            set { name = value; }
        }
        /// <summary>
        /// Creates a text file containing the Student Assignments and Scores
        /// As long as the file name doesn't already exist, creates a file using the user entered file name
        /// </summary>
        /// <param name="name"></param>
        public void CreateFile()
        {
            try
            {
                Thread.Sleep(2000);
                
                string fileName = @"C:\Users\Public\" + name + ".txt";

                // Check if file already exists
                if (File.Exists(fileName))
                {
                    throw new Exception("Cannot output file. This file name already exists.");
                }
                else
                {
                    using (StreamWriter sw = new StreamWriter(fileName))
                    {
                        sw.Write(scoreboard);
                    }

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
