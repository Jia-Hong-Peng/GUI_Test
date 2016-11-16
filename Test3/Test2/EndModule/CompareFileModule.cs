/*
 * Created by Ranorex
 * User: JAMES.PENG
 * Date: 2016/11/16
 * Time: 上午 10:33
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;

namespace Test2.EndModule
{
    /// <summary>
    /// Description of CompareFileModule.
    /// </summary>
    [TestModule("8621FFF0-FDCF-4BB3-9C1E-2F5EAB699011", ModuleType.UserCode, 1)]
    public class CompareFileModule : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public CompareFileModule()
        {
            // Do not delete - a parameterless constructor is required!
        }

        /// <summary>
        /// Performs the playback of actions in this module.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.0;
            
            string file1 = @"D:\TestResult\Test3.xml";
            string file2 = @"D:\TestResult\my3.xml";
            Validate.AreEqual(FileCompare(file1,file2),true,"File comparison",true);  
        }
        
        private bool FileCompare(string file1, string file2)
		{
		     int file1byte;
		     int file2byte;
		     FileStream fs1;
		     FileStream fs2;
		
		     // Determine if the same file was referenced two times.
		     if (file1 == file2)
		     {
		          // Return true to indicate that the files are the same.
		          return true;
		     }
		
		     // Open the two files.
		     fs1 = new FileStream(file1, FileMode.Open, FileAccess.Read);
		     fs2 = new FileStream(file2, FileMode.Open, FileAccess.Read);
		
		     // Check the file sizes. If they are not the same, the files 
		        // are not the same.
		     if (fs1.Length != fs2.Length)
		     {
		          // Close the file
		          fs1.Close();
		          fs2.Close();
		
		          // Return false to indicate files are different
		          return false;
		     }
		
		     // Read and compare a byte from each file until either a
		     // non-matching set of bytes is found or until the end of
		     // file1 is reached.
		     do 
		     {
		          // Read one byte from each file.
		          file1byte = fs1.ReadByte();
		          file2byte = fs2.ReadByte();
		     }
		     while ((file1byte == file2byte) && (file1byte != -1));
		
		     // Close the files.
		     fs1.Close();
		     fs2.Close();
		
		     // Return the success of the comparison. "file1byte" is 
		     // equal to "file2byte" at this point only if the files are 
		     // the same.
		     return ((file1byte - file2byte) == 0);
		}
    }
}
