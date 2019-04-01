namespace FormularioDB
{
	using System;
	using System.Data.Entity;
	using System.ComponentModel.DataAnnotations.Schema;
	using System.Linq;

	public partial class ConFormu : DbContext
	{
		public ConFormu()
			: base("name=ConFormu")
		{
		}

		public virtual DbSet<persona> persona { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Entity<persona>()
				.Property(e => e.nombre)
				.IsUnicode(false);

			modelBuilder.Entity<persona>()
				.Property(e => e.carrera)
				.IsUnicode(false);
		}
	}
}
