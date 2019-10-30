using System;
using System.Collections.Generic;
using System.Text;

namespace ado.net_hw6
{
    public class Author : Entity
    {
        public string Name { get; set; }
        public Guid bookId { get; set; }
    }
}
