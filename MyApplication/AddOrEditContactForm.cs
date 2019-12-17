using DevExpress.XtraEditors;
using System.Linq;

namespace PhoneBook
{
	public partial class AddOrEditContactForm : DevExpress.XtraEditors.XtraForm
	{
		public AddOrEditContactForm()
		{
			InitializeComponent();
		}

		public string ErrorMessage { get; set; }
		public Models.Contact SelectedContact { get; set; }

		private void AddNewContactForm_Load(object sender, System.EventArgs e)
		{
			if (addButton.Enabled)
			{
				Reset();
				firstNameTextEdit.Focus();
			}

			if (editButton.Enabled)
			{
				Models.DatabaseContext databaseContext = null;

				try
				{
					databaseContext = new Models.DatabaseContext();

					bool hasCurrentContact =
						databaseContext.Contacts.Where(current => current.Id == SelectedContact.Id)
						.Any();

					if (hasCurrentContact == false)
					{
						DevExpress.XtraEditors.XtraMessageBox.Show("مخاطب جاری حذف گردیده است");
						return;
					}

					firstNameTextEdit.Text = SelectedContact.FirstName.ToString();
					lastNameTextEdit.Text = SelectedContact.LastName.ToString();
					phoneNumberTextEdit.Text = SelectedContact.PhoneNumber.ToString();
					mobileTextEdit.Text = SelectedContact.MobileNumber.ToString();
					addressRichText.Text = SelectedContact.Address.ToString();

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


		}
		private void AddButton_Click(object sender, System.EventArgs e)
		{
			if (DataValidation() == false)
			{	
				return;
			}

			Models.DatabaseContext databaseContext = null;

			try
			{
				databaseContext = new Models.DatabaseContext();

				Models.Contact contact = new Models.Contact
				{
					FirstName = firstNameTextEdit.Text.ToString(),
					LastName = lastNameTextEdit.Text.ToString(),
					PhoneNumber = phoneNumberTextEdit.Text.ToString(),
					MobileNumber = mobileTextEdit.Text.ToString(),
					Address = addressRichText.Text.ToString(),
				};

				databaseContext.Contacts.Add(contact);

				databaseContext.SaveChanges();

				DevExpress.XtraEditors.XtraMessageBox.Show($"!{ firstNameTextEdit.Text } { lastNameTextEdit.Text } با موفقیت اضافه شد",
					caption: "",
					buttons: System.Windows.Forms.MessageBoxButtons.OK,
					icon: System.Windows.Forms.MessageBoxIcon.Asterisk
					);

				Reset();
				firstNameTextEdit.Focus();
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
		private void EditButton_Click(object sender, System.EventArgs e)
		{
			if (DataValidation() == false)
			{
				return;
			}

			Models.DatabaseContext databaseContext = null;

			try
			{
				databaseContext = new Models.DatabaseContext();

				Models.Contact contact = databaseContext.Contacts
					.Where(current => current.Id == SelectedContact.Id)
					.FirstOrDefault();

				contact.Address = addressRichText.Text.ToString();
				contact.LastName = lastNameTextEdit.Text.ToString();
				contact.MobileNumber = mobileTextEdit.Text.ToString();
				contact.FirstName = firstNameTextEdit.Text.ToString();
				contact.PhoneNumber = phoneNumberTextEdit.Text.ToString();

				databaseContext.SaveChanges();

				DevExpress.XtraEditors.XtraMessageBox.Show($"!{ firstNameTextEdit.Text } { lastNameTextEdit.Text } با موفقیت ویرایش شد",
					caption: "",
					buttons: System.Windows.Forms.MessageBoxButtons.OK,
					icon: System.Windows.Forms.MessageBoxIcon.Asterisk
					);

				this.Close();
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
		public void Reset()
		{
			mobileTextEdit.Text = string.Empty;
			addressRichText.Text = string.Empty;
			lastNameTextEdit.Text = string.Empty;
			firstNameTextEdit.Text = string.Empty;
			phoneNumberTextEdit.Text = string.Empty;
		}

		public bool DataValidation()
		{
			ErrorMessage = string.Empty;

			if (firstNameTextEdit.Text == string.Empty && lastNameTextEdit.Text == string.Empty)
			{
				ErrorMessage = "نام و نام خانوادگی، هردو نمی توانند خالی باشند";
			}

			if (mobileTextEdit.Text == string.Empty &&
				phoneNumberTextEdit.Text == string.Empty &&
				addressRichText.Text == string.Empty)
			{
				ErrorMessage += System.Environment.NewLine +
					"حداقل یکی از سه فیلد شماره ثابت، شماره تلفن و آدرس باید پر شود";
			}

			if (mobileTextEdit.Text.Length != 11)
			{
				if (mobileTextEdit.Text.Length != 0 && phoneNumberTextEdit.Text == string.Empty)
				{
					ErrorMessage += System.Environment.NewLine +
						"شماره موبایل باید 11 رقم باشد";
				}
			}

			if (phoneNumberTextEdit.Text.Length != 11)
			{
				if (phoneNumberTextEdit.Text.Length != 0 && mobileTextEdit.Text == string.Empty)
				{
					ErrorMessage += System.Environment.NewLine +
						"شماره ثابت باید 11 رقم باشد";
				}
			}
			if (phoneNumberTextEdit.Text != string.Empty && mobileTextEdit.Text != string.Empty)
			{
				if (phoneNumberTextEdit.Text.Length != 0 && mobileTextEdit.Text.Length != 11)
				{
					ErrorMessage += System.Environment.NewLine +
						"شماره ثابت باید 11 رقم باشد";
				}
				if (mobileTextEdit.Text.Length != 0 && phoneNumberTextEdit.Text.Length != 11)
				{
					ErrorMessage += System.Environment.NewLine +
						"شماره موبایل باید 11 رقم باشد";
				}
			}
			if (ErrorMessage != string.Empty)
			{
				System.Windows.Forms.DialogResult dialogResult =
					DevExpress.XtraEditors.XtraMessageBox.Show(ErrorMessage,
					caption: "اخطار",
					buttons: System.Windows.Forms.MessageBoxButtons.OK,
					icon: System.Windows.Forms.MessageBoxIcon.Warning
					);

				return false;
			}
			else
			{
				return true;
			}
		}
	}
}