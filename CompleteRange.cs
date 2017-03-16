using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaDesarrollo
{
    public class CompleteRange
    {
        public void Build(int[] input)
        {

            var inputList = input.ToList();

            var maxValue = inputList.Max(x => x);
            List<int> result = new List<int>();

            for (var i = 1; i < maxValue+1; i++)
            {
                if (inputList.IndexOf(i) != -1)
                    result.Add(i + 10);
                else
                    result.Add(i);
            }

            Console.WriteLine(result.ToString());
            Console.ReadKey();

        }
    }
}
