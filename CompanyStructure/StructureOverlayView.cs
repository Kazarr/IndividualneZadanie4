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
        public StructureOverlayView(LogicSystem logic, int selectedId)
        {
            InitializeComponent();
            _structureOverLayViewModel = new StructureOverLayViewModel(logic, selectedId);
            
            grdDivisions.DataSource = _structureOverLayViewModel.GetSelectedCompanyDepartment(selectedId);
            grdProjects.DataSource = _structureOverLayViewModel.GetSelectedCompanyDepartment((int)grdDivisions.Rows[0].Cells[0].Value);
            grdDepartments.DataSource = _structureOverLayViewModel.GetSelectedCompanyDepartment((int)grdProjects.Rows[0].Cells[0].Value);
            //grdDepartmentEmployees.DataSource = _structureOverLayViewModel.GetEmployess((int)grdDepartments.Rows[0].Cells[0].Value);
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            using (EmployeeView employee = new EmployeeView())
            {
                employee.ShowDialog();
                if(employee.DialogResult == DialogResult.OK)
                {

                }
            }
        }

        private void btnEditEmployee_Click(object sender, EventArgs e)
        {
            using (EmployeeView employee = new EmployeeView())
            {
                employee.ShowDialog();
                if (employee.DialogResult == DialogResult.OK)
                {

                }
            }
        }

        private void btnDelEmployee_Click(object sender, EventArgs e)
        {

        }

        private void btnAddStructure_Click(object sender, EventArgs e)
        {
            using (StructureView structure = new StructureView())
            {
                structure.ShowDialog();
                if (structure.DialogResult == DialogResult.OK)
                {

                }
            }

        }

        private void btnEditStructure_Click(object sender, EventArgs e)
        {
            using (StructureView structure = new StructureView())
            {
                structure.ShowDialog();
                if (structure.DialogResult == DialogResult.OK)
                {

                }
            }
        }

        private void btnGuiHeirarchy_Click(object sender, EventArgs e)
        {

        }
    }
}
