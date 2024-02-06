using System.ComponentModel.DataAnnotations.Schema;

namespace RocketseatAuction.API.Entities
{
    [Table("Users")]
    public class User
    {
        public int Id { get; set; }

        public string Name { get; set; }


        public string Email { get; set; }
    }
}
