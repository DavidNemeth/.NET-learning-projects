﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SzereloCegApp.Models
{
    public class Diagnosztika
    {
        public int ID { get; set; }
        [Required]
        [Display(Name = "Meghibásodás")]
        public string HibaNeve { get; set; }
        [Required]
        [Display(Name = "Munkaidő")]
        public int MunkaIdo { get; set; }
        [Required]        
        [Display(Name = "Anyagköltésg")]
        public decimal Anyagköltseg { get; set; }
        public virtual ICollection<GepJarmu> GepJarmuvek { get; set; }
    }
}