using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LotteryMachine
{
    public interface ILangeugeWinnersForm
    {
        string conectionError();
    }
    public interface ILangagueLotteryMachineController
    {

        string winNameWord();
        string LotteryMachineTitle();
    }
    public interface ILanguageAddMemberForm
    {
        //AddMemberForm
        string sexLabel();
        string[] sexComboBoxValue();
        string chooseMessege();
    }
    public interface ILanguageMembers
    {
        //Members
        string findLabel();
        string optionsLabel();
        string nameLabel();
        string surnameLabeL();
        string addButton();
        string editButton();
        string deleteButton();
        string deleteMessege();
    }
    public interface ILangaugeMainSite
    {

        string Title();
        string StartButton();
        string membersButton();
        string ShowWinnersButton();
        string chooseLngComboBoxText();
        string chooseLngButton();
        string[] chooseLngCbValue();

    }

    public interface ILanguages : ILangaugeMainSite, ILanguageMembers, ILanguageAddMemberForm,
        ILangagueLotteryMachineController, ILangeugeWinnersForm
    {
    }
    class PolishLanguage : ILanguages
    {

        public string addButton()
        {
            return "Dodaj";
        }

        public string chooseLngButton()
        {
            return "Zmień";
        }

        public string[] chooseLngCbValue()
        {
            string[] languages = { "polski", "angielski" };
            return languages;
        }

        public string chooseLngComboBoxText()
        {

            return "Zmień język";
        }

        public string chooseMessege()
        {
            return "Musisz wprowadzić dane";
        }

        public string conectionError()
        {
            return "Błąd połączenia z serwerem";
        }

        public string deleteButton()
        {
            return "Usuń";
        }

        public string deleteMessege()
        {
            return "Czy na pewno chcesz usunąć";
        }

        public string editButton()
        {
            return "Edytuj";
        }

        public string findLabel()
        {
            return "Znajdź";
        }

        public string LotteryMachineTitle()
        {
            return "Graj Wygrywaj";
        }

        public string membersButton()
        {
            return "Uczestnicy";
        }

        public string nameLabel()
        {
            return "Imię";
        }



        public string optionsLabel()
        {
            return "Opcje";
        }

        public string[] sexComboBoxValue()
        {
            string[] plec = { "wybierz", "mężczyzna", "kobieta" };
            return plec;
        }

        public string sexLabel()
        {
            return "Płeć";
        }

        public string ShowWinnersButton()
        {
            return "Zwycięzcy";
        }

        public string StartButton()
        {
            return "Losuj";
        }

        public string surnameLabeL()
        {
            return "Nazwisko";
        }

        public string Title()
        {
            return "Jednoręki Bandyta";
        }

        public string winNameWord()
        {
            return "Wygrał";
        }


    }
    class EnglishLanguage : ILanguages //adaptowana klasa
    {
        public string addButton()
        {
            return "Add";
        }

        public string chooseLngButton()
        {
            return "Choose";
        }

        public string[] chooseLngCbValue()
        {
            string[] languages = { "polish", "english" };
            return languages;
        }

        public string chooseLngComboBoxText()
        {
            return "change language";
        }

        public string chooseMessege()
        {
            return "You must insert values";
        }

        public string conectionError()
        {
            return "connection fail";
        }

        public string deleteButton()
        {
            return "Delete";
        }

        public string deleteMessege()
        {
            return "Do you want delete";
        }

        public string editButton()
        {
            return "Edit";
        }

        public string findLabel()
        {
            return "Find";
        }

        public string LotteryMachineTitle()
        {
            return "Play and Win";
        }

        public string membersButton()
        {
            return "Members";
        }

        public string nameLabel()
        {
            return "name";
        }


        public string optionsLabel()
        {
            return "Options";
        }

        public string[] sexComboBoxValue()
        {
            string[] sex = { "choose", "man", "woman" };
            return sex;
        }

        public string sexLabel()
        {
            return "sex";
        }

        public string ShowWinnersButton()
        {
            return "Winners";
        }

        public string StartButton()
        {
            return "Start";
        }

        public string surnameLabeL()
        {
            return "surname";
        }

        public string Title()
        {
            return "One Hand Bandit";
        }

        public string winNameWord()
        {
            return "Winner";
        }


    }
    
}
