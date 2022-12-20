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
        public string Name { get;  set; }
		public double Price { get;  set; }
		public double Weight { get;  set; }
		public string Filling { get;  set; }
		public string Ingredients { get;  set; }
		public string Description { get;  set; }

		public Confectionery(int id, string name, double price, double weight, string filling, string ingredients, string description)
		{
			Id = id;
			Name = name;
			Price = price;
			Weight = weight;
			Filling = filling;
			Ingredients = ingredients;
			Description = description;
		}
	}
}
