using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using com.rusanu.dataconnectiondialog;

namespace CompanyStructure
{
    public partial class StartScreenView : Form
    {
        private StartScreenViewModel _startScreenViewModel;
        public StartScreenView()
        {
            InitializeComponent();
            _startScreenViewModel = new StartScreenViewModel();
        }

        private void btnChooseServer_Click(object sender, EventArgs e)
        {
            DataConnectionDialog dlg = new DataConnectionDialog(_startScreenViewModel.GetSqlConnectionStringBuilder());
            if (DialogResult.OK == dlg.ShowDialog())
            {
                //Use the connection properties
                //using (SqlConnection conn = new SqlConnection(dlg.ConnectionStringBuilder.ConnectionString))
                //{
                //    _startScreenViewModel.SaveConnectionString()
                //}
                using (SqlConnection conn = new SqlConnection(dlg.ConnectionStringBuilder.ConnectionString))
                {
                    _startScreenViewModel.SaveConnectionString(conn.ConnectionString);
                    if (!_startScreenViewModel.HasDatabase())
                    {
                        //_startScreenViewModel.SaveConnectionString(conn.ConnectionString);
                        dlg.ConnectionStringBuilder.InitialCatalog = _startScreenViewModel.GenerateDb();
                        _startScreenViewModel.SaveConnectionString(dlg.ConnectionStringBuilder.ConnectionString);
                        _startScreenViewModel.GenerateTables();
                    }
                    dlg.ConnectionStringBuilder.InitialCatalog = _startScreenViewModel.GenerateDb();
                    _startScreenViewModel.SaveConnectionString(dlg.ConnectionStringBuilder.ConnectionString);

                }
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            using (StructureOverlayView structureOverlayView = new StructureOverlayView(new Logic.LogicSystem()))
            {
                structureOverlayView.ShowDialog();
            }
        }
    }
}
