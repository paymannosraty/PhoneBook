using System.Linq;

namespace PhoneBook
{
	public partial class MainForm : Infrastructure.BaseForm
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void MainForm_Load(object sender, System.EventArgs e)
		{
			SearchContact();
			dataGridView.Columns["firstname"].HeaderText = "نام ";
			dataGridView.Columns["lastname"].HeaderText = "نام خانوادگی";
			dataGridView.Columns["phonenumber"].HeaderText = "شماره ثابت";
			dataGridView.Columns["mobilenumber"].HeaderText = "شماره موبایل ";
			dataGridView.Columns["address"].HeaderText = "آدرس ";
			dataGridView.Columns["id"].Visible = false;


		}

		/// <summary>
		/// First Overloading Of SearchContact Method Without any Parameter
		/// </summary>
		public void SearchContact()
		{
			Models.DatabaseContext databaseContext = null;

			try
			{
				databaseContext = new Models.DatabaseContext();

				System.Collections.Generic.List<Models.Contact> contacts;

				contacts = databaseContext.Contacts.ToList();

				dataGridView.DataSource = contacts;



			}
			catch (System.Exception)
			{
				System.Windows.Forms.MessageBox.Show("Some Error Accured");
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

		/// <summary>
		/// second Overloading Of SearchContact Method With any Parameter
		/// </summary>
		/// <param name="FetchReason"></param>
		public void SearchContact(string FetchReason)
		{
			Models.DatabaseContext databaseContext = null;

			try
			{
				databaseContext = new Models.DatabaseContext();

				System.Collections.Generic.List<Models.Contact> contacts;

				switch (FetchReason)
				{
					case "firstname":
					if (firstNameTextBox.Text == string.Empty)
					{
						SearchContact();
						return;
					}
					contacts = databaseContext.Contacts
					.Where(Current => Current.FirstName.Contains(firstNameTextBox.Text.ToString()))
					.OrderBy(current => current.FirstName)
					.ToList();

					dataGridView.DataSource = contacts;

					break;

					case "lastname":
					if (lastNameTextBox.Text == string.Empty)
					{
						SearchContact();
						return;
					}
					contacts = databaseContext.Contacts
					.Where(Current => Current.LastName.Contains(lastNameTextBox.Text.ToString()))
					.OrderBy(current => current.LastName)
					.ToList();

					dataGridView.DataSource = contacts;

					break;

					default:
					System.Windows.Forms.MessageBox.Show("Some Error Accured");
					break;
				}

			}
			catch (System.Exception)
			{
				System.Windows.Forms.MessageBox.Show("Some Error Accured");
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

		private void lastNameTextBox_TextChanged(object sender, System.EventArgs e)
		{
			SearchContact("lastname");
		}

		private void firstNameTextBox_TextChanged(object sender, System.EventArgs e)
		{
			SearchContact("firstname");
		}
	}
	
}
