/*
 * Created by Ranorex
 * User: JAMES.PENG
 * Date: 2016/11/15
 * Time: 下午 03:11
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

namespace Test2
{
    /// <summary>
    /// Description of UserCodeModule1.
    /// </summary>
    [TestModule("D2D0273A-A41B-49AF-8583-5A5AA34EC3FE", ModuleType.UserCode, 1)]
    public class DeleteEcatSaveFile : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public DeleteEcatSaveFile()
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
        	try
        	{
        		System.IO.Directory.Delete(@"C:\ProgramData\Delta Industrial Automation\ISPSoft\Project\Untitled0_ECAT",true);
        	}
        	catch
        	{
        		
        	}
        	
        	Delay.Milliseconds(100);
        }
    }
}
