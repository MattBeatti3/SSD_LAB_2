using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SSD_LAB_2.Models
{
    public class Team
    {

        [Key]
        [Required, Display(Name = "Id")]
        public int Id { get; set; }

        [Required, Display(Name = "Team Name")]
        public string TeamName { get; set; }

        [Required, DataType(DataType.EmailAddress), Display(Name = "Email")]
        public string Email { get; set; }

        [DataType(DataType.Date), Display(Name = "Established Date")]
        public string EstablishedDate { get; set; }
    }
}
