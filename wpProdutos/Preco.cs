using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    public class Preco
    {
        public int ID { get; set; }
        public int PrecoReal { get; set; }
        public int PrecoPromocional { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFinal { get; set; }
    }
}
