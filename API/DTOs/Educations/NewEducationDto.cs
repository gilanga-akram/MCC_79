using System.ComponentModel.DataAnnotations;

namespace API.DTOs.Educations
{
    public class NewEducationDto
    {
        public Guid Guid { get; set; }
        public string Major { get; set; }
        [Required]
        public string Degree { get; set; }
        [Required]
        public double Gpa { get; set; }
        [Required]
        public Guid UniversityGuid { get; set; }
    }
}