using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LotteryMachine
{
    public partial class LotteryMachineMainForm : Form
    {
        public LotteryMachineMainForm()
        {
            InitializeComponent();
            


        }

        private void drawingButton_Click_1(object sender, EventArgs e)
        {
            lotteryMachineScreenControl1.StartAnimation();
        }

        private void membersButton_Click(object sender, EventArgs e)
        {
            MembersForm members = new MembersForm();
            members.Show();
        }
    }
}
