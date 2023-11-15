using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreateNodesAndLinksTableData
{
    public partial class MoveNodesToObjectEdgesForm : Form
    {
        public Boolean OkButtonSelected = false;

        public MoveNodesToObjectEdgesForm()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            OkButtonSelected = true;
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            OkButtonSelected = false;
            this.Close();
        }
    }
}
