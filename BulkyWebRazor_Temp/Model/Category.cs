﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace BulkyWebRazor_Temp.Model
{
    public class Category
    {
        
            [Key]
            public int Id { get; set; }
            [Required]
            [MaxLength(30)]
            [DisplayName("Catagory Name")]
            public string Name { get; set; }
            [DisplayName("Display Order")]
            [Range(1, 100, ErrorMessage = "Display Order must be between 1-100")]
            public int DisplayOrder { get; set; }
        
    }
}
