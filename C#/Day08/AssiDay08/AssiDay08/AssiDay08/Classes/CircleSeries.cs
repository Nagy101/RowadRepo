using AssiDay08.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssiDay08.Classes
{
    public class CircleSeries : IShapeSeries
    {
        public int Radius { get; set; }
        private int _currentShapeArea;
        public int CurrentShapeArea
        {
            get { return _currentShapeArea; }
            set { _currentShapeArea = value; }
        }

        public void GetNextArea()
        {
            Radius++;
            _currentShapeArea = (int)(Math.PI * Radius * Radius);
        }

        public void ResetSeries()
        {
            Radius = 0;
            _currentShapeArea = 0;
        }
    }
}
