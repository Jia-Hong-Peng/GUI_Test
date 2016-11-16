/*
 * Created by Ranorex
 * User: JAMES.PENG
 * Date: 2016/11/16
 * Time: 下午 04:06
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

namespace Test2.InitModule
{
    /// <summary>
    /// Description of KillProcess.
    /// </summary>
    [TestModule("A897E195-5050-4950-9E7B-06C77B0CC516", ModuleType.UserCode, 1)]
    public class KillProcess : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public KillProcess()
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
            
            var repo = InitRepository.Instance;
            var visualStudioMainWindow = repo.VisualStudioMainWindow;
            string strProcessesVs2013 = "devenv";
            string strProcessesEcatDebug = "EIP Builder.vshost";
            string strProcessesEcatRelease = "EIP Builder";
                        
            while(CheckProcessExist(strProcessesVs2013))
            {
            	KillTheProcess(strProcessesVs2013);
            	Delay.Milliseconds(500);
            }
            
            while(CheckProcessExist(strProcessesEcatDebug))
            {
            	KillTheProcess(strProcessesEcatDebug);
            	Delay.Milliseconds(500);
            }
                        
            while(CheckProcessExist(strProcessesEcatRelease))
            {
            	KillTheProcess(strProcessesEcatRelease);
            	Delay.Milliseconds(500);
            }
        }
        
        public static void KillTheProcess(string ProcessesName)
        {
            System.Diagnostics.Process[] processes = System.Diagnostics.Process.GetProcessesByName(ProcessesName);
            foreach (System.Diagnostics.Process process in processes)
            {
                process.Kill();
            }
        }
        
        public static bool CheckProcessExist(string ProcessesName)
        {
        	System.Diagnostics.Process[] processes = System.Diagnostics.Process.GetProcessesByName(ProcessesName);
        	if(processes.Length == 0)
        		return false;
        	else
        		return true;
        }
    }
}
