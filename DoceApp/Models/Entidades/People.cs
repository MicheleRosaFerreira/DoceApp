using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoceApp.Models.Entidades
{
    [Table("People")]
    public class People
    {
        [Key]
        public int Id { get; private set; }
        [Required]
        [DataType(DataType.Text)]
        public string Name { get; private set; }
		[DataType(DataType.Date)]
		public DateTime BirthDate { get; private set; }
		[Required]
		public string Celphone { get; private set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string? Email { get; private set; }   
        public Login Login { get; private set; }
        public People(int id, string name, DateTime birthDate, string celphone, Login login)
        {
            Id = id;
            Name = name;
            BirthDate = birthDate;
            Celphone = celphone;
            Login = login;
        }

    }
}
