namespace Models
{
	public class Contact : BaseEntity
	{
		public Contact() : base()
		{

		}

		/**********************/
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 20, MinimumLength = 1)]
		public string FirstName { get; set; }

		/**********************/
		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false)]

		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 20, MinimumLength = 1)]
		public string LastName { get; set; }

		/**********************/
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 11, MinimumLength = 11)]
		public string PhoneNumber { get; set; }

		/**********************/
		[System.ComponentModel.DataAnnotations.StringLength
		(maximumLength: 11, MinimumLength = 11)]
		public string MobileNumber { get; set; }

		/**********************/
		[System.ComponentModel.DataAnnotations.StringLength
		(maximumLength: 200)]
		public string Address { get; set; }
	}
}
