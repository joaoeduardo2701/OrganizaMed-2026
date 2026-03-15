using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OrganizaMed.Dominio.ModuloMedico;

namespace OrganizaMed.Infraestrutura.Orm.ModuloMedico
{
    public class MapeadorMedicoEmOrm : IEntityTypeConfiguration<Medico>
    {
        public void Configure(EntityTypeBuilder<Medico> builder)
        {
            builder.ToTable("TBMedico");
            
            builder.Property(m => m.Id)
                .ValueGeneratedNever();

            builder.Property(m => m.Nome)
                .HasColumnType("nvarchar(100)")
                .IsRequired();

            builder.Property(m => m.Crm)
                .HasColumnType("char(8)")
                .IsRequired();        
        }
    }
}
