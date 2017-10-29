using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    public class ProdutoSku : Base
    {
        public int IDSku { get; set; }
        public string CodSkuExterno { get; set; }
        public int SkuEstoque { get; set; }
        public int SkuPeso { get; set; }
        public List<Propiedades> Propiedade { get; set; } 

    }
}
