using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoceApp.Models.Entidades
{
    public class Confectionery
    {
        public int Id { get;  set; }
		public int Departament_Id { get; set; }
        public string Name { get;  set; }
		public decimal Price { get; set; }
		public string Description { get; set; }
		public string Weight { get; set; }
		public string Link { get; set; }
		public Departament departament { get; set; }

		public Confectionery(string name,decimal price, string description)
		{
			Name = name;
			Price = price;
			Description = description;
		}
		public Confectionery(int id)
		{
			Departament_Id= id;
		}
	}
}
