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

        private ILanguages language; 

        public LotteryMachineMainForm()
        {
            InitializeComponent();
            language = new PolishLanguage();
            chooseLanguageComboBox.Items.AddRange(language.chooseLngCbValue());
            chooseLanguageComboBox.Text = language.chooseLngComboBoxText();
            ChangeFormLangauge();

        }

        private void drawingButton_Click_1(object sender, EventArgs e)
        { 
            lotteryMachineScreenControl1.InitializeControl();
            lotteryMachineScreenControl1.WinnerName = "";
            lotteryMachineScreenControl1.StartAnimation();
            Winner();
        }

        private void membersButton_Click(object sender, EventArgs e)
        {
            try
            {
                MembersForm members = new MembersForm(language);
                members.Show();
            }
            catch 
            {
                MessageBox.Show(language.conectionError(), "Error");
            }
        }

        private void chooseLangaugeButton_Click(object sender, EventArgs e)
        {
            if (chooseLanguageComboBox.SelectedIndex == 0)
            {
                language = new PolishLanguage();
                chooseLanguageComboBox.Text = language.chooseLngComboBoxText(); ;
            }
            else if (chooseLanguageComboBox.SelectedIndex == 1)
            {
                language = new EnglishLanguage();
                chooseLanguageComboBox.Text = language.chooseLngComboBoxText(); ;
            }
            ChangeFormLangauge();
        }

        private void ChangeFormLangauge()
        {
            chooseLanguageComboBox.Items.Clear();
            chooseLanguageComboBox.Items.AddRange(language.chooseLngCbValue());
            titleLabel.Text = language.Title();
            chooseLangaugeButton.Text = language.chooseLngButton();
            drawingButton.Text = language.StartButton();
            membersButton.Text = language.membersButton();
            lotteryMachineScreenControl1.Title = language.LotteryMachineTitle();
            lotteryMachineScreenControl1.WinWord = language.winNameWord();
        }

        private void Winner() 
        {
            try
            {
                MemberService.MemberServiceClient serviceClient = new MemberService.MemberServiceClient();
                var members = serviceClient.GetAllMembers();
                var winner = members.OrderBy(r => Guid.NewGuid()).Take(1).First();
                lotteryMachineScreenControl1.WinnerName = $"{winner.Name} {winner.Surname}";
            }
            catch
            {
                MessageBox.Show(language.conectionError(), "Error");
            }


        }
    }
}
