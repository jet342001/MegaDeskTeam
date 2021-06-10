using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MegaDeskWebApp.Models
{
    public class DeskQuote
    {

        const double WidthMin = 24;
        const double WidthMax = 96;
        const double DepthMin = 12;
        const double DepthMax = 48;

        public DeskQuote()
        {
        }

        public int Id { get; set; }

        [Required]
        [Range(WidthMin, WidthMax)]
        public double Width { get; set; }
        
        [Required]
        [Range(DepthMin, DepthMax)]
        public double Depth { get; set; }
        
        [Required]
        [Range(0, 7)]
        public int Drawers { get; set; }
        
        [Required]
        public string SurfaceMaterial { get; set; }

        [Required]
        public int RushOrderDays { get; set; }
        
        [Required]
        [StringLength(40, MinimumLength = 1)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(40, MinimumLength = 1)]
        public string LastName { get; set; }


        public DateTime QuoteDate => DateTime.Now;
        public double TotalPrice { get; set; }

        
        [NotMapped]
        public double SurfaceArea => Width * Depth; 


        public bool CheckValidInputs()
        {
            if ((Width >= WidthMin && Width <= WidthMax) && (Depth >= DepthMin && Depth <= DepthMax) && Drawers >= 0 && Drawers <= 7)
            {
                return true;
            }
            return false;
        }

        public double CalculateTotalPrice()
        {
            double basePrice = 200;
            double rushPrice = CalculateRushPrice();
            double surfacePrice = CalculateSurfacePrice() + CalculateSurfaceMaterialPrice();
            double drawerPrice = CalculateDrawerPrice();
            TotalPrice = basePrice + rushPrice + surfacePrice + drawerPrice;
            
            return TotalPrice;
        }

        public double CalculateSurfacePrice()
        {
            if (SurfaceArea > 1000)
            {
                return SurfaceArea - 1000;
            }
            return 0;
        }
        public double CalculateSurfaceMaterialPrice()
        {
            switch (SurfaceMaterial.ToLower())
            {
                case "oak":
                    return 200;
                case "laminate":
                    return 100;
                case "pine":
                    return 50;
                case "rosewood":
                    return 300;
                case "veneer":
                    return 125;
                default:
                    return 0;
            }
        }

        public double CalculateDrawerPrice()
        {
            return Drawers * 50;
        }

        public double CalculateRushPrice()
        {
            switch (RushOrderDays)
            {
                case 0:
                    return 0;
                case 3 when SurfaceArea < 1000:
                    return 60;
                case 3 when SurfaceArea >= 1000 && SurfaceArea <= 2000:
                    return 70;
                case 5 when SurfaceArea < 1000:
                    return 40;
                case 5 when SurfaceArea >= 1000 && SurfaceArea <= 2000:
                    return 50;
                default:
                {
                    switch (SurfaceArea)
                    {
                        case < 1000:
                            return 30;
                        case >= 1000 and <= 2000:
                            return 35;
                        default:
                            return 40;
                    }
                }
            }
        }

        public double GetTotalPrice()
        {
            CalculateTotalPrice();
            return TotalPrice;
        }

        public string QuoteToString()
        {
            string stringQuote = "";
            stringQuote = stringQuote + Width + ",";
            stringQuote = stringQuote + Width + ",";
            stringQuote = stringQuote + SurfaceMaterial.ToLower() + ",";
            stringQuote = stringQuote + Drawers + ",";
            stringQuote = stringQuote + RushOrderDays + ",";
            stringQuote = stringQuote + FirstName.ToLower() + ",";
            stringQuote = stringQuote + LastName.ToLower() + ",";
            stringQuote = stringQuote + TotalPrice.ToString().ToLower();
            return stringQuote;
        }
        
    }
}
