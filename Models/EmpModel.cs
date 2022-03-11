﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CRUDUsingMVC.Models
{
    public class EmpModel
    {









        [Display(Name ="id")]
        public int Empid { get; set; }

        [Required(ErrorMessage ="First name is Required.")]
        public string Name { get; set; }

        [Required(ErrorMessage ="city is required.")]
        public string City { get; set; }

        [Required(ErrorMessage ="Address is required")]
        public string Address { get; set; }

    }
}