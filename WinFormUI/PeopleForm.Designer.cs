namespace WinFormUI
{
    partial class PeopleForm
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
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.firstNameText = new System.Windows.Forms.TextBox();
            this.lastNameText = new System.Windows.Forms.TextBox();
            this.addPersonHeader = new System.Windows.Forms.Label();
            this.listPeopleHeader = new System.Windows.Forms.Label();
            this.listPeopleListBox = new System.Windows.Forms.ListBox();
            this.addPersonButton = new System.Windows.Forms.Button();
            this.refreshListButton = new System.Windows.Forms.Button();
            this.imageNumberText = new System.Windows.Forms.TextBox();
            this.imageNumberLabel = new System.Windows.Forms.Label();
            this.schoolText = new System.Windows.Forms.TextBox();
            this.schoolLabel = new System.Windows.Forms.Label();
            this.removeButton = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameLabel.Location = new System.Drawing.Point(46, 101);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(175, 37);
            this.firstNameLabel.TabIndex = 0;
            this.firstNameLabel.Text = "First Name";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameLabel.Location = new System.Drawing.Point(46, 190);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(173, 37);
            this.lastNameLabel.TabIndex = 1;
            this.lastNameLabel.Text = "Last Name";
            // 
            // firstNameText
            // 
            this.firstNameText.Location = new System.Drawing.Point(52, 137);
            this.firstNameText.Name = "firstNameText";
            this.firstNameText.Size = new System.Drawing.Size(234, 48);
            this.firstNameText.TabIndex = 2;
            // 
            // lastNameText
            // 
            this.lastNameText.Location = new System.Drawing.Point(52, 226);
            this.lastNameText.Name = "lastNameText";
            this.lastNameText.Size = new System.Drawing.Size(234, 48);
            this.lastNameText.TabIndex = 3;
            // 
            // addPersonHeader
            // 
            this.addPersonHeader.AutoSize = true;
            this.addPersonHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPersonHeader.Location = new System.Drawing.Point(32, 42);
            this.addPersonHeader.Name = "addPersonHeader";
            this.addPersonHeader.Size = new System.Drawing.Size(311, 61);
            this.addPersonHeader.TabIndex = 4;
            this.addPersonHeader.Text = "Add Person";
            // 
            // listPeopleHeader
            // 
            this.listPeopleHeader.AutoSize = true;
            this.listPeopleHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listPeopleHeader.Location = new System.Drawing.Point(510, 43);
            this.listPeopleHeader.Name = "listPeopleHeader";
            this.listPeopleHeader.Size = new System.Drawing.Size(296, 61);
            this.listPeopleHeader.TabIndex = 5;
            this.listPeopleHeader.Text = "List People";
            // 
            // listPeopleListBox
            // 
            this.listPeopleListBox.FormattingEnabled = true;
            this.listPeopleListBox.ItemHeight = 40;
            this.listPeopleListBox.Location = new System.Drawing.Point(388, 107);
            this.listPeopleListBox.Name = "listPeopleListBox";
            this.listPeopleListBox.Size = new System.Drawing.Size(585, 404);
            this.listPeopleListBox.TabIndex = 6;
            // 
            // addPersonButton
            // 
            this.addPersonButton.Location = new System.Drawing.Point(54, 508);
            this.addPersonButton.Name = "addPersonButton";
            this.addPersonButton.Size = new System.Drawing.Size(234, 69);
            this.addPersonButton.TabIndex = 7;
            this.addPersonButton.Text = "Add Person";
            this.addPersonButton.UseVisualStyleBackColor = true;
            this.addPersonButton.Click += new System.EventHandler(this.addPersonButton_Click);
            // 
            // refreshListButton
            // 
            this.refreshListButton.Location = new System.Drawing.Point(54, 583);
            this.refreshListButton.Name = "refreshListButton";
            this.refreshListButton.Size = new System.Drawing.Size(234, 69);
            this.refreshListButton.TabIndex = 8;
            this.refreshListButton.Text = "Refresh List";
            this.refreshListButton.UseVisualStyleBackColor = true;
            this.refreshListButton.Click += new System.EventHandler(this.refreshListButton_Click);
            // 
            // imageNumberText
            // 
            this.imageNumberText.Location = new System.Drawing.Point(55, 428);
            this.imageNumberText.Name = "imageNumberText";
            this.imageNumberText.Size = new System.Drawing.Size(234, 48);
            this.imageNumberText.TabIndex = 10;
            // 
            // imageNumberLabel
            // 
            this.imageNumberLabel.AutoSize = true;
            this.imageNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imageNumberLabel.Location = new System.Drawing.Point(49, 385);
            this.imageNumberLabel.Name = "imageNumberLabel";
            this.imageNumberLabel.Size = new System.Drawing.Size(229, 37);
            this.imageNumberLabel.TabIndex = 9;
            this.imageNumberLabel.Text = "Image Number";
            // 
            // schoolText
            // 
            this.schoolText.Location = new System.Drawing.Point(54, 326);
            this.schoolText.Name = "schoolText";
            this.schoolText.Size = new System.Drawing.Size(234, 48);
            this.schoolText.TabIndex = 12;
            // 
            // schoolLabel
            // 
            this.schoolLabel.AutoSize = true;
            this.schoolLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.schoolLabel.Location = new System.Drawing.Point(48, 283);
            this.schoolLabel.Name = "schoolLabel";
            this.schoolLabel.Size = new System.Drawing.Size(115, 37);
            this.schoolLabel.TabIndex = 11;
            this.schoolLabel.Text = "School";
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(0, 0);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(75, 23);
            this.removeButton.TabIndex = 0;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(56, 658);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(234, 69);
            this.buttonDelete.TabIndex = 13;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.Button1_Click);
            // 
            // PeopleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(21F, 40F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 781);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.schoolText);
            this.Controls.Add(this.schoolLabel);
            this.Controls.Add(this.imageNumberText);
            this.Controls.Add(this.imageNumberLabel);
            this.Controls.Add(this.refreshListButton);
            this.Controls.Add(this.addPersonButton);
            this.Controls.Add(this.listPeopleListBox);
            this.Controls.Add(this.listPeopleHeader);
            this.Controls.Add(this.addPersonHeader);
            this.Controls.Add(this.lastNameText);
            this.Controls.Add(this.firstNameText);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.firstNameLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.Name = "PeopleForm";
            this.Text = "Yearbook Selection App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.TextBox firstNameText;
        private System.Windows.Forms.TextBox lastNameText;
        private System.Windows.Forms.Label addPersonHeader;
        private System.Windows.Forms.Label listPeopleHeader;
        private System.Windows.Forms.ListBox listPeopleListBox;
        private System.Windows.Forms.Button addPersonButton;
        private System.Windows.Forms.Button refreshListButton;
        private System.Windows.Forms.TextBox imageNumberText;
        private System.Windows.Forms.Label imageNumberLabel;
        private System.Windows.Forms.TextBox schoolText;
        private System.Windows.Forms.Label schoolLabel;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button buttonDelete;
    }
}

