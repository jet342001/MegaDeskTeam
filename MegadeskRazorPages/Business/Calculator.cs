using MegadeskRazorPages.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MegadeskRazorPages.Business
{
    public class Calculator
    {
        public static decimal GetCalculatedPrice(Quote quote)
        {
            const int basePrice = 200;
            const int additionalSurfacePrice = 0;

            var deskSurface = quote.DeskDepth * quote.DeskWidth;
            var drawersPrice = quote.DeskDrawers * 50;
            var rushPeriod = quote.RushDays;
            var rushPeriodPrice = 0;
            var materialCost = 0;

            materialCost = (int)quote.DeskMaterialOptions;

            if (deskSurface > 0 && deskSurface < 1000)
            {
                switch (rushPeriod)
                {
                    case 3:
                        rushPeriodPrice = 60;
                        break;
                    case 5:
                        rushPeriodPrice = 40;
                        break;
                    case 7:
                        rushPeriodPrice = 30;
                        break;
                    default:
                        rushPeriodPrice = 0;
                        break;
                }
            }
            else if (deskSurface >= 1000 && deskSurface <= 2000)
            {
                switch (rushPeriod)
                {
                    case 3:
                        rushPeriodPrice = 70;
                        break;
                    case 5:
                        rushPeriodPrice = 50;
                        break;
                    case 7:
                        rushPeriodPrice = 35;
                        break;
                    default:
                        rushPeriodPrice = 0;
                        break;
                }
            }
            else
            {
                switch (rushPeriod)
                {
                    case 3:
                        rushPeriodPrice = 80;
                        break;
                    case 5:
                        rushPeriodPrice = 60;
                        break;
                    case 7:
                        rushPeriodPrice = 40;
                        break;
                    default:
                        rushPeriodPrice = 0;
                        break;
                }
            }

            return
                basePrice +
                additionalSurfacePrice +
                drawersPrice +
                rushPeriodPrice +
                materialCost;
        }
    }
}
