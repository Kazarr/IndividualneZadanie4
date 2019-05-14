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
    public partial class NewCompanyView : Form
    {
        private NewCompanyViewModel _newCompanyViewModel;
        public NewCompanyView()
        {
            InitializeComponent();
            _newCompanyViewModel = new NewCompanyViewModel();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            _newCompanyViewModel.NewCompany(txtCompanyName.Text);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
