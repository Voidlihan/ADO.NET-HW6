using System;
using System.Collections.Generic;
using System.Text;

namespace ado.net_hw6
{
    public class User : Entity
    {
        public string Name { get; set; }
        public int Debtor { get; set; }
        public Guid Lib { get; set; }
    }
}
