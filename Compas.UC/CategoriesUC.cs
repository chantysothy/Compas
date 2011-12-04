using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Compas.Model;
using Compas.Logic;
using Compas.Helpers;

namespace Compas.UC
{
    
    public partial class CategoriesUC : UserControl
    {
        ContextManager manager;
        private int? _currentSelectedCategoryId;
        private Mode _currentMode;
        public enum Mode  {TreeView, Button};

        public event EventHandler SelectedCategoryChanged;
        //ImageList imagesList;

        //режим відображення
        public Mode ViewMode
        {
            get 
            {
                if (_currentMode == null)
                    _currentMode = Mode.TreeView;
                return _currentMode;
            }
            set
            {
                _currentMode = value;
            }
        }


        public int? SelectedCategoryID
        {
            get
            {
                int? result = null;
                switch (ViewMode)
                {
                    case Mode.TreeView:
                        {
                            if (CategoriesTV.SelectedNode != null)
                            {
                                result = Convert.ToInt32(CategoriesTV.SelectedNode.Tag);
                            }
                            break;
                        }
                    case Mode.Button:
                        {
                            result = _currentSelectedCategoryId;
                            break;                         
                        }
                }
                return result;
            }
        }


        public void ExpandAll()
        {
            CategoriesTV.ExpandAll();
        }


        public void ScrollUp()
        {
            if (CategoriesTV.TopNode.PrevNode != null)
                CategoriesTV.TopNode = CategoriesTV.TopNode.PrevNode;
            else
                if (CategoriesTV.TopNode.Parent != null)
                    CategoriesTV.TopNode = CategoriesTV.TopNode.Parent;
        }

        public void ScrollDown()
        {
            ScrollNode(CategoriesTV.TopNode);
        }
        private void ScrollNode(TreeNode node)
        {
            if(CategoriesTV.TopNode.NextNode != null)
                CategoriesTV.TopNode = node.NextNode;
            else
                CategoriesTV.TopNode = node;
            CategoriesTV.Refresh();
            System.Threading.Thread.Sleep(50);
            if (node.IsExpanded)
            {
                foreach (TreeNode subNode in node.Nodes)
                    ScrollNode(subNode);
            }
        }

       
        

        public void Fill(int? ParentCategoryID, TreeNode ParentNode)
        {
            Logic.Wares.WareCategoriesLogic categoriesLogic = new Logic.Wares.WareCategoriesLogic(manager);
            List<WareCategory> categories = new List<WareCategory>();
            if (ParentCategoryID == null)
                categories = categoriesLogic.GetAllRoot();
            else
                categories = categoriesLogic.GetAll(Convert.ToInt32(ParentCategoryID));

            //if(imagesList  == null)
            //    imagesList = new ImageList();


            foreach (WareCategory category in categories)
            {
                
                TreeNode node = new TreeNode();
                node.Name = category.Name;
                node.Text = category.Name;
                node.Tag = category.ID.ToString();
                
                if (category.Image != null)
                {
                    imageList1.Images.Add(category.ID.ToString(), Helpers.ImageOperations.ByteArrayToImage(category.Image));
                    node.ImageIndex = imageList1.Images.Count - 1;
                }
                //if (ParentCategoryID == null)
                //{
                //    CategoriesTV.Nodes.Add(node);
                //}
                //else
                {
                    ParentNode.Nodes.Add(node);
                }
                Fill(category.ID, node);
            }
        }

        public void Fill()
        {
            CategoriesTV.Nodes.Clear();
            TreeNode node = new TreeNode();
            node.Name = "ALL";
            node.Text = "Всі";
            node.Tag = "-1";            

            CategoriesTV.Nodes.Add(node);

            manager = new ContextManager();
            Fill(null, node);

            switch (this.ViewMode)
            {
                case Mode.TreeView:
                    {
                        CategoriesTV.Visible = true;
                        CategoriesFLP.Visible = false;
                        break;
                    }
                case Mode.Button:
                    {
                        CategoriesFLP.Dock = DockStyle.Fill;
                        Button newButton = new Button();
                        newButton.Name = node.Tag.ToString();                        
                        newButton.Text = node.Text;
                        newButton.TextImageRelation = TextImageRelation.ImageAboveText;
                        newButton.AutoSize = true;
                        newButton.Width = CategoriesFLP.Width - 15;
                        newButton.Click += new EventHandler(newButton_Click);
                        CategoriesFLP.SetFlowBreak(newButton, true);
                        CategoriesFLP.Controls.Add(newButton);

                        CategoriesFLP.Visible = true;
                        CategoriesTV.Visible = false;
                        break;
                    }
            }


        }


        private void CreateButton(string Name, string Text, Image ButtonImage)
        {
            Button newButton = new Button();
            newButton.Name = Name;
            if (ButtonImage != null)
            {

                newButton.Image = Helpers.ImageOperations.ScaleImage(ButtonImage, null, newButton.Font.Height * 5);
            }
            newButton.Text = Text;
            newButton.TextImageRelation = TextImageRelation.ImageAboveText;
            newButton.Height = newButton.Font.Height * (5 + 2);
            newButton.Width = CategoriesFLP.Width - 20;
            newButton.Dock = DockStyle.Top;
            //newButton.Click += new EventHandler(newButton_Click);
            newButton.Click += this.HandleSelectedCategoryChanged;
            CategoriesFLP.SetFlowBreak(newButton, true);
            CategoriesFLP.Controls.Add(newButton);
        }

        private void FillButtons(int? ParentCategoryID)
        {

            Logic.Wares.WareCategoriesLogic categoriesLogic = new Logic.Wares.WareCategoriesLogic(manager);
            var childCategories = categoriesLogic.GetAll(ParentCategoryID);
            this.CreateButton("-1", "Всі категорії", null);
            foreach (var c in childCategories)
            {                
                this.CreateButton(c.ID.ToString(), c.Name, Helpers.ImageOperations.ByteArrayToImage(c.Image));
            }
        }


       
        

        private void newButton_Click(object sender, EventArgs e)
        {
            CategoriesFLP.Controls.Clear();
            //визначаємо категорію            
            
            int? categoryId = null;
            if (((Button)sender).Name != "-1")
                categoryId = Convert.ToInt32(((Button)sender).Name);
            _currentSelectedCategoryId = categoryId;
            this.FillButtons(categoryId);
            

        }

        public CategoriesUC()
        {
            InitializeComponent();
            

            CategoriesTV.AfterSelect += this.HandleSelectedCategoryChanged;
        }

        private void CategoriesTV_AfterSelect(object sender, TreeViewEventArgs e)
        {
           
        }

        private void HandleSelectedCategoryChanged(object sender, EventArgs e)
        {
            if (ViewMode == Mode.Button)
            {
                CategoriesFLP.Controls.Clear();
                //визначаємо категорію            

                int? categoryId = null;
                if (((Button)sender).Name != "-1")
                    categoryId = Convert.ToInt32(((Button)sender).Name);
                _currentSelectedCategoryId = categoryId;
                this.FillButtons(categoryId);
            }
            this.OnSelectedCategoryChanged(EventArgs.Empty);
            
        }

        protected virtual void OnSelectedCategoryChanged(EventArgs e)
        {
            EventHandler handler = this.SelectedCategoryChanged;
            if (handler != null)
            {
                handler(this, e);
            }
        }
    }
}
