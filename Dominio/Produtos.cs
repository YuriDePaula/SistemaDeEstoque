using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeEstoque.Dominio
{
    public class Produtos
    {
        public long CodBarras { get; set; }
        public string NomeProduto { get; set; }
        public DateTime DataValidade { get; set; }
        public int IdentificacaoPrateleiraEstoque { get; set; }
        public int QuantidadePrateleiraEstoque { get; set; }
        public int IdentificacaoPrateleiraMercado { get; set; }
        public int QuantidadePrateleiraMercado { get; set; }
        public string ResponsavelSetor { get; set; }
        public int IdentificacaoDeMarca { get; set; }

        public MarcaProdutos MarcaIdentificacao { get; set; }
    }
}
