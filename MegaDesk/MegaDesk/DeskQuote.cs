using System;
using System.Collections.Generic;
using System.Text;

namespace MegaDesk
{
    class DeskQuote
    {
        public DeskQuote()
        {
        }
        public Desk desk;
        public int rushOrderDays;
        public double totalPrice;
        public string customerFirstName;
        public string customerLastName;
        public DateTime quoteDate = DateTime.Now;

        internal bool CheckValidInputs()
        {
            double widthMin = 24;
            double widthMax = 96;
            double depthMin = 12;
            double depthMax = 48;
            if ((desk.width >= widthMin && desk.width <= widthMax) && (desk.depth >= depthMin && desk.depth <= depthMax) && (desk.numDrawers >= 0 && desk.numDrawers <= 7))
            {
                return true;
            }
                return false;
        }

        internal double CalculateTotalPrice()
        {
            double basePrice = 200;
            double rushPrice = CalculateRushPrice();
            double surfacePrice = CalculateSurfacePrice() + CalculateSurfaceMaterialPrice();
            double drawerPrice = CalculateDrawerPrice();
            totalPrice = basePrice + rushPrice + surfacePrice + drawerPrice;
            return totalPrice;
        }

        internal double CalculateSurfacePrice()
        {
            double deskSurfaceArea = desk.GetWidth() * desk.GetDepth();
            if (deskSurfaceArea > 1000)
            {
                return deskSurfaceArea - 1000;
            }
            return 0;
        }
        internal double CalculateSurfaceMaterialPrice()
        {

            if (desk.surfaceMaterialType.ToLower() == "oak")
            {
                return 200;
            }
            else if (desk.surfaceMaterialType.ToLower() == "laminate")
            {
                return 100;
            }
            else if (desk.surfaceMaterialType.ToLower() == "pine")
            {
                return 50;
            }
            else if (desk.surfaceMaterialType.ToLower() == "rosewood")
            {
                return 300;
            }
            else if (desk.surfaceMaterialType.ToLower() == "veneer")
            {
                return 125;
            }
            return 0;
        }

        internal double CalculateDrawerPrice()
        {
            return desk.numDrawers * 50;
        }

        internal double CalculateRushPrice()
        {
            double deskSurfaceArea = desk.GetWidth() * desk.GetDepth();
            if (rushOrderDays == 0)
            {
                return 0;
            }
            else if (rushOrderDays == 3)
            {
                if (deskSurfaceArea < 1000)
                {
                    return 60;
                }
                else if (deskSurfaceArea >= 1000 && deskSurfaceArea <= 2000)
                {
                    return 70;
                }
                return 80;
            }
            else if (rushOrderDays == 5)
            {
                if (deskSurfaceArea < 1000)
                {
                    return 40;
                }
                else if (deskSurfaceArea >= 1000 && deskSurfaceArea <= 2000)
                {
                    return 50;
                }
                return 60;
            }
            else
            {
                if (deskSurfaceArea < 1000)
                {
                    return 30;
                }
                else if (deskSurfaceArea >= 1000 && deskSurfaceArea <= 2000)
                {
                    return 35;
                }
                return 40;
            }
        }

        public double GetTotalPrice()
        {
            CalculateTotalPrice();
            return totalPrice;
        }

        public void SetRushOrderDays(int orderRushOrderDays)
        {
            rushOrderDays = orderRushOrderDays;
        }
        public void SetCustomerFirstName(string orderCustomerFirstName)
        {
            customerFirstName = orderCustomerFirstName;
        }
        public void SetCustomerLastName(string orderCustomerLastName)
        {
            customerLastName = orderCustomerLastName;
        }

        public void SetDesk(Desk orderDesk)
        {
            desk = orderDesk;
        }

        public string QuoteToString()
        {
            string stringQuote = "";
            stringQuote = stringQuote + desk.GetWidth().ToString() + ",";
            stringQuote = stringQuote + desk.GetWidth().ToString() + ",";
            stringQuote = stringQuote + desk.GetSurfaceMaterial().ToLower() + ",";
            stringQuote = stringQuote + desk.GetNumDrawers() + ",";
            stringQuote = stringQuote + this.rushOrderDays.ToString() + ",";
            stringQuote = stringQuote + this.customerFirstName.ToLower() + ",";
            stringQuote = stringQuote + this.customerLastName.ToLower() + ",";
            stringQuote = stringQuote + this.totalPrice.ToString().ToLower();
            return stringQuote;
        }
    }

}

    
