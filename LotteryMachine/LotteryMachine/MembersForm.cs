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
        MemberService.MemberServiceClient serviceClient = new MemberService.MemberServiceClient();
        int choosenPersonId = 0;
        CreateFormDirector createFormDirector = new CreateFormDirector();
        private ILanguages language;
        public MembersForm(ILanguages language)
        {
            this.language = language;
            InitializeComponent();
            ChangeFormLangauge();
        }

        private void addMemberButton_Click(object sender, EventArgs e)
        {
            createFormDirector.Builder = new AddMemberFormConcreteBuilder();
            AddMemberForm addMemberForm = new AddMemberForm(createFormDirector, language);
            addMemberForm.Show();

        }

        private void editMemberButton_Click(object sender, EventArgs e)
        {
            createFormDirector.Builder = new EditMemberFormConcreteBuilder(choosenPersonId);
            AddMemberForm addMemberForm = new AddMemberForm(createFormDirector, language);
            addMemberForm.Show();
        }
        private void ChangeFormLangauge()
        {
            findLabel.Text = language.findLabel();
            nameLabel.Text = language.nameLabel();
            surnameLabel.Text = language.surnameLabeL();
            addMemberButton.Text = language.addButton();
            editMemberButton.Text = language.editButton();
            deleteMemberButton.Text = language.deleteButton();
            optionsLabel.Text = language.optionsLabel();
        }
    }
    class test
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
    }
}
