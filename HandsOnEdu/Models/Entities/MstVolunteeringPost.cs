using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HandsOnEdu.Models.Entities
{
    [Table("MST_VolunteeringPost")]

    public class MstVolunteeringPost
    {
        [Key]
        public int Id { get; set; }
        public Guid NewId { get; set; }
        public string Title { get; set; }
        public string ImageUrl { get; set; } 
        public string Location { get; set; }
        public string VolunteeringType { get; set; }
        public DateTime PostDeadline { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string HeldBy { get; set; }
        public int VolunteersNeeded { get; set; }
        public string Description { get; set; }
        public string VolunteerCriteria { get; set; }
        public string Benefits { get; set; }
        public string Hashtag { get; set; }
        public bool IsActive { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }

    }
}
