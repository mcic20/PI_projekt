using Student_Mobility_Handler.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Mobility_Handler
{
    public partial class FrmAcceptedFinalRecommends : Form
    {
        public FrmAcceptedFinalRecommends()
        {
            InitializeComponent();
            FinalChoiceRepository finalChoiceRepository = new FinalChoiceRepository();
            dgvFinalChoices.DataSource = finalChoiceRepository.GetFinalChoiceList();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }
    }
}
