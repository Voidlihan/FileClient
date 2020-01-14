using System;
using System.Collections.Generic;
using System.Text;

namespace DatabaseFiles
{
    public class File
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
    }
}
