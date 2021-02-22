
using LotteryMachineControlLibrary;

namespace LotteryMachine
{
    partial class LotteryMachineMainForm
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.titleLabel = new System.Windows.Forms.Label();
            this.leftWallLabel = new System.Windows.Forms.Label();
            this.rightWallLabel = new System.Windows.Forms.Label();
            this.drawingButton = new System.Windows.Forms.Button();
            this.membersButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.chooseLanguageComboBox = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lotteryMachineScreenControl1 = new LotteryMachineControlLibrary.LotteryMachineScreenControl();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.BackColor = System.Drawing.Color.Teal;
            this.titleLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(0, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(500, 57);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Lottery Machine";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // leftWallLabel
            // 
            this.leftWallLabel.BackColor = System.Drawing.Color.CadetBlue;
            this.leftWallLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftWallLabel.Location = new System.Drawing.Point(0, 57);
            this.leftWallLabel.Name = "leftWallLabel";
            this.leftWallLabel.Size = new System.Drawing.Size(100, 414);
            this.leftWallLabel.TabIndex = 1;
            // 
            // rightWallLabel
            // 
            this.rightWallLabel.BackColor = System.Drawing.Color.CadetBlue;
            this.rightWallLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.rightWallLabel.Location = new System.Drawing.Point(400, 57);
            this.rightWallLabel.Name = "rightWallLabel";
            this.rightWallLabel.Size = new System.Drawing.Size(100, 414);
            this.rightWallLabel.TabIndex = 2;
            // 
            // drawingButton
            // 
            this.drawingButton.BackColor = System.Drawing.Color.CadetBlue;
            this.drawingButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.drawingButton.ForeColor = System.Drawing.Color.Black;
            this.drawingButton.Location = new System.Drawing.Point(106, 293);
            this.drawingButton.Name = "drawingButton";
            this.drawingButton.Size = new System.Drawing.Size(122, 38);
            this.drawingButton.TabIndex = 3;
            this.drawingButton.Text = "Draw";
            this.drawingButton.UseVisualStyleBackColor = false;
            this.drawingButton.Click += new System.EventHandler(this.drawingButton_Click_1);
            // 
            // membersButton
            // 
            this.membersButton.BackColor = System.Drawing.Color.CadetBlue;
            this.membersButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.membersButton.Location = new System.Drawing.Point(189, 358);
            this.membersButton.Name = "membersButton";
            this.membersButton.Size = new System.Drawing.Size(122, 38);
            this.membersButton.TabIndex = 5;
            this.membersButton.Text = "Members";
            this.membersButton.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.CadetBlue;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.Location = new System.Drawing.Point(189, 402);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 38);
            this.button2.TabIndex = 6;
            this.button2.Text = "Winners";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // chooseLanguageComboBox
            // 
            this.chooseLanguageComboBox.FormattingEnabled = true;
            this.chooseLanguageComboBox.Items.AddRange(new object[] {
            "english",
            "polish"});
            this.chooseLanguageComboBox.Location = new System.Drawing.Point(257, 293);
            this.chooseLanguageComboBox.Name = "chooseLanguageComboBox";
            this.chooseLanguageComboBox.Size = new System.Drawing.Size(121, 21);
            this.chooseLanguageComboBox.TabIndex = 7;
            this.chooseLanguageComboBox.Text = "choose language";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lotteryMachineScreenControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(100, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 202);
            this.panel1.TabIndex = 4;
            // 
            // lotteryMachineScreenControl1
            // 
            this.lotteryMachineScreenControl1.ColorFirst = System.Drawing.Color.White;
            this.lotteryMachineScreenControl1.ColorSecond = System.Drawing.Color.Red;
            this.lotteryMachineScreenControl1.Location = new System.Drawing.Point(0, 0);
            this.lotteryMachineScreenControl1.Name = "lotteryMachineScreenControl1";
            this.lotteryMachineScreenControl1.Size = new System.Drawing.Size(300, 162);
            this.lotteryMachineScreenControl1.TabIndex = 0;
            this.lotteryMachineScreenControl1.Title = "play and win";
            this.lotteryMachineScreenControl1.WinWord = "Winner";
            // 
            // LotteryMachineMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(500, 471);
            this.Controls.Add(this.chooseLanguageComboBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.membersButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.drawingButton);
            this.Controls.Add(this.rightWallLabel);
            this.Controls.Add(this.leftWallLabel);
            this.Controls.Add(this.titleLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "LotteryMachineMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LotteryMachine";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label leftWallLabel;
        private System.Windows.Forms.Label rightWallLabel;
        private System.Windows.Forms.Button drawingButton;
        private System.Windows.Forms.Button membersButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox chooseLanguageComboBox;
        private System.Windows.Forms.Panel panel1;
        private LotteryMachineScreenControl lotteryMachineScreenControl1;
    }
}

