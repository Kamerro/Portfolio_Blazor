using System.ComponentModel.DataAnnotations;

namespace PortfolioBlazor.Data
{
    public class DisplayModelStudents {

        [Required]
        public string Name { get; set; }
        [Required]
        public int Id { get; set; }
        [Required]
        public int Semester { get; set; }

}
}
