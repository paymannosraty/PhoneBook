namespace PhoneBook
{
	partial class AddOrEditContactForm
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
			this.addButton = new DevExpress.XtraEditors.SimpleButton();
			this.cancelButton = new DevExpress.XtraEditors.SimpleButton();
			this.addGroupBox = new System.Windows.Forms.GroupBox();
			this.addressLabel = new DevExpress.XtraEditors.LabelControl();
			this.mobileLabel = new DevExpress.XtraEditors.LabelControl();
			this.phoneLabel = new DevExpress.XtraEditors.LabelControl();
			this.lastNameLabel = new DevExpress.XtraEditors.LabelControl();
			this.firstNameLabel = new DevExpress.XtraEditors.LabelControl();
			this.mobileTextEdit = new DevExpress.XtraEditors.TextEdit();
			this.phoneNumberTextEdit = new DevExpress.XtraEditors.TextEdit();
			this.lastNameTextEdit = new DevExpress.XtraEditors.TextEdit();
			this.firstNameTextEdit = new DevExpress.XtraEditors.TextEdit();
			this.addressRichText = new DevExpress.XtraEditors.MemoEdit();
			this.editButton = new DevExpress.XtraEditors.SimpleButton();
			this.addGroupBox.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.mobileTextEdit.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.phoneNumberTextEdit.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lastNameTextEdit.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.firstNameTextEdit.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.addressRichText.Properties)).BeginInit();
			this.SuspendLayout();
			// 
			// addButton
			// 
			this.addButton.Location = new System.Drawing.Point(12, 256);
			this.addButton.Name = "addButton";
			this.addButton.Size = new System.Drawing.Size(113, 23);
			this.addButton.TabIndex = 1;
			this.addButton.Text = "اضافه کن";
			this.addButton.Click += new System.EventHandler(this.AddButton_Click);
			// 
			// cancelButton
			// 
			this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.cancelButton.Location = new System.Drawing.Point(250, 256);
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.Size = new System.Drawing.Size(113, 23);
			this.cancelButton.TabIndex = 2;
			this.cancelButton.Text = "انصراف";
			// 
			// addGroupBox
			// 
			this.addGroupBox.Controls.Add(this.addressLabel);
			this.addGroupBox.Controls.Add(this.mobileLabel);
			this.addGroupBox.Controls.Add(this.phoneLabel);
			this.addGroupBox.Controls.Add(this.lastNameLabel);
			this.addGroupBox.Controls.Add(this.firstNameLabel);
			this.addGroupBox.Controls.Add(this.mobileTextEdit);
			this.addGroupBox.Controls.Add(this.phoneNumberTextEdit);
			this.addGroupBox.Controls.Add(this.lastNameTextEdit);
			this.addGroupBox.Controls.Add(this.firstNameTextEdit);
			this.addGroupBox.Controls.Add(this.addressRichText);
			this.addGroupBox.Location = new System.Drawing.Point(12, 12);
			this.addGroupBox.Name = "addGroupBox";
			this.addGroupBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.addGroupBox.Size = new System.Drawing.Size(473, 238);
			this.addGroupBox.TabIndex = 0;
			this.addGroupBox.TabStop = false;
			this.addGroupBox.Text = "درج مخاطب جدید";
			// 
			// addressLabel
			// 
			this.addressLabel.Location = new System.Drawing.Point(398, 126);
			this.addressLabel.Name = "addressLabel";
			this.addressLabel.Size = new System.Drawing.Size(25, 13);
			this.addressLabel.TabIndex = 9;
			this.addressLabel.Text = "&آدرس";
			// 
			// mobileLabel
			// 
			this.mobileLabel.Location = new System.Drawing.Point(398, 101);
			this.mobileLabel.Name = "mobileLabel";
			this.mobileLabel.Size = new System.Drawing.Size(61, 13);
			this.mobileLabel.TabIndex = 8;
			this.mobileLabel.Text = "&شماره موبایل";
			// 
			// phoneLabel
			// 
			this.phoneLabel.Location = new System.Drawing.Point(398, 75);
			this.phoneLabel.Name = "phoneLabel";
			this.phoneLabel.Size = new System.Drawing.Size(52, 13);
			this.phoneLabel.TabIndex = 7;
			this.phoneLabel.Text = "&شماره ثابت";
			// 
			// lastNameLabel
			// 
			this.lastNameLabel.Location = new System.Drawing.Point(398, 49);
			this.lastNameLabel.Name = "lastNameLabel";
			this.lastNameLabel.Size = new System.Drawing.Size(58, 13);
			this.lastNameLabel.TabIndex = 6;
			this.lastNameLabel.Text = "&نام خانوادگی";
			// 
			// firstNameLabel
			// 
			this.firstNameLabel.Location = new System.Drawing.Point(398, 23);
			this.firstNameLabel.Name = "firstNameLabel";
			this.firstNameLabel.Size = new System.Drawing.Size(13, 13);
			this.firstNameLabel.TabIndex = 5;
			this.firstNameLabel.Text = "&نام";
			// 
			// mobileTextEdit
			// 
			this.mobileTextEdit.Location = new System.Drawing.Point(6, 98);
			this.mobileTextEdit.Name = "mobileTextEdit";
			this.mobileTextEdit.Properties.MaxLength = 11;
			this.mobileTextEdit.Size = new System.Drawing.Size(380, 20);
			this.mobileTextEdit.TabIndex = 3;
			// 
			// phoneNumberTextEdit
			// 
			this.phoneNumberTextEdit.Location = new System.Drawing.Point(6, 72);
			this.phoneNumberTextEdit.Name = "phoneNumberTextEdit";
			this.phoneNumberTextEdit.Properties.MaxLength = 11;
			this.phoneNumberTextEdit.Size = new System.Drawing.Size(380, 20);
			this.phoneNumberTextEdit.TabIndex = 2;
			// 
			// lastNameTextEdit
			// 
			this.lastNameTextEdit.Location = new System.Drawing.Point(6, 46);
			this.lastNameTextEdit.Name = "lastNameTextEdit";
			this.lastNameTextEdit.Properties.MaxLength = 20;
			this.lastNameTextEdit.Size = new System.Drawing.Size(380, 20);
			this.lastNameTextEdit.TabIndex = 1;
			// 
			// firstNameTextEdit
			// 
			this.firstNameTextEdit.Location = new System.Drawing.Point(6, 20);
			this.firstNameTextEdit.Name = "firstNameTextEdit";
			this.firstNameTextEdit.Properties.MaxLength = 20;
			this.firstNameTextEdit.Size = new System.Drawing.Size(380, 20);
			this.firstNameTextEdit.TabIndex = 0;
			// 
			// addressRichText
			// 
			this.addressRichText.Location = new System.Drawing.Point(6, 124);
			this.addressRichText.Name = "addressRichText";
			this.addressRichText.Properties.MaxLength = 200;
			this.addressRichText.Size = new System.Drawing.Size(380, 72);
			this.addressRichText.TabIndex = 4;
			// 
			// editButton
			// 
			this.editButton.Location = new System.Drawing.Point(131, 256);
			this.editButton.Name = "editButton";
			this.editButton.Size = new System.Drawing.Size(113, 23);
			this.editButton.TabIndex = 1;
			this.editButton.Text = "اصلاح کن";
			this.editButton.Click += new System.EventHandler(this.EditButton_Click);
			// 
			// AddOrEditContactForm
			// 
			this.AcceptButton = this.addButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.cancelButton;
			this.ClientSize = new System.Drawing.Size(500, 308);
			this.Controls.Add(this.addGroupBox);
			this.Controls.Add(this.cancelButton);
			this.Controls.Add(this.editButton);
			this.Controls.Add(this.addButton);
			this.MaximumSize = new System.Drawing.Size(510, 340);
			this.MinimumSize = new System.Drawing.Size(510, 340);
			this.Name = "AddOrEditContactForm";
			this.RightToLeftLayout = true;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "درج و اصلاح مخاطب";
			this.Load += new System.EventHandler(this.AddNewContactForm_Load);
			this.addGroupBox.ResumeLayout(false);
			this.addGroupBox.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.mobileTextEdit.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.phoneNumberTextEdit.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lastNameTextEdit.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.firstNameTextEdit.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.addressRichText.Properties)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		public DevExpress.XtraEditors.SimpleButton addButton;
		private DevExpress.XtraEditors.SimpleButton cancelButton;
		private System.Windows.Forms.GroupBox addGroupBox;
		private DevExpress.XtraEditors.LabelControl addressLabel;
		private DevExpress.XtraEditors.LabelControl mobileLabel;
		private DevExpress.XtraEditors.LabelControl phoneLabel;
		private DevExpress.XtraEditors.LabelControl lastNameLabel;
		private DevExpress.XtraEditors.LabelControl firstNameLabel;
		private DevExpress.XtraEditors.TextEdit mobileTextEdit;
		private DevExpress.XtraEditors.TextEdit phoneNumberTextEdit;
		private DevExpress.XtraEditors.TextEdit lastNameTextEdit;
		private DevExpress.XtraEditors.TextEdit firstNameTextEdit;
		private DevExpress.XtraEditors.MemoEdit addressRichText;
		public DevExpress.XtraEditors.SimpleButton editButton;
	}
}