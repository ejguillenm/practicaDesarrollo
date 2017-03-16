using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaDesarrollo
{
    class MoneyParts
    {
        public void Build(decimal target)
        {
            List<decimal> numbers = new List<decimal>() { 0.05m, 0.1m, 0.2m, 0.5m, 1m, 2m, 5m, 10m, 20m, 50m, 100, 200m };
            List<decimal> aux = numbers.OrderBy(x => x).ToList();
             
            sum_up(aux, target);
        }

        private static void sum_up(List<decimal> numbers, decimal target)
        {
            var lst = new List<string>();

            sum_up_recursive(numbers, target, new List<decimal>(), lst);
            Console.ReadKey();
        }

        private static void sum_up_recursive(List<decimal> numbers, decimal target, List<decimal> partial, List<string> lst)
        {
            decimal s = 0;
            foreach (decimal x in partial)
                s += x;

            if (s == target)
            {
                var final = partial.OrderBy(x => x).ToArray();
                if (lst.IndexOf(string.Join(",", final)) == -1)
                {
                    Console.WriteLine("sum(" + string.Join(",", final) + ")=" + target);
                    lst.Add(string.Join(",", final));
                }
            }

            if (s >= target)
                return;

            for (int i = 0; i < numbers.Count; i++)
            {

                List<decimal> remaining = new List<decimal>();

                List<decimal> partial_rec = new List<decimal>(partial);
                for (int nivel = i; nivel < numbers.Count; nivel++)
                {
                    decimal n = numbers[nivel];
                    partial_rec.Add(n);
                    sum_up_recursive(numbers, target, partial_rec, lst);
                }
                for (int j = i + 1; j < numbers.Count; j++)
                    remaining.Add(numbers[j]);

                sum_up_recursive(remaining, target, partial_rec, lst);

            }


        }
    }
}
