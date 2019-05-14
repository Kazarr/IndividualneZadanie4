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
    public partial class EmployeeView : Form
    {
        private EmployeeViewModel _employeeViewModel;
        public EmployeeView(LogicSystem logic, Employee employee, object dataSource)
        {
            InitializeComponent();
            _employeeViewModel = new EmployeeViewModel(logic, employee);
            txtName.Text = _employeeViewModel.Employee.Name;
            txtSurname.Text = _employeeViewModel.Employee.SurName;
            txtDegree.Text = _employeeViewModel.Employee.Degree;
            txtPhone.Text = _employeeViewModel.Employee.Phone.ToString();
            txtMail.Text = _employeeViewModel.Employee.Mail;
            cmbWorkingDepartment.DataSource = dataSource;
            cmbWorkingDepartment.SelectedIndex = cmbWorkingDepartment.FindStringExact(_employeeViewModel.GetEmployeeDepartment().CompanyName);
        }
        public EmployeeView(LogicSystem logic)
        {
            InitializeComponent();
            _employeeViewModel = new EmployeeViewModel(logic);
            cmbWorkingDepartment.DataSource = _employeeViewModel.GetDepartments();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            _employeeViewModel.Employee.Name = txtName.Text;
            _employeeViewModel.Employee.SurName = txtSurname.Text;
            _employeeViewModel.Employee.Degree = txtDegree.Text;
            _employeeViewModel.Employee.Phone = int.Parse(txtPhone.Text);
            _employeeViewModel.Employee.Mail = txtMail.Text;
            GridCompany temp = (GridCompany)cmbWorkingDepartment.SelectedValue;
            _employeeViewModel.Employee.DepartmentId = temp==null ? null : temp.Id;
            _employeeViewModel.SaveEmployee();
        }
    }
}
