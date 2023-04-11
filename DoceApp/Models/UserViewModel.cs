using DoceApp.Models.Entidades;

namespace DoceApp.Models
{
    public class UserViewModel : User
    {
        public ToastrMessage? ReturnMessage { get; set; }
    }
}
