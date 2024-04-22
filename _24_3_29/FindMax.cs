using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject._24_3_29
{
    internal class FindMax
    {

        public T FindMaxValue<T>(T x, T  y, T z) where T : IComparable<T>  // ***********
        {
            //if ( x is string )
            if ( typeof(T) == typeof(string) ) 
            { 
                string strX = x as string;
                string strY = y as string;
                string strZ = z as string;
                if (strX != null && strY != null && strZ != null)
                    return strX.Length.CompareTo(strY.Length) >= 0 && strX.Length.CompareTo(strZ.Length) >= 0 ? x :
                        strY.Length.CompareTo(strZ.Length) >= 0 ? y : z;
                else  // no need
                    throw new ArgumentException("Invalid type arguument passed for string comparision");
            }
            else 
                return x.CompareTo(y)>= 0 && x.CompareTo(z)>= 0 ? x : y.CompareTo(z)>=0 ? y : z;
        }
        /************** instanceOf operator
         * 1. if (myObject is MyClass){}  -> 'is' means instanceOf = bool type => true/false
         * 2. if (typeof(myObject Type) == typeoff(MyClass)){}
         * 3. MyClass myInstance = myObject as MyClass; -> 'as' means cast statement = MyClass type => MyClass, 
         * if fails then myInstance=null
         * if (myInstance != null ){}
         */
        public int FindMaxNumber(int x, int y, int z)
        {
            return (x > y && x > z) ? x : (y > z) ? y : z;
        }

        public float FindMaxNumber(float x, float y, float z)
        {
            return x > y && x > z ? x : y > z ? y : z;
        }

        public string FindMaxString(string str1, string str2, string str3)
        {
            return str1.Length.CompareTo(str2.Length) > 0 && str1.Length.CompareTo(str3.Length) > 0 ? str1 :
                str2.Length.CompareTo(str3.Length) > 0 ? str2 : str3;
        }
    }
}
