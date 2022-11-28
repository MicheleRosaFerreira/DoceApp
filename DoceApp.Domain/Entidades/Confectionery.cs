using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoceApp.Domain.Entidades
{
    public class Confectionery
    {

        public int Id { get; private set; }
        public string Name { get; private set; }
        public double Price { get; private set; }
        public double Weight { get; private set; }
        public string Filling { get; private set; }
        public string Ingredients { get; private set; }
        public string Description { get; private set; }

    }
}
