using Main.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Main.Infra.Data.Mapping
{
    public class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Usuario");
            builder.HasKey(x => x.Id);
            builder.Property(c => c.Cpf).IsRequired().HasColumnName("Cpf");
            builder.Property(c => c.BirthDate).IsRequired().HasColumnName("DataNascimento");
            builder.Property(c => c.Name).IsRequired().HasColumnName("Nome");
        }
    }
}