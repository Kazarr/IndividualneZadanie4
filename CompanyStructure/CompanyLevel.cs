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
    public partial class CompanyLevel : Form
    {
        private CompanyLevelViewModel _companyLevelViewModel;
        public CompanyLevel(LogicSystem logic)
        {
            InitializeComponent();
            _companyLevelViewModel = new CompanyLevelViewModel(logic);
            grdCompanies.DataSource = _companyLevelViewModel.GetCompanies();
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            using(StructureOverlay overlay = new StructureOverlay(_companyLevelViewModel.LogicSystem, grdCompanies.CurrentRow.Index))
            {
                overlay.ShowDialog();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using(NewCompany company = new NewCompany())
            {
                company.ShowDialog();
                if(company.DialogResult == DialogResult.OK)
                {

                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
