using Microsoft.EntityFrameworkCore;

namespace autosales.Models
{
    public partial class AutosalesDbContext : DbContext
    {
        public AutosalesDbContext()
        {

        }
        public AutosalesDbContext(DbContextOptions<AutosalesDbContext> options) : base(options)
        {

        }
        public virtual DbSet<Car> Cars { get; set; }
        public virtual DbSet<Brand> Brands { get; set; }
        public virtual DbSet<Model> Models { get; set; }
        public virtual DbSet<Usage> Usages { get; set; }
        public virtual DbSet<Info> Infos { get; set; }
        public virtual DbSet<Type> Types { get; set; }
        public virtual DbSet<Color> Colors { get; set; }
        public virtual DbSet<State> States { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //to do: get connection string from json file
            optionsBuilder.UseSqlServer(@"Server = (localdb)\mssqllocaldb; Database = autosalesdb; Trusted_Connection = True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // to set setting of dbsets

            modelBuilder.Entity<Car>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("car_pkey");
                entity.ToTable("car");
                entity.Property(e => e.Id).ValueGeneratedOnAdd().HasColumnName("id");
                entity.Property(e => e.Price).HasColumnName("price");
                entity.Property(e => e.IsDeleted).HasColumnName("isdeleted");
                entity.Property(e => e.UserId).HasColumnName("userid");
                entity.HasOne(c => c.UserNavigation).WithMany(u => u.CarNavigation).HasForeignKey(c => c.UserId).HasConstraintName("car_userid_fkey").OnDelete(DeleteBehavior.NoAction);
            });

            modelBuilder.Entity<Creation>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("creation_pkey");
                entity.ToTable("creation");
                entity.Property(e => e.Id).ValueGeneratedOnAdd().HasColumnName("id");
                entity.Property(e => e.Year).HasColumnName("year");
                entity.Property(e => e.CarId).HasColumnName("carid");
                entity.Property(e => e.BrandId).HasColumnName("brandid");
                entity.Property(e => e.ModelId).HasColumnName("modelid");
                entity.HasOne(c => c.CarNavigation).WithOne(car => car.CreationNavigation).HasForeignKey<Creation>(c => c.CarId).HasConstraintName("creation_carid_fkey").OnDelete(DeleteBehavior.NoAction);
                entity.HasOne(c => c.BrandNavigation).WithMany(brand => brand.CreationNavigation).HasForeignKey(c => c.BrandId).HasConstraintName("creation_brandid_fkey").OnDelete(DeleteBehavior.NoAction);
                entity.HasOne(c => c.ModelNavigation).WithMany(model => model.CreationNavigation).HasForeignKey(c => c.ModelId).HasConstraintName("creation_modelid_fkey").OnDelete(DeleteBehavior.NoAction);
            });

            modelBuilder.Entity<Brand>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("brand_pkey");
                entity.ToTable("brand");
                entity.Property(e => e.Id).ValueGeneratedOnAdd().HasColumnName("id");
                entity.Property(e => e.Name).HasColumnName("name");
            });

            modelBuilder.Entity<Model>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("model_pkey");
                entity.ToTable("model");
                entity.Property(e => e.Id).ValueGeneratedOnAdd().HasColumnName("id");
                entity.Property(e => e.Name).HasColumnName("name");
                entity.Property(e => e.BrandId).HasColumnName("brandid");
                entity.HasOne(m => m.BrandNavigation).WithMany(b => b.ModelNavigation).HasForeignKey(m => m.BrandId).HasConstraintName("model_brandid_fkey").OnDelete(DeleteBehavior.NoAction);
            });

            modelBuilder.Entity<Usage>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("usage_pkey");
                entity.ToTable("usage");
                entity.Property(e => e.Id).ValueGeneratedOnAdd().HasColumnName("id");
                entity.Property(e => e.IsNew).HasColumnName("isnew");
                entity.Property(e => e.IsDamaged).HasColumnName("isdamaged");
                entity.Property(e => e.Mileage).HasColumnName("mileage");
                entity.Property(e => e.CarId).HasColumnName("carid");
                entity.HasOne(u => u.CarNavigation).WithOne(c => c.UsageNavigation).HasForeignKey<Usage>(u => u.CarId).HasConstraintName("usage_carid_fkey").OnDelete(DeleteBehavior.NoAction);
            });

            modelBuilder.Entity<Info>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("info_pkey");
                entity.ToTable("info");
                entity.Property(e => e.Id).ValueGeneratedOnAdd().HasColumnName("id");
                entity.Property(e => e.Description).HasColumnName("description");
                entity.Property(e => e.CarId).HasColumnName("carid");
                entity.Property(e => e.TypeId).HasColumnName("typeid");
                entity.Property(e => e.ColorId).HasColumnName("colorid");
                entity.Property(e => e.StateId).HasColumnName("stateid");
                entity.HasOne(i => i.CarNavigation).WithOne(c => c.InfoNavigation).HasForeignKey<Info>(i => i.CarId).HasConstraintName("info_carid_fkey").OnDelete(DeleteBehavior.NoAction);
                entity.HasOne(i => i.TypeNavigation).WithMany(t => t.InfoNavigation).HasForeignKey(i => i.TypeId).HasConstraintName("info_typeid_fkey").OnDelete(DeleteBehavior.NoAction);
                entity.HasOne(i => i.ColorNavigation).WithMany(c => c.InfoNavigation).HasForeignKey(i => i.ColorId).HasConstraintName("info_colorid_fkey").OnDelete(DeleteBehavior.NoAction);
                entity.HasOne(i => i.StateNavigation).WithMany(s => s.InfoNavigation).HasForeignKey(i => i.StateId).HasConstraintName("info_stateid_fkey").OnDelete(DeleteBehavior.NoAction);
            });

            modelBuilder.Entity<Type>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("type_pkey");
                entity.ToTable("type");
                entity.Property(e => e.Id).ValueGeneratedOnAdd().HasColumnName("id");
                entity.Property(e => e.Name).HasColumnName("name");
            });

            modelBuilder.Entity<Color>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("color_pkey");
                entity.ToTable("color");
                entity.Property(e => e.Id).ValueGeneratedOnAdd().HasColumnName("id");
                entity.Property(e => e.Name).HasColumnName("name");
            });

            modelBuilder.Entity<State>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("state_pkey");
                entity.ToTable("state");
                entity.Property(e => e.Id).ValueGeneratedOnAdd().HasColumnName("id");
                entity.Property(e => e.Name).HasColumnName("name");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("user_pkey");
                entity.ToTable("user");
                entity.Property(e => e.Id).ValueGeneratedOnAdd().HasColumnName("id");
                entity.Property(e => e.Name).HasColumnName("name");
                entity.Property(e => e.Phone).HasColumnName("phone");
            });

            modelBuilder.Entity<Login>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("login_pkey");
                entity.ToTable("login");
                entity.Property(e => e.Id).ValueGeneratedOnAdd().HasColumnName("id");
                entity.Property(e => e.Email).HasColumnName("email");
                entity.Property(e => e.Password).HasColumnName("password");
                entity.Property(e => e.UserId).HasColumnName("userid");
                entity.HasOne(l => l.UserNavigation).WithOne(u => u.LoginNavigation).HasForeignKey<Login>(l => l.UserId).HasConstraintName("login_userid_fkey").OnDelete(DeleteBehavior.NoAction);
            });

            OnModelCreatingPartial(modelBuilder);
        }
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
