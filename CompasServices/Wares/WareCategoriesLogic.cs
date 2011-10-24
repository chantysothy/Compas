using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

using Compas.Model;
using Compas.Helpers;


namespace Compas.Logic.Wares

{
    /// <summary>
    /// Управління довідником Категорії товарів
    /// </summary>
    public class WareCategoriesLogic : IGenericInterface<WareCategory>
    {

        private CompasDataContext context;
        private List<WareCategory> childsHierarchy;

        public WareCategoriesLogic(ContextManager contextManager)
        {
            context = contextManager.Context;
        }

        public WareCategory Get(int ID)
        {
            WareCategory result;

            result = (from a in context.WareCategories
                         where a.ID == ID
                         select a).FirstOrDefault();
            
           
            return result;
        }

        public List<WareCategory> GetAll()
        {
            List<WareCategory> result;
            //using (var cdc = new CompasDataContext())
            //{
            result = (from a in context.WareCategories                          
                          select a).ToList();
            //}
            return result;
        }

        /// <summary>
        /// Вибираємо всі дочірні підкатегорії(лише один рівень ієрархії)
        /// </summary>
        /// <param name="CategoryID"></param>
        /// <returns></returns>
        public List<WareCategory> GetAll(int? CategoryID)
        {
            List<WareCategory> result;
            //using (var cdc = new CompasDataContext())
            //{
            result = (from a in context.WareCategories
                      where (a.ParentCategoryID == CategoryID)
                      select a).ToList();
            //}
            return result;
        }

        /// <summary>
        /// Вибираємо всю ієрархію дочірніх підкатегорій(всі дочірні рівні ієрархії)
        /// </summary>
        /// <param name="CategoryID"></param>
        /// <returns></returns>
        public List<WareCategory> GetAllChilds(int CategoryID)
        {
            FillChildsHierarchy(CategoryID);
            return childsHierarchy;
        }

        

        /// <summary>
        /// Заповнюємо ієрахію childsHierarchy
        /// </summary>
        /// <returns></returns>
        private void FillChildsHierarchy(int CategoryID)
        {
            if (childsHierarchy == null)
                childsHierarchy = new List<WareCategory>();
            IEnumerable<WareCategory> childs = from a in context.WareCategories
                                               where a.ParentCategoryID == CategoryID
                                               select a;
            
            foreach (var a in childs)
            {
                childsHierarchy.Add(a);
                this.FillChildsHierarchy(a.ID);
            }
        }


        public List<WareCategory> GetAllRoot()
        {
            List<WareCategory> result;
            //using (var cdc = new CompasDataContext())
            //{
            result = (from a in context.WareCategories
                      where (a.ParentCategoryID == null)
                      select a).ToList();
            //}
            return result;
        }

        private BindingList<ItemIntValue> items = new BindingList<ItemIntValue>();
        /// <summary>
        /// Отримання ієрархічного представлення категорій
        /// </summary>
        /// <returns></returns>
        public BindingList<ItemIntValue> GetCategoriesHierarchy()
        {
            FillCategoriesHierarchy(null, "", true);
            return items;

        }

        private void FillCategoriesHierarchy(WareCategory category, string prefix, bool start)
        {
            if (start == true)
                items.Clear();
            if (items.Count == 0)
            {
                ItemIntValue none = new ItemIntValue();

                none.Name = " - не вибрано -";
                items.Add(none);
            }
            //WareCategoriesLogic categoriesLogic = new WareCategoriesLogic(manager);
            List<WareCategory> categories = new List<WareCategory>();
            if (category == null)
                categories = this.GetAllRoot();
            else
                categories = this.GetAll(category.ID);

            foreach (WareCategory a in categories)
            {
                //TreeNode node = new TreeNode(;
                //node.Text = a.Name;
                //node.
                ItemIntValue item = new ItemIntValue();
                item.ID = a.ID;
                item.Name = prefix + a.Name;
                items.Add(item);

                //CategoriesTV.Nodes.Add(a.ID.ToString(), a.Name);

                FillCategoriesHierarchy(a, prefix + a.Name + " -> ", false);
            }


        }

        

        
       

        public int Create(string Name, int? ParentCategoryID)
        {
            int result = 1;
            WareCategory sr = WareCategory.CreateWareCategory(1, Name);
            sr.ParentCategoryID = ParentCategoryID;
            context.AddToWareCategories(sr);
            return result;
        }

        public int Update(int ID, string Name, int? ParentCategoryID)
        {
            int result = 1;
            WareCategory sr = (from a in context.WareCategories
                               where a.ID == ID
                               select a).FirstOrDefault();
            sr.Name = Name;
            sr.ParentCategoryID = ParentCategoryID;
                      
            return result;
        }

        public int Delete(int ID)
        {
            int result = 1;
            WareCategory sr = (from a in context.WareCategories
                               where a.ID == ID
                               select a).FirstOrDefault();
            if (sr != null)
                context.WareCategories.DeleteObject(sr);

            return result;
        }

        
    }
}
