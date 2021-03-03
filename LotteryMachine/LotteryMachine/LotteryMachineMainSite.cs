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
            lotteryMachineScreenControl1.StartAnimation();
        }

        private void membersButton_Click(object sender, EventArgs e)
        {
            MembersForm members = new MembersForm(language);
            members.Show();
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
            winnersButton.Text = language.ShowWinnersButton();
            lotteryMachineScreenControl1.Title = language.LotteryMachineTitle();
            lotteryMachineScreenControl1.WinWord = language.winNameWord();
        }
    }
}
