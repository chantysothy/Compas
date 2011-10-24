using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using Compas.Model;
using Compas.Helpers;


namespace Compas.Logic.Staff

{

    public class StructureObjectView
    {
        private int id;
        private string name;
        private bool allowServices;
        private bool active;

        public int ID
        { get { return id; } set { id = value; } }

        public string Name
        { get { return name; } set { name = value; } }

        public bool AllowServices
        { get { return allowServices; } set { allowServices = value; } }

        public bool Active
        { get { return active; } set { active = value; } }

    }

    public class StaffStructureObjectsLogic : IGenericInterface<StaffStructureObject>
    {


        private CompasDataContext context;
        private List<StaffStructureObject> allStructureObjects;


        public StaffStructureObjectsLogic(ContextManager contextManager)
        {
            context = contextManager.Context;
            RefreshAllStructureObjects();
        }

        public void RefreshAllStructureObjects()
        {
            allStructureObjects = (from a in context.StaffStructureObjects
                                   select a).ToList();
        }

        public BindingList<StructureObjectView> GetHeirarchyView()
        {
            BindingList<StructureObjectView> result = new BindingList<StructureObjectView>();
            foreach (var a in this.GetStructureObjectsHierarchy(false))
            {
                StructureObjectView so = new StructureObjectView();
                so.ID = a.ID;
                so.Name = a.Name;
                StaffStructureObject so2 = this.Get(a.ID);
                so.AllowServices = so2.AllowServices;
                so.Active = so2.Active;
                result.Add(so);

            }
            return result;
        }


        public StaffStructureObject Get(int ID)
        {
            StaffStructureObject result;

            result = (from a in allStructureObjects
                         where a.ID == ID
                         select a).FirstOrDefault();
            
           
            return result;
        }

        public List<StaffStructureObject> GetByParentStructureObjectID(int StructureObjectID)
        {
            List<StaffStructureObject> result;
            //using (var cdc = new CompasDataContext())
            //{
            result = (from a in allStructureObjects
                      where a.ParentStructureObjectID == StructureObjectID
                      select a).ToList();
            //}
            return result;
        }

        public List<StaffStructureObject> GetAll()
        {
            List<StaffStructureObject> result;
            //using (var cdc = new CompasDataContext())
            //{
            result = (from a in allStructureObjects                          
                          select a).ToList();
            //}
            return result;
        }

        public List<StaffStructureObject> GetAllRoot()
        {
            List<StaffStructureObject> result;
            //using (var cdc = new CompasDataContext())
            //{
            result = (from a in context.StaffStructureObjects
                      where (a.ParentStructureObjectID == null)
                      select a).ToList();
            //}
            return result;
        }


        private BindingList<ItemIntValue> items = new BindingList<ItemIntValue>();
        /// <summary>
        /// Отримання ієрархічного представлення об'єктів
        /// </summary>
        /// <returns></returns>
        public BindingList<ItemIntValue> GetStructureObjectsHierarchy(bool IncludeNone)
        {
            FillStructureObjectsHierarchy(IncludeNone, null, "", true);
            return items;

        }

        /// <summary>
        /// Отримання ієрархічного представлення об'єктів(від вказаного об'єкта)
        /// </summary>
        /// <returns></returns>
        public BindingList<ItemIntValue> GetStructureObjectsHierarchy(bool IncludeNone, int StructureObjectID)
        {

            FillStructureObjectsHierarchy(IncludeNone, this.Get(StructureObjectID), "", true);
            return items;

        }

        /// <summary>
        /// ієрархія об'єктів(в текстовій формі)
        /// </summary>
        /// <returns></returns>
        private List<ItemIntValue> FillStructureObjectsHierarchy(bool IncludeNone)
        {
            List<ItemIntValue> list = new List<ItemIntValue>();
            if (IncludeNone == true)
            {
                ItemIntValue none = new ItemIntValue();
                //none.ID = -1;
                none.Name = "- не вибрано -";
                list.Add(none);
            }
            
            
            list.AddRange(this.GetStructureObjectsHierarchy(IncludeNone).Select(a => a));
            return list;
            
        }

        private void FillStructureObjectsHierarchy(bool IncludeNone, StaffStructureObject structureObject, string prefix, bool start)
        {

            if (start == true)
                items.Clear();
            if ((items.Count == 0) & (IncludeNone == true))
            {

                ItemIntValue none = new ItemIntValue();

                none.Name = "- не вибрано -";
                items.Add(none);
            }
            //WareCategoriesLogic categoriesLogic = new WareCategoriesLogic(manager);
            //CompasLogger.Add(String.Format("Start Fill ToObjects Hierarchy"), CompasLogger.Level.Info);
            List<StaffStructureObject> structureObjects = new List<StaffStructureObject>();
            if (structureObject == null)
            {
                
                structureObjects = this.GetAllRoot();
            }
            else
                structureObjects = this.GetByParentStructureObjectID(structureObject.ID);

            foreach (StaffStructureObject a in structureObjects)
            {
                //TreeNode node = new TreeNode(;
                //node.Text = a.Name;
                //node.
                ItemIntValue item = new ItemIntValue();
                item.ID = a.ID;
                item.Name = prefix + a.Name;
                items.Add(item);

                //CategoriesTV.Nodes.Add(a.ID.ToString(), a.Name);

                FillStructureObjectsHierarchy(IncludeNone,a, prefix.Replace("->", "  ")  + /*a.Name +*/ "   -> ", false);
            }

            //CompasLogger.Add(String.Format("END Fill ToObjects Hierarchy"), CompasLogger.Level.Info);


        }

        public int Create(string Name, bool AllowServices, bool Active,  int? StructureObjectID)
        {
            int result = 1;
            StaffStructureObject sr = StaffStructureObject.CreateStaffStructureObject(1, Name, AllowServices, Active);
            
            sr.ParentStructureObjectID = StructureObjectID;
            context.AddToStaffStructureObjects(sr);
            return result;
        }

        public int Update(int ID, string Name, bool AllowServices, bool Active, int? StructureObjectID)
        {
            int result = 1;
            StaffStructureObject sr = (from a in context.StaffStructureObjects
                               where a.ID == ID
                               select a).FirstOrDefault();
            sr.Name = Name;
            sr.AllowServices = AllowServices;
            sr.Active = Active;
            
            sr.ParentStructureObjectID = StructureObjectID;
           

            return result;
        }

        public int Delete(int ID)
        {
            int result = 1;
            StaffStructureObject sr = (from a in context.StaffStructureObjects
                               where a.ID == ID
                               select a).FirstOrDefault();
            if (sr != null)
                context.StaffStructureObjects.DeleteObject(sr);

            return result;
        }

        
    }
}
