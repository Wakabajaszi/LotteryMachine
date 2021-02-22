namespace LotteryMachineControlLibrary
{
    partial class LotteryMachineScreenControl
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

        #region Kod wygenerowany przez Projektanta składników

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.titleLabel = new System.Windows.Forms.Label();
            this.letterSquarePanel = new System.Windows.Forms.Label();
            this.winnerNameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.BackColor = System.Drawing.Color.LightBlue;
            this.titleLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.titleLabel.Location = new System.Drawing.Point(0, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(300, 52);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Play and Win";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // letterSquarePanel
            // 
            this.letterSquarePanel.BackColor = System.Drawing.Color.LightBlue;
            this.letterSquarePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.letterSquarePanel.ForeColor = System.Drawing.Color.Black;
            this.letterSquarePanel.Location = new System.Drawing.Point(0, 52);
            this.letterSquarePanel.Name = "letterSquarePanel";
            this.letterSquarePanel.Size = new System.Drawing.Size(300, 52);
            this.letterSquarePanel.TabIndex = 1;
            this.letterSquarePanel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // winnerNameLabel
            // 
            this.winnerNameLabel.BackColor = System.Drawing.Color.LightBlue;
            this.winnerNameLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.winnerNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.winnerNameLabel.Location = new System.Drawing.Point(0, 104);
            this.winnerNameLabel.Name = "winnerNameLabel";
            this.winnerNameLabel.Size = new System.Drawing.Size(300, 58);
            this.winnerNameLabel.TabIndex = 2;
            this.winnerNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LotteryMachineScreenControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.winnerNameLabel);
            this.Controls.Add(this.letterSquarePanel);
            this.Controls.Add(this.titleLabel);
            this.Name = "LotteryMachineScreenControl";
            this.Size = new System.Drawing.Size(300, 162);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label letterSquarePanel;
        private System.Windows.Forms.Label winnerNameLabel;
    }
}
