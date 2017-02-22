using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations; 


namespace NMHASurvey.Models
{
    public class Survey
    {
        [Key]
        public int surveyId { get; set; }
        [Required]
        public DateTime submitDate { get; set; }
        [Required]
        public int payerId { get; set; }
        [Required]
       
        public int hospitalId { get; set; }
        [Required]
        public string contactName { get; set; }
        [Required]
        public string contactEmail { get; set; }
        [Required]
        public string contactPhone { get; set; }
        [Required]
        [StringLength(500, ErrorMessage = "The description is not to be greater than 500 characters.")]
        public string description { get; set; }
        [Required]
        [StringLength(500, ErrorMessage = "The description is not to be greater than 500 characters.")]
        public string mcoResponse { get; set; }
        [Required]
        [StringLength(500, ErrorMessage = "The description is not to be greater than 500 characters.")]
        public string claimNumbers { get; set; }

        [ForeignKey("payerId")]
        public Payer payer { get; set; }

        [ForeignKey("hospitalId")]
        public Hospital hospital { get; set; }

    }

    public class Payer
    {
        [Key]
        public int payerId { get; set; }
        [Required]
        public string payerName { get; set; }
    }
    public class Hospital
    {
        [Key]
        public int hospitalId { get; set; }
        [Required]
        public string hospitalName { get; set; }
    }
}