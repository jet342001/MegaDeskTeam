using System;
using System.Collections.Generic;
using System.Text;

namespace MegaDesk
{
    public class Desk
    {

        public double width;
        public double depth;
        public int numDrawers;
        public string surfaceMaterialType;

        public Desk()
        {

        }

        public double CalulateSurfaceArea()
        {
            return depth * width;
        }

        public int GetNumDrawers()
        {
            return numDrawers;
        }

        public double GetWidth()
        {
            return width;
        }

        public double GetDepth()
        {
            return depth;
        }

        public string GetSurfaceMaterial()
        {
            return surfaceMaterialType;
        }

        public void SetNumDrawers(int deskNumDrawers)
        {
            numDrawers = deskNumDrawers;
        }

        public void SetWidth(double deskWidth)
        {
            width = deskWidth;
        }

        public void SetDepth(double deskDepth)
        {
            depth = deskDepth;
        }

        public double SetSurfaceArea()
        {
            return width * depth;
        }
        public void SetSurfaceMaterial(string deskSurfaceMaterialType)
        {
            surfaceMaterialType = deskSurfaceMaterialType;
        }
    }
}
