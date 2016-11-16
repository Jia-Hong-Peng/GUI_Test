/*
 * Created by Ranorex
 * User: JAMES.PENG
 * Date: 2016/11/16
 * Time: 上午 09:59
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using System.IO;

namespace Test2.EndModule
{
    /// <summary>
    /// Description of CreateFolderModule.
    /// </summary>
    [TestModule("38C48960-7177-41A2-9BB2-2BA485678710", ModuleType.UserCode, 1)]
    public class CreateFolderModule : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public CreateFolderModule()
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
            
            string strFolder = "TestResult";
            string path = @"D:\"+strFolder;
            bool isTestFolderExist = Directory.Exists(path);
            if(!isTestFolderExist)
            {
            	Directory.CreateDirectory(path);
            }
            else
            {
            	Directory.Delete(path, true);
            	Delay.Milliseconds(100);
            	Directory.CreateDirectory(path);
            	
            }
            Delay.Milliseconds(10);
            
        }
    }
}
