using app.Enums;
using app.Models.Base;
using app.Models.Domain;
using Microsoft.EntityFrameworkCore;
using Z.EntityFramework.Plus;


namespace app.Domain
{
    public class AppDbContext : DbContext
    {
        private const string NameServer = "WIN-GDUP4P8GKP6";
        private const string NameDb = "stoloffka";
        public DbSet<Dish> Dishes { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<DocumentDish> Documents { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<IngredientKind> IngredientKinds { get; set; }
        public DbSet<DishOrder> DishOrders { get; set; }
        public DbSet<DishDocumentRelation> DishDocumentRelations { get; set; }
        public AppDbContext() : base()
        {
            this.Filter<EntityBase>(q => q.Where(eb => eb.State == EnityStateEnum.Actual));
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@$"Server={NameServer};Database={NameDb};Trusted_Connection=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            EntityBase_Builder(modelBuilder);
            modelBuilder.Entity<DishOrder>()
                .HasOne(d => d.Order)
                .WithMany(o => o.DishOrders)
                .HasForeignKey(d => d.OrderId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<DishOrder>()
                .HasOne(d => d.Dish)
                .WithMany()
                .HasForeignKey(d => d.DishId)
                .OnDelete(DeleteBehavior.Restrict);
            onModelCreatingEnums(modelBuilder);
        }

        private static void EntityBase_Builder(ModelBuilder modelBuilder)
        {
            var types = modelBuilder.Model.GetEntityTypes()
                        .Where(t => t.ClrType.IsAssignableTo(typeof(EntityBase)));

            foreach (var et in types)
            {
                var stateProperty = et.FindProperty("State");
                if (stateProperty != null)
                {
                    stateProperty.SetDefaultValueSql("0");
                }
            }
        }

        private static void onModelCreatingEnums(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .Property(c => c.Role)
                .HasConversion<string>();

            modelBuilder.Entity<Dish>()
                .Property(c => c.Type)
                .HasConversion<string>();
        }
    }
}
