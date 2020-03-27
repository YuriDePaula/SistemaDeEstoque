using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeEstoque.Dominio
{
    public class MarcaProdutos
    {
        public int IdentificacaoDeMarca { get; set; }
        public string NomeMarca { get; set; }
        public virtual List<Produtos> Produtos { get; set; }
    }
}
