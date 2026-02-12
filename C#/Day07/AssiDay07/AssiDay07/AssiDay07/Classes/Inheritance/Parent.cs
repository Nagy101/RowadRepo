using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssiDay07.Classes.Inheritance
{
    public class Parent
    {
        #region Auto Prop
        public int X { get; set; }
        public int Y { get; set; }
        #endregion
        #region Constructor
        public Parent(int _X, int _Y)
        {
            X = _X;
            Y = _Y;
        }
        #endregion
        #region Method
        public virtual int Product()
        {
            return X * Y;
        }
        override public string ToString()
        {
            return $"X: {X}, Y: {Y}";
        }
        #endregion
    }
}
