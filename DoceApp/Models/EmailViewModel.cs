using DoceApp.Models.Entidades;

namespace DoceApp.Models
{
    public class EmailViewModel
    {
        public string Email { get; }
        public ToastrMessage ReturnMessage { get; set; }
    }
}
