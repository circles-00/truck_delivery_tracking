using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Truck_Delivery_Tracking.Models
{
    public class Tasks
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string title { get; set; }
        [Required]
        public string destination { get; set; }
        [Required]
        public float distance { get; set; }
        [Required]
        public DateTime dueDate { get; set; }
        [Required]
        public DateTime departure { get; set; }
        public string cargo_content { get; set; }
        [Required]
        public string cargo_type { get; set; }
        [Required]
        public float cargo_weight { get; set; }
        [Required]
        public string isFinished { get; set; }
        [Required]
        public string driver { get; set; }
    }
}