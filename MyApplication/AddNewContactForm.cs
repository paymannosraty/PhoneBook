using DevExpress.XtraEditors;
using System.Linq;

namespace PhoneBook
{
	public partial class AddNewContactForm : DevExpress.XtraEditors.XtraForm
	{
		public AddNewContactForm()
		{
			InitializeComponent();
		}

		private void AddButton_Click(object sender, System.EventArgs e)
		{
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

				System.Windows.Forms.MessageBox.Show($"!{ firstNameTextEdit.Text } { lastNameTextEdit.Text } با موفقیت اضافه شد",
					caption: "",
					buttons: System.Windows.Forms.MessageBoxButtons.OK,
					icon: System.Windows.Forms.MessageBoxIcon.Asterisk
					);

				Reset();
				
			}

			catch (System.Exception ex)
			{
				System.Windows.Forms.MessageBox.Show(ex.Message.ToString());
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
	}
}