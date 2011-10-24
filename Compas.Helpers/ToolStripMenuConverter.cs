using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;

namespace Compas.Helpers
{
    public class ToolStripConverter
    {
        static public ContextMenu ToContextMenu(ToolStrip Menu)
        {




            ContextMenu newMenu = new ContextMenu();
            foreach (ToolStripItem a in Menu.Items)
            {
                //MenuItem mi = new MenuItem();
                //mi.Text = a.Text;
                ////копіюємо обробник події Click
                //string commonField;

                //FieldInfo fi = null;
                //Type typeControl = a.GetType();
                
                //string fields = "";
                //foreach (FieldInfo f in typeControl.GetFields(BindingFlags.InvokeMethod | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance))
                //{                    
                //    fields = fields + f.Name + ";   ";
                //}

                ////while (typeControl != typeof(System.Object))
                ////{
                ////    fi = typeControl.GetField("onClick",BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
                ////    if (fi != null) break;

                ////    typeControl = typeControl.BaseType;
                ////    fields = fields + fi.Name + ";   ";
                ////}
                //MessageBox.Show(fields);
                //if (fi == null) new ArgumentException("commonField");

                //Delegate source = fi.GetValue(a) as Delegate;
                //fi.SetValue(mi, source);
                //newMenu.MenuItems.Add(mi);
            }
            return newMenu;
        }
    }
}
