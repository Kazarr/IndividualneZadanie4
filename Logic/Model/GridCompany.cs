using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logic.Model
{
    public class GridCompany:TreeNode
    {
        //public GridCompany(string v, GridCompany[] array)
        //{
        //    TreeNode t = new TreeNode("text",array);
        //}

        public string CompanyName { get; set; }
        public string CheifName { get; set; }
        public string CheifSurname { get; set; }

        public override string ToString()
        {
            return Text = CompanyName;
        }
    }
}
