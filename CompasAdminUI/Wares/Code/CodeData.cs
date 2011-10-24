using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Compas.Model;
using Compas.Logic;
using Compas.Logic.Wares;

namespace Compas.AdminUI.Wares.Code
{
    public partial class CodeData : Form
    {
        string mode;

        int? id;
        ContextManager manager;
        Model.Ware ware;

        public CodeData(Model.Ware _Ware, ContextManager Manager)
        {
            manager = Manager;
            ware = _Ware;
            InitializeComponent();
        }

        private void SaveBt_Click(object sender, EventArgs e)
        {
            WareCodesLogic codes = new WareCodesLogic(manager);
            codes.Create(ware, CodeTB.Text);
        }
    }
}
