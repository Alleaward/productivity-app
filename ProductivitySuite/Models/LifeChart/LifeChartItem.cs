using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProductivitySuite.Models
{
    public class LifeChartItem
    {
        [Key]
        public int ItemID { get; set; }
        public string UserID { get; set; }
        public int ItemType { get; set; } // Day, Week, Month, Year
        public List<LifeChartTask> Tasks { get; set; }
    }
}