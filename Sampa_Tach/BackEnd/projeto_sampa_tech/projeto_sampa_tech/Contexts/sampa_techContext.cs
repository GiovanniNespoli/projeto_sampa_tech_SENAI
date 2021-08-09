using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using projeto_sampa_tech.Domains;

#nullable disable

namespace projeto_sampa_tech.Contexts
{
    public partial class sampa_techContext : DbContext
    {
        public sampa_techContext()
        {
        }

        public sampa_techContext(DbContextOptions<sampa_techContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Equipamento> Equipamentos { get; set; }
        public virtual DbSet<Sala> Salas { get; set; }
        public virtual DbSet<SalaEquip> SalaEquips { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }
        public object Sala { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-G7BQL8U\\SQLEXPRESS; Initial Catalog= Sampa_tech; user Id=sa; pwd=senai@132;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Latin1_General_CI_AS");

            modelBuilder.Entity<Equipamento>(entity =>
            {
                entity.HasKey(e => e.IdEquipamento)
                    .HasName("PK__Equipame__75940D34E5F81DF1");

                entity.ToTable("Equipamento");

                entity.Property(e => e.IdEquipamento).HasColumnName("idEquipamento");

                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Marca)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroPatrimonio)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroSerie)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.TipoEquipamento)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Sala>(entity =>
            {
                entity.HasKey(e => e.IdSala)
                    .HasName("PK__Sala__C4AEB19C49D4E407");

                entity.ToTable("Sala");

                entity.Property(e => e.IdSala).HasColumnName("idSala");

                entity.Property(e => e.Andar)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MetragemSala)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SalaEquip>(entity =>
            {
                entity.HasKey(e => e.IdSalaEquip)
                    .HasName("PK__SalaEqui__F522D2522DA10DCE");

                entity.ToTable("SalaEquip");

                entity.Property(e => e.IdSalaEquip).HasColumnName("idSalaEquip");

                entity.Property(e => e.DataEntrada).HasColumnType("date");

                entity.Property(e => e.DataSaida).HasColumnType("date");

                entity.Property(e => e.IdEquipamento).HasColumnName("idEquipamento");

                entity.Property(e => e.IdSala).HasColumnName("idSala");

                entity.HasOne(d => d.IdEquipamentoNavigation)
                    .WithMany(p => p.SalaEquips)
                    .HasForeignKey(d => d.IdEquipamento)
                    .HasConstraintName("FK__SalaEquip__idEqu__33D4B598");

                entity.HasOne(d => d.IdSalaNavigation)
                    .WithMany(p => p.SalaEquips)
                    .HasForeignKey(d => d.IdSala)
                    .HasConstraintName("FK__SalaEquip__idSal__32E0915F");
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(e => e.IdUsuario)
                    .HasName("PK__Usuario__645723A660B74A30");

                entity.ToTable("Usuario");

                entity.HasIndex(e => e.Email, "UQ__Usuario__A9D105342893FEB0")
                    .IsUnique();

                entity.Property(e => e.IdUsuario).HasColumnName("idUsuario");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.NomeUsuario)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("nomeUsuario");

                entity.Property(e => e.Senha)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
