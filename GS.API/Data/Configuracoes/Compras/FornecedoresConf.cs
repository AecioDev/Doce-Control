using GS.API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GS.API.Data.Configuracoes
{
    public class FornecedoresConf : IEntityTypeConfiguration<Fornecedores>
    {
        public void Configure(EntityTypeBuilder<Fornecedores> etd)
        {
            etd.ToTable("Fornecedores");
            etd.HasKey(c => c.FornecedorId).HasName("PK_Fornecedores");
            etd.Property(c => c.FornecedorId).HasColumnName("FornecedorId").ValueGeneratedOnAdd();
            etd.Property(c => c.FornecedorNome).HasColumnName("FornecedorNome").HasMaxLength(100);
            etd.Property(c => c.FornecedorCNPJ).HasColumnName("FornecedorCNPJ").HasMaxLength(14);
            etd.Property(c => c.FornecedorCPF).HasColumnName("FornecedorCPF").HasMaxLength(11);
            etd.Property(c => c.FornecedorContato).HasColumnName("FornecedorContato").HasMaxLength(100);
            etd.Property(c => c.FornecedorTel1).HasColumnName("FornecedorTel1").HasMaxLength(20);
            etd.Property(c => c.FornecedorTel2).HasColumnName("FornecedorTel2").HasMaxLength(20);
            etd.Property(c => c.FornecedorEmail).HasColumnName("FornecedorEmail").HasMaxLength(100);
            etd.Property(c => c.ForCodEndereco).HasColumnName("ForCodEndereco");
        }
    }
}
