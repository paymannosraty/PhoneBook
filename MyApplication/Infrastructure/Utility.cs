//namespace MyApplication.Infrastructure
namespace Infrastructure
{
	public static class Utility
	{
		static Utility()
		{
		}

		public static Models.User AuthenticatedUser { get; set; }

		public static Models.Contact AuthenticatedContact { get; set; }

		private static PhoneBook.AddNewContactForm addNewContactForm;
		public static PhoneBook.AddNewContactForm AddNewContactForm
		{
			get
			{
				if ((addNewContactForm == null) || (addNewContactForm.IsDisposed))
				{
					addNewContactForm =
						new PhoneBook.AddNewContactForm();
				}
				return addNewContactForm;
			}
		}

	}
}
