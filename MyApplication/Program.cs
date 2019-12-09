using System.Linq;

namespace MyApplication
{
	internal static class Program
	{
		static Program()
		{
		}

		[System.STAThread]
		internal static void Main()
		{
			// **************************************************
			System.Windows.Forms.Application.EnableVisualStyles();
			System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);
			// **************************************************

			// **************************************************
			// **************************************************
			// **************************************************
			Models.DatabaseContext databaseContext = null;

			try
			{
				databaseContext =
					new Models.DatabaseContext();

				// **************************************************
				// **************************************************

				// **************************************************
				//var users =
				//	databaseContext.Users
				//	.ToList()
				//	;

				//int userCount = users.Count;
				// **************************************************

				// **************************************************
				//int userCount =
				//	databaseContext.Users
				//	.Count();
				// **************************************************

				// **************************************************
				bool hasAnyUser =
					databaseContext.Users
					.Any();
				// **************************************************

				if (hasAnyUser == false)
				{
					Models.User adminUser = new Models.User
					{
						IsAdmin = true,
						IsActive = true,

						Username = "PaymanN",
						Password = "1234512345",
						FullName = "Payman Nosrati"
					};

					databaseContext.Users.Add(adminUser);

					databaseContext.SaveChanges();
				}
			}
			catch (System.Exception ex)
			{
				System.Windows.Forms.MessageBox.Show(ex.Message);

				return;
			}
			finally
			{
				if (databaseContext != null)
				{
					databaseContext.Dispose();
					databaseContext = null;
				}
			}
			// **************************************************
			// **************************************************
			// **************************************************

			// **************************************************
			//System.Windows.Forms.Application.Run(new mainForm());

			#region Runing Startup Form and then Disposing!
			PhoneBook.MainForm mainForm = new PhoneBook.MainForm();

			System.Windows.Forms.Application.Run(mainForm);

			if (mainForm != null)
			{
				if (mainForm.IsDisposed == false)
				{
					mainForm.Dispose();
				}

				mainForm = null;
			}
			#endregion /Runing Startup Form and then Disposing!
			// **************************************************
		}
	}
}
