namespace Models
{
	public class Country : BaseEntity
	{
		public Country() : base()
		{
		}

		// **********
		public string Name { get; set; }
		// **********

		// **********
		// با نگاه شیء گرايی
		public virtual System.Collections.Generic.IList<State> States { get; set; }
		// **********
	}
}
