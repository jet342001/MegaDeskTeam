using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace MegaDeskWebApp.Models
{
    public class DeskQuote
    {
        private double _totalPrice;
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
        
        [Display(Name = "Surface Material")]
        [Required]
        public string SurfaceMaterial { get; set; }

        [Display(Name = "Days to Build")]
        [Required]
        public int RushOrderDays { get; set; }

        [Display(Name = "First Name")]
        [Required]
        [StringLength(40, MinimumLength = 1)]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required]
        [StringLength(40, MinimumLength = 1)]
        public string LastName { get; set; }

        //public DateTime QuoteDate => DateTime.Now;
        [DataType(DataType.Date)]
        public DateTime QuoteDate { get; set; }

        [Display(Name = "Total Price")]
        public double TotalPrice
        {
            get
            {
                _totalPrice = _totalPrice == 0 ? CalculateTotalPrice() : _totalPrice;
                return _totalPrice;
            }
            set => _totalPrice = value;
        }


        [NotMapped]
        public double SurfaceArea => Width * Depth;

        [Display(Name = "Customer Name")]
        [NotMapped] 
        public string FullName => FirstName?.Trim() ?? "" + " " + LastName?.Trim() ?? "";

        [NotMapped]
        public static List<SurfaceMaterial> SurfaceMaterials => new()
        {
            new() {Name = "Oak", Price = 200, Url = "https://images-na.ssl-images-amazon.com/images/I/81WZIM51pML._AC_SX425_.jpg" },
            new() {Name = "Laminate", Price = 100, Url = "https://images-na.ssl-images-amazon.com/images/I/71wBWdGQjGL._AC_SX425_.jpg" },
            new() {Name = "Pine", Price = 50, Url = "https://images-na.ssl-images-amazon.com/images/I/61ssllf%2BFNL._AC_SY550_.jpg" },
            new() {Name = "Rosewood", Price = 300, Url = "https://images-na.ssl-images-amazon.com/images/I/814Q0nD33wL._AC_SX425_.jpg" },
            new() {Name = "Veneer", Price = 125, Url = "https://images-na.ssl-images-amazon.com/images/I/71K7-efqklL._AC_SX425_.jpg" }
        };


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

            return basePrice + rushPrice + surfacePrice + drawerPrice;
        }

        public double CalculateSurfacePrice()
        {
            return SurfaceArea > 1000 ? SurfaceArea - 1000 : 0;
        }
        public double CalculateSurfaceMaterialPrice()
        {
            var material = SurfaceMaterials.SingleOrDefault(x => x.Name == SurfaceMaterial);
            return material?.Price ?? 0;
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
        
        public string QuoteToString()
        {
            string stringQuote = "";
            stringQuote = stringQuote + Width + ",";
            stringQuote = stringQuote + Width + ",";
            stringQuote = stringQuote + SurfaceMaterial + ",";
            stringQuote = stringQuote + Drawers + ",";
            stringQuote = stringQuote + RushOrderDays + ",";
            stringQuote = stringQuote + FirstName + ",";
            stringQuote = stringQuote + LastName + ",";
            stringQuote = stringQuote + TotalPrice.ToString("C");
            return stringQuote;
        }
        
    }
}
