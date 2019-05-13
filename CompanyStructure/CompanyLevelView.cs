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
    public partial class CompanyLevelView : Form
    {
        private CompanyLevelViewModel _companyLevelViewModel;
        public CompanyLevelView(LogicSystem logic)
        {
            InitializeComponent();
            _companyLevelViewModel = new CompanyLevelViewModel(logic);
            grdCompanies.DataSource = _companyLevelViewModel.GetCompanies();
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            using(StructureOverlayView overlay = new StructureOverlayView(_companyLevelViewModel.LogicSystem, (int)grdCompanies.Rows[grdCompanies.CurrentRow.Index].Cells[0].Value))
            {
                overlay.ShowDialog();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using(NewCompanyView company = new NewCompanyView())
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
