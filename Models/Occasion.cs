using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ActivityCenter.Models
{
    public class  FutureDateAttribute : ValidationAttribute
    { 
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value is DateTime)
            {
                if ((DateTime)value >= DateTime.Today)
                {
                    return ValidationResult.Success;
                }
                else
                {
                    return new ValidationResult("Please select a valid date, past dates are not accepted.");
                }
            }
            else
            {
                return new ValidationResult("Not a valid date.");
            }

        }

    }
    
    [Table("occasions")]
    public class Occasion
    {

        [Key]
        public int OccasionId { get; set; }
        [Required(ErrorMessage = "Name is required.")]
        public string Title { get; set; }

        [Required]
        [FutureDate(ErrorMessage = "Please select a valid date, past dates are not accepted.")]
        [DataType(DataType.DateTime)]
        public DateTime Date { get; set; }

        [Required(ErrorMessage = "Field is required.")]
        public TimeSpan Time {get;set;}

        [Required(ErrorMessage = "Field is required.")]
        public int Duration { get; set; }

        [Required(ErrorMessage = "Field is required.")]
        public string DurationType {get;set;}

        [Required(ErrorMessage = "Description is required.")]
        [MinLength(5, ErrorMessage = "Description must be at least 5 characters long.")]
        public string Description { get; set; }


        public User Coordinator { get; set; }
        public int UserID { get; set; }


        public List<Join> Attendees { get; set; }
        public DateTime CreatedAt { get; set; }=DateTime.Now;
        public DateTime UpdatedAt { get; set; } =DateTime.Now;
         public void Display()
        {
            Console.WriteLine($"{Title} {Date} {Duration} {Description}");
        }
    }
    
}