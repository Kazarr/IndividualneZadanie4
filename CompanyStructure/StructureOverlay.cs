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
    public partial class StructureOverlay : Form
    {
        private StructureOverLayViewModel _structureOverLayViewModel;
        public StructureOverlay(LogicSystem logic, int selectedId)
        {
            InitializeComponent();
            _structureOverLayViewModel = new StructureOverLayViewModel(logic);
            _structureOverLayViewModel.LogicSystem = logic;
            grdDepartmentEmployees.DataSource = _structureOverLayViewModel.GetSelectedCompanyDepartment();
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            using (Employee employee = new Employee())
            {
                employee.ShowDialog();
                if(employee.DialogResult == DialogResult.OK)
                {

                }
            }
        }

        private void btnEditEmployee_Click(object sender, EventArgs e)
        {
            using (Employee employee = new Employee())
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
            using (Structure structure = new Structure())
            {
                structure.ShowDialog();
                if (structure.DialogResult == DialogResult.OK)
                {

                }
            }

        }

        private void btnEditStructure_Click(object sender, EventArgs e)
        {
            using (Structure structure = new Structure())
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
