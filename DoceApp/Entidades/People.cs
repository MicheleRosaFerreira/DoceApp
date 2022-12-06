using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoceApp.Entidades
{
    public class People
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public DateTime BirthDate { get; private set; }
        public string Celphone { get; private set; }

        public Login Login { get; private set; }
        public People(int id, string name, DateTime birthDate, string celphone)
        {
            Id = id;
            Name = name;
            BirthDate = birthDate;
            Celphone = celphone;
        }

    }
}
