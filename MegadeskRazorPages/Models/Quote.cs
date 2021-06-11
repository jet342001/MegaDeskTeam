using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MegadeskRazorPages.Models
{
    public enum DeskMaterialOptions
    {
        Oak = 200,
        Laminate = 100,
        Pine = 50,
        Rosewood = 300,
        Veneer = 150
    }

    public class Quote
    {

        public int ID { get; set; }

        public string CustomerName { get; set; }

        [Required]
        [Range(12, 48)]
        public int DeskDepth { get; set; }

        public int Size { get; set; }

        public int DeskDrawers { get; set; }

        [Required]
        [Range(24, 96)]
        public int DeskWidth { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }

        public int RushDays { get; set; }

        public DeskMaterialOptions DeskMaterialOptions { get; set; }

        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        
    }
}
