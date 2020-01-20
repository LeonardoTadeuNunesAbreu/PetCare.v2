﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using PetCareFinalVersion.Data;

namespace PetCareFinalVersion.Models
{
    public class Post : IPost
    {

        [Key]
        public int Id { get; set; }

        [ForeignKey("Association")]
        public int Association_id { get; set; }
        public Association Association { get; set; }

        [Required]
        [MaxLength(50)]
        public string Title { get; set; }

        [Required]
        [MaxLength(250)]
        public string Description { get; set; }

        public string Image { get; set; }


    }
}
