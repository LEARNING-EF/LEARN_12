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
		public System.Guid CountryId { get; set; }
		// **********

		// **********
		// با نگاه شیء گرايی
		public virtual Country Country { get; set; }
		// **********
		// **********
		// **********

		// **********
		public string Name { get; set; }
		// **********
	}
}
