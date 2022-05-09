﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EasyHome2.Models
{
    public class AddHomeTypeRental
    {
        public int Id { get; set; }

        public int HRCount { get; set; }
        public double AddressLatitude { get; set; }

        public double AddressLongitude { get; set; }

        public string Address { get; set; }

        public string UserName { get; set; }

        [Display(Name = "Contact No.")]
        public string PhoneNumber { get; set; }

        [Display(Name = "Email")]
        public string UserEmail { get; set; }
        
        public HomeTypes HomeTypes { get; set; }

        [Display(Name = "Rental Type")]
        public byte RentalHomeTypeId { get; set; }

        public string City { get; set; }
        public string Location { get; set; }

        [Display(Name = "Title")]
        public string PropertyTitle { get; set; }

        [Display(Name = "Description")]
        public string PropertyDescription { get; set; }

        [Display(Name = "Price")]
        public double PropertyPrice { get; set; }

        [Display(Name = "Land Area")]
        public int PropertyLandArea { get; set; }

        [Display(Name = "Land Area Unit")]
        public string PropertyLandAreaUnit { get; set; }


        public byte Bedrooms { get; set; }
        public byte Bathrooms { get; set; }

        [Display(Name = "Built In Year")]
        public int BuiltinYear { get; set; }

        [Display(Name = "Parking Spaces")]
        public byte ParkingSpaces { get; set; }

        [Display(Name = "Dining Room")]
        public bool DiningRoom { get; set; }

        [Display(Name = "Drawing Room")]
        public bool DrawingRoom { get; set; }
        public byte Kitchens { get; set; }

        [Display(Name = "Ad Removes After")]
        public DateTime ExpiresAfter { get; set; }

        public string UserId { get; set; }

        public List<RentalHomeImages> RentalHomeImages { get; set; }
    }
}