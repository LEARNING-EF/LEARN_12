namespace Models
{
	public class DatabaseContext : System.Data.Entity.DbContext
	{
		static DatabaseContext()
		{
			System.Data.Entity.Database
				.SetInitializer(new DatabaseContextInitializer());
		}

		public DatabaseContext() : base()
		{
		}

		// **********
		public System.Data.Entity.DbSet<State> States { get; set; }
		// **********

		// **********
		public System.Data.Entity.DbSet<Country> Countries { get; set; }
		// **********
	}
}
