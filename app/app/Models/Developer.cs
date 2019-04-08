using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace app.Models
{
    public class Developer
{
        [Range(0, 50, ErrorMessage = "Please enter valid integer Number")]
        public int Id { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Please enter valid integer Number")]
        public string Given { get; set; }

    public string Family { get; set; }

    public string GraduationTerm { get; set; }

    public string DesiredPosition { get; set; }

    public string Skills { get; set; }

        [Range(0, 20, ErrorMessage = "Please enter valid integer Number")]
        public int Rating { get; set; }

    [Display(Name = "Created Date")]
    [DataType(DataType.Date)]
    [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
    public DateTime CreatedDate { get; set; }

}
}
