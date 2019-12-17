using System.Linq;

namespace PhoneBook
{
	public partial class MainForm2 : DevExpress.XtraEditors.XtraForm
	{
		public MainForm2()
		{
			InitializeComponent();
		}

		void windowsUIButtonPanel_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
		{
			if (e.Button.Properties.Caption == "چاپ") gridControl.ShowRibbonPrintPreview();

			if (e.Button.Properties.Caption == "جدید")
			{
				Infrastructure.Utility.AddNewContactForm.addButton.Enabled = true;
				Infrastructure.Utility.AddNewContactForm.editButton.Enabled = false;

				Infrastructure.Utility.AddNewContactForm.ShowDialog();

				SearchContact();
			}

			if (e.Button.Properties.Caption == "بروزرسانی")
			{
				SearchContact();
				DevExpress.XtraEditors.XtraMessageBox.Show("به روز رسانی انجام شد");
			}

			if (e.Button.Properties.Caption == "اصلاح")
			{
				if (gridView.SelectedRowsCount != 1)
				{
					DevExpress.XtraEditors.XtraMessageBox.Show("برای اصلاح فقط یک آیتم را انتخاب کنید");
					return;
				}
				
				// first get selected rows indexes to var and then cast it to model
				int[] selectedRows = gridView.GetSelectedRows();

				Models.Contact selectedContact =
					gridView.GetRow(selectedRows[0]) as Models.Contact;

				if (selectedContact != null)
				{
					Infrastructure.Utility.AddNewContactForm.SelectedContact = selectedContact;

					Infrastructure.Utility.AddNewContactForm.addButton.Enabled = false;
					Infrastructure.Utility.AddNewContactForm.editButton.Enabled = true;

					Infrastructure.Utility.AddNewContactForm.ShowDialog();

					SearchContact();

				}
			}
			if (e.Button.Properties.Caption == "حذف")
			{
				System.Windows.Forms.DialogResult dialogResult =
					DevExpress.XtraEditors.XtraMessageBox.Show("آیا از حذف آیتم های مورد نظر اطمینان دارید؟",
					caption: "اخطار",
					buttons: System.Windows.Forms.MessageBoxButtons.YesNo,
					icon: System.Windows.Forms.MessageBoxIcon.Warning
					);

				if (dialogResult == System.Windows.Forms.DialogResult.No)
				{
					return;
				}
				if (gridView.SelectedRowsCount == 0)
				{
					DevExpress.XtraEditors.XtraMessageBox.Show("برای حذف حداقل یک آیتم را انتخاب کنید");
					return;
				}

				int[] selectedRows = gridView.GetSelectedRows();

				Models.Contact selectedContact =
					gridView.GetRow(selectedRows[0]) as Models.Contact;

				if (selectedContact != null)
				{
					Models.DatabaseContext databaseContext = null;
					try
					{
						databaseContext = new Models.DatabaseContext();
						Models.Contact contact = databaseContext.Contacts
							.Where(current => current.Id == selectedContact.Id)
							.FirstOrDefault();

						databaseContext.Contacts.Remove(contact);

						databaseContext.SaveChanges();

						SearchContact();
					}
					catch (System.Exception ex)
					{
						DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message.ToString());
					}
					finally
					{
						if (databaseContext != null)
						{
							databaseContext.Dispose();
							databaseContext = null;
						}
					}
				}
			}
		}

		public void SearchContact() // add in utility
		{
			Models.DatabaseContext databaseContext = null;

			try
			{
				databaseContext = new Models.DatabaseContext();

				System.Collections.Generic.List<Models.Contact> contacts;

				contacts = databaseContext.Contacts.ToList();

				gridControl.DataSource = contacts;

			}
			catch (System.Exception ex)
			{
				DevExpress.XtraEditors.XtraMessageBox.Show(ex.ToString());
			}
			finally
			{
				if (databaseContext != null)
				{
					databaseContext.Dispose();
					databaseContext = null;
				}
			}
		}

		private void MainForm2_Load(object sender, System.EventArgs e)
		{
			SearchContact();
			gridView.Columns[0].Caption = "نام ";
			gridView.Columns[1].Caption = "نام خانوادگی";
			gridView.Columns[2].Caption = "شماره ثابت";
			gridView.Columns[3].Caption = "شماره موبایل ";
			gridView.Columns[4].Caption = "آدرس ";
			gridView.Columns[5].Visible = false;
		}
	}
}
