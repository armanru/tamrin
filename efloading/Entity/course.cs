using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace efloading.Entity
{
    internal class course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Student Student { get; set; }
    }
}
