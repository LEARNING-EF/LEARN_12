namespace Models
{
	public class State : BaseEntity
	{
		public State() : base()
		{
		}

		// **********
		// **********
		// **********
		// صرفا با نگاه طراحی بانک اطلاعاتی
		[System.ComponentModel.DataAnnotations.Schema.Index
			(name: "CountryId_Name", IsUnique = true, Order = 0)]
		public System.Guid CountryId { get; set; }
		// **********

		// **********
		// با نگاه شیء گرايی
		public virtual Country Country { get; set; }
		// **********
		// **********
		// **********

		// **********
		[System.ComponentModel.DataAnnotations.MaxLength
			(length: 50)]

		[System.ComponentModel.DataAnnotations.Schema.Index
			(name: "CountryId_Name", IsUnique = true, Order = 1)]
		public string Name { get; set; }
		// **********
	}
}
