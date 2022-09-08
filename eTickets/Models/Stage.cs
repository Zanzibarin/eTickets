﻿using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Stage
    {
        [Key]
        public int Id { get; set; }
        public string Logo { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        //Relationships
        public List<Play> Plays { get; set; }
    }
}
