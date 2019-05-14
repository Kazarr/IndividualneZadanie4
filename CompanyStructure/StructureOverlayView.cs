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
            _structureOverLayViewModel.DeleteEmployee();
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
