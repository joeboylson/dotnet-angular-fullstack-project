using System.ComponentModel.DataAnnotations.Schema;

namespace Api.Models
{
    // if I want to use lowercase table names, I need to have this table
    // attribute here changing the name
    // (I prefer lowercase table names)
    [Table("users")]
    public class Users
    {
        public int id { get; set; }
        public required string name { get; set; }
        public required string email { get; set; }
    }
}
