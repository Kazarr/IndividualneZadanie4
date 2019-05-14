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
    public partial class StructureView : Form
    {
        private StructureViewModel _structureViewModel;
        private LogicSystem _logicSystem;
        public StructureView(LogicSystem logic, int departmentId)
        {
            InitializeComponent();
            btnOk.Visible = true;
            btnAdd.Visible = false;
            _logicSystem = logic;

            _structureViewModel = new StructureViewModel(logic, departmentId);
            txtDepartmentName.Text = _structureViewModel.GetDepartmentName();
            cmbCheifEmployee.DataSource = _structureViewModel.GetAllEmployees();
            cmbCheifEmployee.SelectedIndex = cmbCheifEmployee.FindStringExact(_structureViewModel.GetCheifEmployee(_structureViewModel.Department.Id).ToString());
            cmbDepartmentType.DataSource = _structureViewModel.GetDepartmentTypes();
            cmbDepartmentType.SelectedIndex = cmbDepartmentType.FindStringExact(_structureViewModel.GetDepartmentByType(_structureViewModel.Department.Id).ToString());

            cmbParentDepartment.DataSource = _structureViewModel.GetCompanyDivisionProject(cmbDepartmentType.SelectedIndex);
        }
        public StructureView(LogicSystem logic)
        {
            InitializeComponent();
            
            _logicSystem = logic;
            btnOk.Visible = false;
            btnAdd.Visible = true;
            _structureViewModel = new StructureViewModel(logic);
            cmbCheifEmployee.DataSource = _structureViewModel.GetAllEmployees();
            cmbDepartmentType.DataSource = _structureViewModel.GetDepartmentTypes();

            cmbParentDepartment.DataSource = _structureViewModel.GetCompanyDivisionProject(cmbDepartmentType.SelectedIndex);
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            _structureViewModel.Department.Name = txtDepartmentName.Text;
            DepartmentType tempDepartmentType = (DepartmentType)cmbDepartmentType.SelectedItem;
            _structureViewModel.Department.DepartmentType = tempDepartmentType.Id;
            Employee tempEmployee = (Employee)cmbCheifEmployee.SelectedItem;
            _structureViewModel.Department.CheifEmployeeId = tempEmployee == null ? null : tempEmployee.Id;
            Department tempGridCompany = (Department)cmbParentDepartment.SelectedItem;
            _structureViewModel.Department.ParentDeparment = tempGridCompany == null ? null : tempGridCompany.Id;
            _structureViewModel.UpdateDepartment();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _structureViewModel.Department.Name = txtDepartmentName.Text;
            DepartmentType tempDepartmentType = (DepartmentType)cmbDepartmentType.SelectedItem;
            _structureViewModel.Department.DepartmentType = tempDepartmentType.Id;
            Employee tempEmployee = (Employee)cmbCheifEmployee.SelectedItem;
            _structureViewModel.Department.CheifEmployeeId = tempEmployee==null ? null : tempEmployee.Id;
            Department tempGridCompany = (Department)cmbParentDepartment.SelectedItem;
            _structureViewModel.Department.ParentDeparment = tempGridCompany==null ? null : tempGridCompany.Id;
            _structureViewModel.SaveDepartment();
        }

        private void cmbDepartmentType_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbParentDepartment.DataSource = _structureViewModel.GetCompanyDivisionProject(cmbDepartmentType.SelectedIndex);
        }

        private void cmbCheifEmployee_Validating(object sender, CancelEventArgs e)
        {
            if(cmbCheifEmployee.SelectedItem == null)
            {
                btnAdd.Enabled = false;
                btnOk.Enabled = false;
            }
            else
            {
                btnAdd.Enabled = true;
                btnOk.Enabled = true;
            }
        }
    }
}
