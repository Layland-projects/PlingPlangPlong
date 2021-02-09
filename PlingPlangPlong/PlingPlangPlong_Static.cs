using System;
using System.Collections.Generic;
using System.Text;

namespace PlingPlangPlong
{
    public static class PlingPlangPlong_Static
    {
        public static string PlingPlangPlong(int input)
        {
            var res = "";
            if (input % 3 == 0)
            {
                res += "Pling";
            }
            if (input % 5 == 0)
            {
                res += "Plang";
            }
            if (input % 7 == 0)
            {
                res += "Plong";
            }
            return !string.IsNullOrEmpty(res) ? res : input.ToString();
        }
    }
}
