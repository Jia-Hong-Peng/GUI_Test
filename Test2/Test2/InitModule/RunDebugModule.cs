﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

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
using Ranorex.Core.Repository;

namespace Test2.InitModule
{
    /// <summary>
    ///The RunDebugModule recording.
    /// </summary>
    [TestModule("2d3aebd1-890d-47bb-b25d-473175b08da6", ModuleType.Recording, 1)]
    public partial class RunDebugModule : ITestModule
    {
        /// <summary>
        /// Holds an instance of the Test2.Test2Repository repository.
        /// </summary>
        public static Test2.Test2Repository repo = Test2.Test2Repository.Instance;

        static RunDebugModule instance = new RunDebugModule();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public RunDebugModule()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static RunDebugModule Instance
        {
            get { return instance; }
        }

#region Variables

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "5.0.2")]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "5.0.2")]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.0;

            Init();

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'VisualStudioMainWindow.PARTFocusTarget' at 36;11.", repo.VisualStudioMainWindow.PARTFocusTargetInfo, new RecordItemIndex(0));
            repo.VisualStudioMainWindow.PARTFocusTarget.Click("36;11");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MainForm.ECATBuilder' at 1756;12.", repo.MainForm.ECATBuilderInfo, new RecordItemIndex(1));
            repo.MainForm.ECATBuilder.Click("1756;12");
            Delay.Milliseconds(200);
            
        }

#region Image Feature Data
#endregion
    }
}