﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.Dtos
{
    public class CustomerDto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter customer's name.")]
        [System.ComponentModel.DataAnnotations.StringLength(255)]
        public string Name { get; set; }

        public bool IsSubscribedToNewsletter { get; set; }

        // Domain class creates dependency so remove
        //public MembershipType MembershipType { get; set; }
        public MembershipTypeDto MembershipType { get; set; }

        public byte MembershipTypeId { get; set; }  // Will automatically be treated as a foreign key
        
        //[Min18YearsIfAMember]
        public DateTime? Birthdate { get; set; }
    }
}