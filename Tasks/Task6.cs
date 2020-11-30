using System.Collections.Generic;
using System.Linq;

namespace Tasks
{
    public class Task6
    {
        /*
         * Dada uma lista de inteiros, crie um método que devolva a proporção de números positos, negativos e zeros, respectivamente.
         * Obs.: Retornar valores com 6 casas decimais
         * Ex.:
         * Entrada:
         * -4 3 -9 0 4 1    
         * Saída: 
         * 0.500000
         * 0.333333
         * 0.166667
         */
        public static List<decimal> GetRatios(List<int> numbers) 
        {
            int totalpos, totalneg, totalz, total;
            decimal proppos, propneg, propz;
            List<decimal> resposta = new List<decimal>();

            total = numbers.Count;

            totalpos = numbers.Where(p => p > 0).Count();
            totalneg = numbers.Where(n => n < 0).Count();
            totalz = numbers.Where(z => z == 0).Count();

            proppos = (decimal)totalpos/total;
            propneg = (decimal)totalneg/total;
            propz = (decimal)totalz/total;

            resposta.Add(decimal.Round(proppos, 6));
            resposta.Add(decimal.Round(propneg, 6));
            resposta.Add(decimal.Round(propz, 6));

            return resposta;
        }
    }
}
