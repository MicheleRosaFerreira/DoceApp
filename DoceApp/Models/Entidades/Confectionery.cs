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
        [Key]
        public int Id { get; private set; }
        [Required]
        [DataType(DataType.Text)]
        public string Name { get; private set; }
		[Required]
		public double Price { get; private set; }
		[Required]
		public double Weight { get; private set; }
		[Required]
		[DataType(DataType.Text)]
		public string Filling { get; private set; }
		[Required]
		[DataType(DataType.Text)]
		public string Ingredients { get; private set; }
		[Required]
		[DataType(DataType.Text)]
		public string Description { get; private set; }

    }
}
