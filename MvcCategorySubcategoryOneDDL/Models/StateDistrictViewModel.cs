﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcCategorySubcategoryOneDDL.Models
{
    public class StateDistrictViewModel
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Select District")]
        public string SelectedStateDistrict { get; set; }
    }
}