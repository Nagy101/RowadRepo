using AssiDay08.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssiDay08.Classes
{
    public class SquareSeries : IShapeSeries
    {
        public int SideLength { get; set; }

        private int _currentShapeArea;
        public int CurrentShapeArea
        {
            get { return _currentShapeArea; }
            set { _currentShapeArea = value; }
        }

        public void GetNextArea()
        {
            SideLength++;
            CurrentShapeArea = SideLength * SideLength;
        }

        public void ResetSeries()
        {
            SideLength = 0;
            CurrentShapeArea = 0;
        }
    }
}
