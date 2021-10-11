using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquazionePrimoGrado
{
    public class CalcoloEquazione
    {
        public List<double> Esegui(int a, int b, int c)
        {
            var delta = Delta(a, b, c);
            var result = new List<double>();

            if (delta == 0)
            {
                var res = -b / 2 * a;
                result.Add(res);
            }
            if (delta > 0)
            {
                var res1 = (-b - Math.Sqrt(delta)) / (2 * a);
                var res2 = (-b + Math.Sqrt(delta)) / (2 * a);
                result.Add(res1);
                result.Add(res2);
            }

            return result;
        }

        private double Delta(int a, int b, int c) => ( b * b ) - (4 * a * c);

        
    }
}
