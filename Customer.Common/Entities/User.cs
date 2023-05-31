using System.ComponentModel.DataAnnotations;

namespace Customer.Common.Entities
{
    public class User
    {
        public int Id { get; set; }

        [MaxLength(170)]
        public string Name { get; set; }

        [MaxLength(150)]
        public string Login { get; set; }

        public Asp Asp { get; set; }

        [MaxLength(50)]
        public string Organization { get; set; }

        [MaxLength(150)]
        public bool Administrator { get; set; }
    }
}
