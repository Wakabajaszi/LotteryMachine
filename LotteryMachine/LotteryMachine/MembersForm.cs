﻿using System;
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
    public partial class MembersForm : Form, IObserver
    {
        int choosenPersonId;
        
        MemberService.MemberServiceClient serviceClient = new MemberService.MemberServiceClient();
        CreateFormDirector createFormDirector = new CreateFormDirector();
        private ILanguages language;

        public MembersForm(ILanguages language)
        {
            this.language = language;
            InitializeComponent();
            ChangeFormLangauge();
            LoadData();
        }
        private void LoadData() 
        {
            
            {
                var members = serviceClient.GetAllMembers();
                if(members.Count() != 0) 
                {
                    membersBindingSource.DataSource = members.Select(p => new { p.Id, p.Name, p.Surname }).ToList();
                    dataGridView1.DataSource = membersBindingSource;
                    choosenPersonId = members.FirstOrDefault().Id;
                }
               
            }
           
        }
        private void addMemberButton_Click(object sender, EventArgs e)
        {
            createFormDirector.Builder = new AddMemberFormConcreteBuilder();
            AddMemberForm addMemberForm = new AddMemberForm(createFormDirector, language, this);
            addMemberForm.Show();

        }
        private void editMemberButton_Click(object sender, EventArgs e)
        {
            createFormDirector.Builder = new EditMemberFormConcreteBuilder(choosenPersonId);
            AddMemberForm addMemberForm = new AddMemberForm(createFormDirector, language, this);
            addMemberForm.Show();
        }
        private void deleteMemberButton_Click(object sender, EventArgs e)
        {
            var  member = serviceClient.GetMemberById(choosenPersonId);
            var memberName = $"{member.Name} {member.Surname}";
            DialogResult dialogResult = MessageBox.Show($"{language.deleteMessege()} {memberName}", $"{language.deleteButton()}", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                serviceClient.DeleteMember(choosenPersonId);
                LoadData();
            }
            else if (dialogResult == DialogResult.No)
            {

            }
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (choosenPersonId != 0)
            {
                editMemberButton.Enabled = true;
                deleteMemberButton.Enabled = true;
            }
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            choosenPersonId = Int32.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            var members = serviceClient.GetAllMembers();
            var find = (from cz in members
                        where cz.Name.Contains(nameTextBox.Text)
                        where cz.Surname.Contains(surnameTextBox.Text)
                        orderby cz.Surname
                        select cz);
          
            membersBindingSource.DataSource = find.Select(p => new { p.Id, p.Name, p.Surname }).ToList();
            dataGridView1.DataSource = membersBindingSource;
            dataGridView1.Refresh();
        }

        public void Reaction()
        {
            LoadData();
        }
    }
  
}
