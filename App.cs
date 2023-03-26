#region Namespaces
using Autodesk.Revit.ApplicationServices;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.Versioning;
using System.Windows.Markup;

#endregion

namespace RAA_Level2
{
    internal class App : IExternalApplication
    {
        public Result OnStartup(UIControlledApplication app)
        {
            // 1. Create ribbon tab
            try
            {
                app.CreateRibbonTab("RAA");
            }
            catch (Exception)
            {
                Debug.Print("Tab already exists.");
            }

            // 2. Create ribbon panel 
            RibbonPanel panel = Utils.CreateRibbonPanel(app, "RAA", "Setup Tools");
            RibbonPanel panel2 = Utils.CreateRibbonPanel(app, "RAA", "Project Tools");

            // 3. Create button data instances
            //Panel 1
            ButtonDataClass myButtonData  = new ButtonDataClass("btn_RAA_Levels", "Level Setup", Command.GetMethod(), Properties.Resources.Excel_32, Properties.Resources.Create_16, "Levels from a List");
            ButtonDataClass myButtonData2 = new ButtonDataClass("btn_RAA_Module1Bonus", "Excel Setup", Command2.GetMethod(), Properties.Resources.Excel_32, Properties.Resources.Create_16, "Make Views and Sheets from a List");
            ButtonDataClass myButtonData3 = new ButtonDataClass("btn_RAA_Module1", "CSV Setup", Command.GetMethod(), Properties.Resources.Excel_32, Properties.Resources.Create_16, "Make Views and Sheets from a List");
            ButtonDataClass myButtonData5 = new ButtonDataClass("btn_RAA_SheetMaker", "Make Sheets", CommandSheetMaker.GetMethod(), Properties.Resources.Create_32, Properties.Resources.Create_16, "Make Sheets from a Dialog Box");
            //Panel 2
            ButtonDataClass myButtonData10 = new ButtonDataClass("btn_RAA_MaterialMaker", "Make Pattern", CommandMaterial.GetMethod(), Properties.Resources.Create_32, Properties.Resources.Create_16, "Create a Pattern from Lines");
            ButtonDataClass myButtonData11 = new ButtonDataClass("btn_RAA_Renumbering", "Renumber Views", CommandRenumber.GetMethod(), Properties.Resources.Create_32, Properties.Resources.Create_16, "Renumber Views on a Sheet");
            //Split Button
            SplitButtonData sbData1 = new SplitButtonData("splitButton1", "V&S");

            // 4. Create buttons
            //Panel 1
            PushButton myButton1 = panel.AddItem(myButtonData.Data) as PushButton; //Levels
            SplitButton sb1 = panel.AddItem(sbData1) as SplitButton;
                sb1.AddPushButton(myButtonData2.Data); //XLS
                sb1.AddPushButton(myButtonData3.Data); //CSV
            PushButton myButton5 = panel.AddItem(myButtonData5.Data) as PushButton; //Make Sheets
            //Panel 2
            PushButton myButton10 = panel2.AddItem(myButtonData10.Data) as PushButton;  //Materials
            PushButton myButton11 = panel2.AddItem(myButtonData11.Data) as PushButton;  //Renumber Views



            return Result.Succeeded;
        }

        public Result OnShutdown(UIControlledApplication a)
        {
            return Result.Succeeded;
        }


    }
}
