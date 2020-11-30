using System.Collections.Generic;
using System.Linq;

namespace Tasks
{
    public class Task3
    {
        /*
         * Dada a lista de inteiros, retorne o somatório de todos os itens com valor POSITIVO da lista     
         * LEMBRANDO que 0 (zero) NÃO é um número positivo
         */
        public static int GetSum(List<int> list) 
        {
            int sum = 0;

            foreach(int element in list)
            {
                sum += element>0 ? element : 0;
            }

            return sum;
        }
    }
}
