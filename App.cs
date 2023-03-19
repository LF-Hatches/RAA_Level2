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
            RibbonPanel panel = Utils.CreateRibbonPanel(app, "RAA", "Revit Tools");

            // 3. Create button data instances
            ButtonDataClass myButtonData = new ButtonDataClass("btn_RAA_Module1", "CSV Setup", Command.GetMethod(), Properties.Resources.Excel_32, Properties.Resources.Create_16, "This is a tooltip");
            ButtonDataClass myButtonData2 = new ButtonDataClass("btn_RAA_Module1Bonus", "Excel Setup", Command2.GetMethod(), Properties.Resources.Excel_32, Properties.Resources.Create_16, "This is a tooltip");
            ButtonDataClass myButtonData3 = new ButtonDataClass("btn_RAA_MaterialMaker", "Make Pattern", CommandMaterial.GetMethod(), Properties.Resources.Create_32, Properties.Resources.Create_16, "This is a tooltip");

            // 4. Create buttons
            PushButton myButton = panel.AddItem(myButtonData.Data) as PushButton;
            PushButton myButton2 = panel.AddItem(myButtonData2.Data) as PushButton; 
            PushButton myButton3 = panel.AddItem(myButtonData3.Data) as PushButton;

            return Result.Succeeded;
        }

        public Result OnShutdown(UIControlledApplication a)
        {
            return Result.Succeeded;
        }


    }
}
