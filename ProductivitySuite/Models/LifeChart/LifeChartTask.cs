using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProductivitySuite.Models
{
    public class LifeChartTask
    {
        [Key]
        public int TaskID { get; set; }

        //Foreign key of LifeChartItem
        public int ItemID { get; set; }

        public string TaskName { get; set; }
        public string TaskDescription { get; set; }
        public DateTime DueDate { get; set; }
        public bool isCompleted { get; set; }
    }
}