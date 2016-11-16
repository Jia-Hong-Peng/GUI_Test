/*
 * Created by Ranorex
 * User: JAMES.PENG
 * Date: 2016/11/15
 * Time: 下午 03:00
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
    [TestModule("0C6A5938-1ABF-401E-86D4-B5F45276AA32", ModuleType.UserCode, 1)]
    public class OpenVisualStudio2013 : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public OpenVisualStudio2013()
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
           	Report.Log(ReportLevel.Info, "Application", "Run application 'D:\\DeltaGit\\ECAT\\DeltaIABG.sln' with arguments '' in normal mode.", new RecordItemIndex(0));
            Host.Local.RunApplication("D:\\DeltaGit\\ECAT\\DeltaIABG.sln", "", "D:\\DeltaGit\\ECAT", false);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 15s.", new RecordItemIndex(1));
            Delay.Duration(15000, false);
        }
    }
}
