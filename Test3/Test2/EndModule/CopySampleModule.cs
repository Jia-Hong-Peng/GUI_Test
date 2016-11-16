/*
 * Created by Ranorex
 * User: JAMES.PENG
 * Date: 2016/11/16
 * Time: 上午 10:19
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

namespace Test2.EndModule
{
    /// <summary>
    /// Description of CopySampleModule.
    /// </summary>
    [TestModule("0C064D7B-0EFC-4203-9EF9-96B9F96FC491", ModuleType.UserCode, 1)]
    public class CopySampleModule : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public CopySampleModule()
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
            
            string source = @"D:\GuiTest\tect case\3\my3.xml";
            string target = @"D:\TestResult\my3.xml";
            
            try
            {
            	System.IO.File.Copy(source,target);
            }
            catch
            {            
            }
            
        }
    }
}
