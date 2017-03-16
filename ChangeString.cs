using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaDesarrollo
{
    class ChangeString
    {
        static void Main(string[] args)
        {
            //var input = "12aBc4*DfrG";

            //Build(input);

            CompleteRange range = new CompleteRange();
            var input2 = new int[4]{1,2,4,9};
            //range.Build(input2);

            MoneyParts money = new MoneyParts();
            money.Build(10m);

        }

        private static void Build(string input)
        {
            var universoString = "a,b,c,d,e,f,g,h,i,j,k l m,n,ñ,o,p,q,r,s,t,u,v,w,x,y,z";

            var universoList = universoString.Split(',').ToList();

            var inputArray = input.ToCharArray().Select(x => x.ToString()).ToList();
            var result = string.Empty;

            result = ProcessingString(universoList, inputArray, result);


            Console.WriteLine(result);
        }

        private static string ProcessingString(List<string> universoChar, List<string> inputArray, string result)
        {
            foreach (var item in inputArray)
            {
                var index = universoChar.IndexOf(item.ToLower());
                if (index == -1)
                    result = result + item;
                else
                {
                    var newIndex = index + 1;
                    newIndex = ValidateIndex(universoChar, newIndex);

                    if (char.IsUpper(item[0]))
                        result = result + universoChar[newIndex].ToUpper();
                    else
                        result = result + universoChar[newIndex];
                }
            }
            return result;
        }

        private static int ValidateIndex(List<string> universoChar, int newIndex)
        {
            if (newIndex >= universoChar.Count())
                newIndex = 0;
            return newIndex;
        }
    }
}
