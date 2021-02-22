using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LotteryMachineControlLibrary
{
    public partial class LotteryMachineScreenControl : UserControl
    {
        private string winWord = "Win";
        private string winnerNameWord = "winner";
        private string title = "play and win";
        private Color colorFirst = Color.White;
        private Color colorSecond = Color.Red;
        // komentarz1
        public string WinWord
        {
            get
            {
                return winWord;
            }
            set
            {
                if (value.Length >= 1 && value.Length <= 10)
                {
                    winWord = value;
                }
            }
        }
        //komentarz2
        public string WinnerNameWord
        {
            get
            {
                return winnerNameWord;
            }
            //set
            //{
            //    if (value.Length >= 1 && value.Length <= 10)
            //    {
            //        winnerNameWord = value;
            //        winnerNameLabel.Text = value;
            //        winnerNameLabel.Refresh();
            //    }
            //}
        }
        //komentarz3
        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
                titleLabel.Text = value;
            }
        }
        //komentarz4
        public Color ColorFirst
        {
            get
            {
                return colorFirst;
            }
            set
            {
                colorFirst = value;
            }
        }
        //komentarz5
        public Color ColorSecond
        {
            get
            {
                return colorSecond;
            }
            set
            {
                colorSecond = value;
            }
        }

        public LotteryMachineScreenControl()
        {
            InitializeComponent();
            InitializeControl();
            titleLabel.Text = title;


        }

        //komentarz6
        private void InitializeControl()
        {
            int translation = 0;
            int panelWidth = letterSquarePanel.Width;
            for (int i = 0; i < 10; i++)
            {
                Button a = new Button();
                a.Location = new Point(translation, 15);
                a.Height = panelWidth / 10;
                a.Width = panelWidth / 10;
                a.TextAlign = ContentAlignment.MiddleCenter;
                letterSquarePanel.Controls.Add(a);
                translation += panelWidth / 10;
            }
        }
        //komentarz
        private void TranslationAnimation()
        {
            int bufor = letterSquarePanel.Controls.Count;
            for (int i = 0; i < letterSquarePanel.Controls.Count; i++)
            {

                for (int j = 0; j < bufor; j++)
                {
                    if (j >= 1)
                    {
                        letterSquarePanel.Controls[j - 1].BackColor = colorFirst;

                    }
                    letterSquarePanel.Controls[j].BackColor = colorSecond;
                    letterSquarePanel.Refresh();
                    System.Threading.Thread.Sleep(100);
                }
                bufor--;
            }
        }
        //komentarz
        private void FlashAnimation()
        {
            for (int i = 0; i < 15; i++)
            {
                int j;

                for (j = 0; j < 10; j++)
                {
                    try
                    {
                        if (i % 2 == 0)
                            letterSquarePanel.Controls[j].BackColor = colorFirst;
                        else
                            letterSquarePanel.Controls[j].BackColor = colorSecond;
                    }
                    catch
                    {
                        break;
                    }

                }
                letterSquarePanel.Refresh();
                System.Threading.Thread.Sleep(100);
                j = 0;
            }
        }
        //komentarz
        private void ShowWinnerName()
        {
            letterSquarePanel.Controls.Clear();

            int panelWidth = letterSquarePanel.Width;
            int start = (panelWidth - ((panelWidth / 10) * winWord.Length)) / 2;
            int translation = start;
            for (int i = 0; i < winWord.Length; i++)
            {
                Button a = new Button();
                a.Location = new Point(translation, 15);
                a.Height = panelWidth / 10;
                a.Width = panelWidth / 10;
                a.TextAlign = ContentAlignment.MiddleCenter;
                a.Text = char.ToUpper(winWord[i]).ToString();
                a.BackColor = colorSecond;
                a.ForeColor = colorFirst;


                letterSquarePanel.Controls.Add(a);
                translation += panelWidth / 10;
            }
        }
        //komentarz
        public void StartAnimation()
        {
            TranslationAnimation();
            FlashAnimation();
            ShowWinnerName();
            TranslationAnimation();
        }
    }
}
