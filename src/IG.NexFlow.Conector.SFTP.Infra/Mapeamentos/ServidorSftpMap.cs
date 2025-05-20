using IG.NexFlow.Conector.SFTP.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IG.NexFlow.Conector.SFTP.Infra.Mapeamentos
{
    public class ServidorSftpMap : IEntityTypeConfiguration<ServidorSftp>
    {
        public void Configure(EntityTypeBuilder<ServidorSftp> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Nome)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.Property(p => p.Host)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.Property(p => p.Porta)
                .IsRequired();

            builder.Property(p => p.Usuario)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.Property(p => p.Senha)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.Property(p => p.SenhaSalt)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.ToTable("ServidorSftp");
        }
    }
}
