namespace Models
{
	public class Country : BaseEntity
	{
		public Country() : base()
		{
		}

		// **********
		[System.ComponentModel.DataAnnotations.MaxLength
			(length: 50)]

		[System.ComponentModel.DataAnnotations.Schema.Index
			(IsUnique = true)]
		public string Name { get; set; }
		// **********

		// **********
		// با نگاه شیء گرايی
		public virtual System.Collections.Generic.IList<State> States { get; set; }
		// **********
	}
}
