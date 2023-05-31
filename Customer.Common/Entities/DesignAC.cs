using System.ComponentModel.DataAnnotations;

namespace Customer.Common.Entities
{
    public class DesignAC
    {
        public int Id { get; set; }

        public int VersionId { get; set; }

        [MaxLength(50)]
        public string Site { get; set; }

        public User User { get; set; }

        public Operator Operator { get; set; }

        public Project Project { get; set; }

        public Country Country { get; set; }

        public State State { get; set; }
    }
}
