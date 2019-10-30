using System;
using System.Collections.Generic;
using System.Text;

namespace ado.net_hw6
{
    public class Book : Entity
    {
        public string Name { get; set; }
        public Guid AuthorId { get; set; }
        public Guid Lib { get; set; }
        public bool IsFree { get; set; }
        public Guid UserId { get; set; }
    }
}
