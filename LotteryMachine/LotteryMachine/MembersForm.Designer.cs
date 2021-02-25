
namespace LotteryMachine
{
    partial class MembersForm
    {
      

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.titleLabel = new System.Windows.Forms.Label();
            this.leftWallLabel = new System.Windows.Forms.Label();
            this.findLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.surnameLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.SurnameTextBox = new System.Windows.Forms.TextBox();
            this.optionsLabel = new System.Windows.Forms.Label();
            this.addMemberButton = new System.Windows.Forms.Button();
            this.editMemberButton = new System.Windows.Forms.Button();
            this.deleteMemberButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.membersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Names = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.membersBindingSource)).BeginInit();
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
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "Lottery Machine";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // leftWallLabel
            // 
            this.leftWallLabel.BackColor = System.Drawing.Color.CadetBlue;
            this.leftWallLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftWallLabel.Location = new System.Drawing.Point(0, 57);
            this.leftWallLabel.Name = "leftWallLabel";
            this.leftWallLabel.Size = new System.Drawing.Size(234, 414);
            this.leftWallLabel.TabIndex = 2;
            // 
            // findLabel
            // 
            this.findLabel.BackColor = System.Drawing.Color.LemonChiffon;
            this.findLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.findLabel.Location = new System.Drawing.Point(25, 79);
            this.findLabel.Name = "findLabel";
            this.findLabel.Size = new System.Drawing.Size(181, 35);
            this.findLabel.TabIndex = 3;
            this.findLabel.Text = "Find";
            this.findLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nameLabel
            // 
            this.nameLabel.BackColor = System.Drawing.Color.LemonChiffon;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nameLabel.Location = new System.Drawing.Point(14, 129);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(62, 23);
            this.nameLabel.TabIndex = 4;
            this.nameLabel.Text = "Name";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // surnameLabel
            // 
            this.surnameLabel.BackColor = System.Drawing.Color.LemonChiffon;
            this.surnameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.surnameLabel.Location = new System.Drawing.Point(14, 178);
            this.surnameLabel.Name = "surnameLabel";
            this.surnameLabel.Size = new System.Drawing.Size(95, 23);
            this.surnameLabel.TabIndex = 5;
            this.surnameLabel.Text = "Surname";
            this.surnameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(29, 155);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(114, 20);
            this.nameTextBox.TabIndex = 6;
            // 
            // SurnameTextBox
            // 
            this.SurnameTextBox.Location = new System.Drawing.Point(29, 204);
            this.SurnameTextBox.Name = "SurnameTextBox";
            this.SurnameTextBox.Size = new System.Drawing.Size(114, 20);
            this.SurnameTextBox.TabIndex = 7;
            // 
            // optionsLabel
            // 
            this.optionsLabel.BackColor = System.Drawing.Color.LemonChiffon;
            this.optionsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.optionsLabel.Location = new System.Drawing.Point(25, 253);
            this.optionsLabel.Name = "optionsLabel";
            this.optionsLabel.Size = new System.Drawing.Size(181, 35);
            this.optionsLabel.TabIndex = 8;
            this.optionsLabel.Text = "Options";
            this.optionsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addMemberButton
            // 
            this.addMemberButton.BackColor = System.Drawing.Color.LemonChiffon;
            this.addMemberButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addMemberButton.ForeColor = System.Drawing.Color.Black;
            this.addMemberButton.Location = new System.Drawing.Point(12, 328);
            this.addMemberButton.Name = "addMemberButton";
            this.addMemberButton.Size = new System.Drawing.Size(92, 35);
            this.addMemberButton.TabIndex = 9;
            this.addMemberButton.Text = "Add";
            this.addMemberButton.UseVisualStyleBackColor = false;
            this.addMemberButton.Click += new System.EventHandler(this.addMemberButton_Click);
            // 
            // editMemberButton
            // 
            this.editMemberButton.BackColor = System.Drawing.Color.LemonChiffon;
            this.editMemberButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.editMemberButton.ForeColor = System.Drawing.Color.Black;
            this.editMemberButton.Location = new System.Drawing.Point(124, 328);
            this.editMemberButton.Name = "editMemberButton";
            this.editMemberButton.Size = new System.Drawing.Size(92, 35);
            this.editMemberButton.TabIndex = 10;
            this.editMemberButton.Text = "Edit";
            this.editMemberButton.UseVisualStyleBackColor = false;
            this.editMemberButton.Click += new System.EventHandler(this.editMemberButton_Click);
            // 
            // deleteMemberButton
            // 
            this.deleteMemberButton.BackColor = System.Drawing.Color.LemonChiffon;
            this.deleteMemberButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.deleteMemberButton.ForeColor = System.Drawing.Color.Black;
            this.deleteMemberButton.Location = new System.Drawing.Point(70, 384);
            this.deleteMemberButton.Name = "deleteMemberButton";
            this.deleteMemberButton.Size = new System.Drawing.Size(92, 35);
            this.deleteMemberButton.TabIndex = 11;
            this.deleteMemberButton.Text = "Delete";
            this.deleteMemberButton.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Names,
            this.Surname});
            this.dataGridView1.DataSource = this.membersBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(234, 57);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(266, 414);
            this.dataGridView1.TabIndex = 12;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Width = 30;
            // 
            // Names
            // 
            this.Names.HeaderText = "Name";
            this.Names.Name = "Names";
            this.Names.Width = 93;
            // 
            // Surname
            // 
            this.Surname.HeaderText = "Surname";
            this.Surname.Name = "Surname";
            // 
            // MembersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 471);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.deleteMemberButton);
            this.Controls.Add(this.editMemberButton);
            this.Controls.Add(this.addMemberButton);
            this.Controls.Add(this.optionsLabel);
            this.Controls.Add(this.SurnameTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.surnameLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.findLabel);
            this.Controls.Add(this.leftWallLabel);
            this.Controls.Add(this.titleLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MembersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MembersForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.membersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label leftWallLabel;
        private System.Windows.Forms.Label findLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label surnameLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox SurnameTextBox;
        private System.Windows.Forms.Label optionsLabel;
        private System.Windows.Forms.Button addMemberButton;
        private System.Windows.Forms.Button editMemberButton;
        private System.Windows.Forms.Button deleteMemberButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource membersBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Names;
        private System.Windows.Forms.DataGridViewTextBoxColumn Surname;
    }
}