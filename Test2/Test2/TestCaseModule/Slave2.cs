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

namespace Test2.TestCaseModule
{
    /// <summary>
    ///The Slave2 recording.
    /// </summary>
    [TestModule("a4ed0ae3-10a6-4db4-9190-234175435b6d", ModuleType.Recording, 1)]
    public partial class Slave2 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the Test2.Test2Repository repository.
        /// </summary>
        public static Test2.Test2Repository repo = Test2.Test2Repository.Instance;

        static Slave2 instance = new Slave2();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Slave2()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Slave2 Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Down item 'MainForm.ProdListPanel' at 1;449.", repo.MainForm.ProdListPanelInfo, new RecordItemIndex(0));
            repo.MainForm.ProdListPanel.MoveTo("1;449");
            Mouse.ButtonDown(System.Windows.Forms.MouseButtons.Left);
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Up item 'EIPBuilderVshost1' at 1721;521.", repo.EIPBuilderVshost1.SelfInfo, new RecordItemIndex(1));
            repo.EIPBuilderVshost1.Self.MoveTo("1721;521");
            Mouse.ButtonUp(System.Windows.Forms.MouseButtons.Left);
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MainForm.SGDVE1CoEDrive0x10000' at 56;7.", repo.MainForm.SGDVE1CoEDrive0x10000Info, new RecordItemIndex(2));
            repo.MainForm.SGDVE1CoEDrive0x10000.Click("56;7");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'MainForm.SGDVE1CoEDrive0x10000' at 56;7.", repo.MainForm.SGDVE1CoEDrive0x10000Info, new RecordItemIndex(3));
            repo.MainForm.SGDVE1CoEDrive0x10000.DoubleClick("56;7");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MainForm.NWForm.UpDownEdit' at 39;8.", repo.MainForm.NWForm.UpDownEditInfo, new RecordItemIndex(4));
            repo.MainForm.NWForm.UpDownEdit.Click("39;8");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Back}' with focus on 'MainForm.NWForm.UpDownEdit'.", repo.MainForm.NWForm.UpDownEditInfo, new RecordItemIndex(5));
            repo.MainForm.NWForm.UpDownEdit.PressKeys("{Back}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{NumPad2}' with focus on 'MainForm.NWForm.UpDownEdit'.", repo.MainForm.NWForm.UpDownEditInfo, new RecordItemIndex(6));
            repo.MainForm.NWForm.UpDownEdit.PressKeys("{NumPad2}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MainForm.NWForm.TabPageGeneral' at 346;180.", repo.MainForm.NWForm.TabPageGeneralInfo, new RecordItemIndex(7));
            repo.MainForm.NWForm.TabPageGeneral.Click("346;180");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MainForm.NWForm.PDOMapping' at 30;12.", repo.MainForm.NWForm.PDOMappingInfo, new RecordItemIndex(8));
            repo.MainForm.NWForm.PDOMapping.Click("30;12");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Down item 'MainForm.NWForm.Position' at 8;21.", repo.MainForm.NWForm.PositionInfo, new RecordItemIndex(9));
            repo.MainForm.NWForm.Position.MoveTo("8;21");
            Mouse.ButtonDown(System.Windows.Forms.MouseButtons.Left);
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Up item 'MainForm.NWForm.Position' at 6;53.", repo.MainForm.NWForm.PositionInfo, new RecordItemIndex(10));
            repo.MainForm.NWForm.Position.MoveTo("6;53");
            Mouse.ButtonUp(System.Windows.Forms.MouseButtons.Left);
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MainForm.NWForm.NameRow12' at 14;7.", repo.MainForm.NWForm.NameRow12Info, new RecordItemIndex(11));
            repo.MainForm.NWForm.NameRow12.Click("14;7");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Down item 'MainForm.NWForm.Position1' at 9;24.", repo.MainForm.NWForm.Position1Info, new RecordItemIndex(12));
            repo.MainForm.NWForm.Position1.MoveTo("9;24");
            Mouse.ButtonDown(System.Windows.Forms.MouseButtons.Left);
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Up item 'MainForm.NWForm.Position1' at 2;49.", repo.MainForm.NWForm.Position1Info, new RecordItemIndex(13));
            repo.MainForm.NWForm.Position1.MoveTo("2;49");
            Mouse.ButtonUp(System.Windows.Forms.MouseButtons.Left);
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MainForm.NWForm.NameRow9' at 7;9.", repo.MainForm.NWForm.NameRow9Info, new RecordItemIndex(14));
            repo.MainForm.NWForm.NameRow9.Click("7;9");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Down item 'MainForm.NWForm.Position1' at 8;31.", repo.MainForm.NWForm.Position1Info, new RecordItemIndex(15));
            repo.MainForm.NWForm.Position1.MoveTo("8;31");
            Mouse.ButtonDown(System.Windows.Forms.MouseButtons.Left);
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Up item 'MainForm.NWForm.Position1' at 3;81.", repo.MainForm.NWForm.Position1Info, new RecordItemIndex(16));
            repo.MainForm.NWForm.Position1.MoveTo("3;81");
            Mouse.ButtonUp(System.Windows.Forms.MouseButtons.Left);
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MainForm.NWForm.IOMapping' at 39;10.", repo.MainForm.NWForm.IOMappingInfo, new RecordItemIndex(17));
            repo.MainForm.NWForm.IOMapping.Click("39;10");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MainForm.NWForm.SymbolRow0' at 23;7.", repo.MainForm.NWForm.SymbolRow0Info, new RecordItemIndex(18));
            repo.MainForm.NWForm.SymbolRow0.Click("23;7");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'ysw' with focus on 'MainForm.NWForm.SymbolRow0'.", repo.MainForm.NWForm.SymbolRow0Info, new RecordItemIndex(19));
            repo.MainForm.NWForm.SymbolRow0.PressKeys("ysw");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MainForm.NWForm.SymbolRow1' at 19;13.", repo.MainForm.NWForm.SymbolRow1Info, new RecordItemIndex(20));
            repo.MainForm.NWForm.SymbolRow1.Click("19;13");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'yp' with focus on 'MainForm.NWForm.SymbolRow1'.", repo.MainForm.NWForm.SymbolRow1Info, new RecordItemIndex(21));
            repo.MainForm.NWForm.SymbolRow1.PressKeys("yp");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'a' with focus on 'MainForm.NWForm.SymbolRow1'.", repo.MainForm.NWForm.SymbolRow1Info, new RecordItemIndex(22));
            repo.MainForm.NWForm.SymbolRow1.PressKeys("a");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'v' with focus on 'MainForm.NWForm.SymbolRow1'.", repo.MainForm.NWForm.SymbolRow1Info, new RecordItemIndex(23));
            repo.MainForm.NWForm.SymbolRow1.PressKeys("v");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Return}' with focus on 'MainForm.NWForm.SymbolRow1'.", repo.MainForm.NWForm.SymbolRow1Info, new RecordItemIndex(24));
            repo.MainForm.NWForm.SymbolRow1.PressKeys("{Return}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MainForm.NWForm.InitCommands' at 60;5.", repo.MainForm.NWForm.InitCommandsInfo, new RecordItemIndex(25));
            repo.MainForm.NWForm.InitCommands.Click("60;5");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MainForm.NWForm.IndexRow1' at 70;11.", repo.MainForm.NWForm.IndexRow1Info, new RecordItemIndex(26));
            repo.MainForm.NWForm.IndexRow1.Click("70;11");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Right Click item 'MainForm.NWForm.IndexRow1' at 70;11.", repo.MainForm.NWForm.IndexRow1Info, new RecordItemIndex(27));
            repo.MainForm.NWForm.IndexRow1.Click(System.Windows.Forms.MouseButtons.Right, "70;11");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MainForm.NWForm.Delete' at 53;14.", repo.MainForm.NWForm.DeleteInfo, new RecordItemIndex(28));
            repo.MainForm.NWForm.Delete.Click("53;14");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Warning.ButtonOK' at 42;11.", repo.Warning.ButtonOKInfo, new RecordItemIndex(29));
            repo.Warning.ButtonOK.Click("42;11");
            Delay.Milliseconds(200);
            
        }

#region Image Feature Data
#endregion
    }
}
