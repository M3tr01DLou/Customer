using System.ComponentModel.DataAnnotations;

namespace Customer.Common.Entities
{
    public class Asp
    {
        public int Id { get; set; }

        [MaxLength(50)]
        public string Name { get; set; }

        [MaxLength(50)]
        public string GenericUserGestDoc { get; set; }

        [MaxLength(150)]
        public string Email { get; set; }
    }
}
