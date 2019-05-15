using Logic;
using Logic.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompanyStructure
{
    public partial class StructureOverlayView : Form
    {
        private StructureOverLayViewModel _structureOverLayViewModel;
        private LogicSystem _logicSystem;
        public StructureOverlayView(LogicSystem logic)
        {
            InitializeComponent();
            _structureOverLayViewModel = new StructureOverLayViewModel(logic);
            _logicSystem = logic;
            grdCompanies.DataSource = _structureOverLayViewModel.GetCompanies();
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            using (EmployeeView employee = new EmployeeView(_structureOverLayViewModel.LogicSystem))
            {
                employee.ShowDialog();
                if(employee.DialogResult == DialogResult.OK)
                {

                }
            }
        }

        public bool HasNode(TreeNode node)
        {
            bool ret = false;
            foreach(TreeNode subNode in treeStructure.Nodes)
            {
                if (subNode == node)
                {
                    ret = true;
                    return ret;
                }
                ret = HasNode(subNode);
            }
            return ret;
        }

        public void KardyRefreshTree(TreeNode node)
        {
            if (!HasNode(node))
            {
                treeStructure.Nodes.Add(node);
                Refresh(node, _structureOverLayViewModel.ChildDepartments);
            }
            treeStructure.ExpandAll();
        }

        private void Refresh(TreeNode parent, List<Department> zoznam)
        {
            foreach (var item in zoznam)
            {
                TreeNode node = new TreeNode(item.Name);
                parent.Nodes.Add(node);
                Refresh(node, _structureOverLayViewModel.GetDepartmentByParent(item.Id));
            }           
        }

        //public void KardyRefreshTree(TreeNode node)
        //{

        //    //_structureOverLayViewModel.ChildDepartments = _structureOverLayViewModel.GetDepartmentByParent(_structureOverLayViewModel.DepartmentId);
        //    //_structureOverLayViewModel.GetDepartmentByParent(_structureOverLayViewModel.DepartmentId);
        //    if (!HasNode(node))
        //    {
        //        treeStructure.Nodes.Add(node);
        //        //node.Nodes.Add(new TreeNode());
        //        //treenode.Nodes.Add(new TreeNode());
        //        for (int i = 0; i < _structureOverLayViewModel.ChildDepartments.Count; i++)
        //        {
        //            //node.Nodes.
        //            //node.Nodes.Add(node.Nodes[i]);
        //            //_structureOverLayViewModel.ToTreeDepartments.Push(_structureOverLayViewModel.ChildDepartments[i]);
        //            TreeNode treeNode = new TreeNode(_structureOverLayViewModel.ChildDepartments[i].Name);
        //            node.Nodes.Add(treeNode);
        //            //RefreshTree(node.Nodes[i]);

        //            for (int j = 0; j < _structureOverLayViewModel.GetDepartmentByParent(_structureOverLayViewModel.ChildDepartments[i].Id).Count; j++)
        //            {
        //                //node.Nodes.
        //                //node.Nodes.Add(node.Nodes[i]);
        //                //_structureOverLayViewModel.ToTreeDepartments.Push(_structureOverLayViewModel.ChildDepartments[i]);
        //                TreeNode treeNodeNode = new TreeNode(_structureOverLayViewModel.GetDepartmentByParent(_structureOverLayViewModel.ChildDepartments[i].Id)[j].Name);
        //                treeNode.Nodes.Add(treeNodeNode);
        //                //RefreshTree(node.Nodes[i]);
        //            }
        //        }
        //    }
        //    //for (int i = 0; i < _structureOverLayViewModel.ToTreeDepartments.Count; i++)
        //    //{

        //    //}
        //    if (_structureOverLayViewModel.ToTreeDepartments.Count > 0)
        //    {
        //        _structureOverLayViewModel.ChildDepartments = _structureOverLayViewModel.GetDepartmentByParent(_structureOverLayViewModel.ToTreeDepartments.Peek().Id);
        //        TreeNode treeNode = new TreeNode(_structureOverLayViewModel.ToTreeDepartments.Pop().Name);
        //        node.Nodes.Add(treeNode);

        //       // KardyRefreshTree(treeNode);
        //    }

        //}

        private void btnEditEmployee_Click(object sender, EventArgs e)
        {
            using (EmployeeView employee = new EmployeeView(_structureOverLayViewModel.LogicSystem, _structureOverLayViewModel.Employee, grdDepartments.DataSource))
            {
                employee.ShowDialog();
                if (employee.DialogResult == DialogResult.OK)
                {
                }
            }
        }

        private void btnDelEmployee_Click(object sender, EventArgs e)
        {
            if (!_structureOverLayViewModel.IsCheif())
            {
                _structureOverLayViewModel.DeleteEmployee();
            }
            else
            {
                MessageBox.Show("You cant delete cheif employee. Change cheif employee first");
            }
        }

        private void btnAddStructure_Click(object sender, EventArgs e)
        {
            using (StructureView structure = new StructureView(_logicSystem))
            {
                structure.ShowDialog();
                if (structure.DialogResult == DialogResult.OK)
                {

                }
            }

        }

        private void btnEditStructure_Click(object sender, EventArgs e)
        {
            using (StructureView structure = new StructureView(_logicSystem, _structureOverLayViewModel.DepartmentId))
            {
                structure.ShowDialog();
                if (structure.DialogResult == DialogResult.OK)
                {

                }
            }
        }

        private void btnDelStructure_Click(object sender, EventArgs e)
        {
            //_structureOverLayViewModel.
        }

        private void btnGuiHeirarchy_Click(object sender, EventArgs e)
        {
            treeStructure.Nodes.Clear();
            TreeNode node = new TreeNode(_structureOverLayViewModel.GetSeletedDepartment());
            //treeStructure.Nodes.Add(node);
            KardyRefreshTree(node);
        }

        private void grdCompanies_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            grdDivisions.Rows.Clear();
            grdProjects.Rows.Clear();
            grdDepartments.Rows.Clear();
            grdDepartmentEmployees.Rows.Clear();
            grdDivisions.DataSource = _structureOverLayViewModel.GetSelectedCompanyDepartment((int)grdCompanies.Rows[e.RowIndex].Cells[0].Value);
            _structureOverLayViewModel.DepartmentId = (int)grdCompanies.Rows[e.RowIndex].Cells[0].Value;
            
        }

        private void grdDivisions_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            grdProjects.Rows.Clear();
            grdDepartments.Rows.Clear();
            grdDepartmentEmployees.Rows.Clear();
            grdProjects.DataSource = _structureOverLayViewModel.GetSelectedCompanyDepartment((int)grdDivisions.Rows[e.RowIndex].Cells[0].Value);
            _structureOverLayViewModel.DepartmentId = (int)grdDivisions.Rows[e.RowIndex].Cells[0].Value;
        }

        private void grdProjects_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            grdDepartments.Rows.Clear();
            grdDepartmentEmployees.Rows.Clear();
            grdDepartments.DataSource = _structureOverLayViewModel.GetSelectedCompanyDepartment((int)grdProjects.Rows[e.RowIndex].Cells[0].Value);
            _structureOverLayViewModel.DepartmentId = (int)grdProjects.Rows[e.RowIndex].Cells[0].Value;
        }

        private void grdDepartments_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            grdDepartmentEmployees.Rows.Clear();
            grdDepartmentEmployees.DataSource = _structureOverLayViewModel.GetSelectedDepartmentEmployees((int)grdDepartments.Rows[e.RowIndex].Cells[0].Value);
            _structureOverLayViewModel.DepartmentId = (int)grdDepartments.Rows[e.RowIndex].Cells[0].Value;
        }

        private void grdDepartmentEmployees_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            _structureOverLayViewModel.Employee = (Employee)grdDepartmentEmployees.Rows[e.RowIndex].DataBoundItem;
        }


    }
}
