using System;

namespace PlingPlangPlong
{
    public class PlingPlangPlong_Object
    {
        public string Result { get; }

        public PlingPlangPlong_Object(int input)
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
            Result = !string.IsNullOrEmpty(res) ? res : input.ToString();
        }
    }
}
