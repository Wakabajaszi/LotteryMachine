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
    public partial class AddMemberForm : Form
    {
        private ILanguages language;
        CreateFormDirector createFormDirector;
        public AddMemberForm(CreateFormDirector createFormDirector , ILanguages language)
        {
            this.language = language;
            this.createFormDirector = createFormDirector;
            InitializeComponent();
            FormSettings();
            ChangeFormLangauge();
        }
        private void FormSettings() 
        {
            nameTextBox.Text = createFormDirector.Builder.selectName();
            surnameTextBox.Text = createFormDirector.Builder.selectSurname();
            sexComboBox.SelectedIndex = createFormDirector.Builder.selectSex();
            cityTextBox.Text = createFormDirector.Builder.selectCity();
            adressTextBox.Text = createFormDirector.Builder.selectAdress();
            postcodeTextBox.Text = createFormDirector.Builder.selectPostCode();
        }
        private void ChangeFormLangauge() 
        {
            nameLabel.Text = language.nameLabel();
            surnameLabel.Text = language.surnameLabeL();
            sexLabel.Text = language.sexLabel();
            adressLabel.Text = language.AdressLabel();
            cityLabel.Text = language.CityLabel();
            postcodeLabel.Text = language.PostCodeLabel();
            sexComboBox.Items.Clear();
            sexComboBox.Items.AddRange(language.sexComboBoxValue());
            sexComboBox.SelectedIndex = 0;
        }
    }
}
