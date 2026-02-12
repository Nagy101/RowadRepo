using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssiDay07.Classes.Inheritance
{
    public class Child : Parent
    {
        public int Z { get; set; }
        public Child(int _Z, int _X,int _Y):base(_X,_Y)
        {
            Z = _Z;
        }
        #region Method
        override public string ToString()
        {
            return $"X: {X}, Y: {Y}, Z: {Z}";
        }
        public new int Product()
        {
            return X * Y * Z;
        }
        /*#region Override
        public override int Product()
        {
            return X * Y * Z;
        }
        #endregion*/

        #endregion
    }
}
