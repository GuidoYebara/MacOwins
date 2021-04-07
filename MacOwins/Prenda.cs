using System;
using System.Collections.Generic;
using System.Text;

namespace MacOwins
{
    /// <summary>
    /// La clase reprensenta una prenda, con su preciobase, su tipo: saco, pantalon, camisa
    /// codigo y estado.
    /// </summary>
    public class Prenda
    {
        public int codprenda { get; set; }

        public int tipo { get; set; }

        public int estado { get; set; }

        public float preciobase { get; set; }

    }
}
