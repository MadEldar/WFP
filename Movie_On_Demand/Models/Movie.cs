using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Movie_On_Demand.Models
{
    public class Movie
    {
        public enum MovieStatuses
        {
            Unreleased = 0,
            Released = 1
        }

        public int ID { get; set; }

        public string Title { get; set; }

        public MovieStatuses Status { get; set; }

        public string Director { get; set; }

        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? ReleasedDate { get; set; } = null;

        public string Genre { get; set; }

        public List<int> Ratings { get; set; }
    }
}
