﻿using System;
using PetCareFinalVersion.Models;

namespace PetCareFinalVersion.Data
{
    public interface IAssoc
    {
         int Id { get; set; }
        
         string Iban { get; set; }
  
         string Adress { get; set; }
     
         string PhoneNumber { get; set; }

         string Description { get; set; }

         string FoundationDate { get; set; }

         int User_id { get; set; }
         User User { get; set; }

    }
}