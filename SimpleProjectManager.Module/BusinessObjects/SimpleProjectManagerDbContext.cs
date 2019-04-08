using System;
using System.Data;
using System.Linq;
using System.Data.Entity;
using System.Data.Common;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.ComponentModel;
using DevExpress.ExpressApp.EF.Updating;
using DevExpress.Persistent.BaseImpl.EF;
using DevExpress.ExpressApp.Design;
using DevExpress.ExpressApp.EF.DesignTime;
using SimpleProjectManager.Module.BusinessObjects.Marketing;

namespace SimpleProjectManager.Module.BusinessObjects {
	public class SimpleProjectManagerContextInitializer : DbContextTypesInfoInitializerBase {
		protected override DbContext CreateDbContext() {
			return new SimpleProjectManagerDbContext("App=EntityFramework");
		}
	}
	[TypesInfoInitializer(typeof(SimpleProjectManagerContextInitializer))]
	public class SimpleProjectManagerDbContext : DbContext {
		public SimpleProjectManagerDbContext(String connectionString)
			: base(connectionString) {
		}
		public SimpleProjectManagerDbContext(DbConnection connection)
			: base(connection, false) {
		}
		public SimpleProjectManagerDbContext()
			: base("name=ConnectionString") {
		}
		public DbSet<ModuleInfo> ModulesInfo { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Testimonial> Testimonial { get; set; }
    }
}