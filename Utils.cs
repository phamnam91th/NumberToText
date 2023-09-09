using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberToText
{
    internal class Utils
    {
        public static string NumberToText(int num)
        {
            char[] number = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9'};
            string[] text = new string[] { "khong", "mot", "hai", "ba", "bon", "nam", "sau", "bay", "tam", "chin"};
            string str = num.ToString();
            StringBuilder sb = new StringBuilder(str);
            char[] chars = str.ToCharArray();
            
            for (int i = 0; i<str.Length; i++)
            {

            }




            return str;
        }
    }
}
