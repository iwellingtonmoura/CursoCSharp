using System;
namespace System // Usando o próprio namespace do tipo para disponibilizar o Extension Methods

{
    static class StringExtensions
    {

        public static string cut(this string thisObj, int count)
        {
            if(thisObj.Length <= count)
            {
                return thisObj;
            }
            else
            {
                return thisObj.Substring(0, count) + "...";
            }
        }

    }
}
