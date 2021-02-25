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
    public partial class MembersForm : Form
    {
        int choosenPersonId = 0;
        CreateFormDirector createFormDirector = new CreateFormDirector();
        public MembersForm()
        {
            InitializeComponent();
        }

        private void addMemberButton_Click(object sender, EventArgs e)
        {
            createFormDirector.Builder = new AddMemberFormConcreteBuilder();
            AddMemberForm addMemberForm = new AddMemberForm(createFormDirector);
            addMemberForm.Show();

        }

        private void editMemberButton_Click(object sender, EventArgs e)
        {
            createFormDirector.Builder = new EditMemberFormConcreteBuilder(choosenPersonId);
            AddMemberForm addMemberForm = new AddMemberForm(createFormDirector);
            addMemberForm.Show();
        }
    }
}
