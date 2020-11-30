using System.Collections.Generic;
using System.Linq;
using Tasks.HelpClasses;

namespace Tasks
{
    public class Task7
    {
        /*
         * Desenvolma um método que retorne o nome dos produtos que estão com estoque zerado
         * Dica: A classe Repository possui as informções dos Products
         */
        public static List<string> GetProductsOutOfStock() 
        {
            Repository repositorio = new Repository();
            List<string> nomes;

            nomes = repositorio.Products.Where(p => p.Stock.Quantity == 0).Select(p => p.Name).ToList();
            return nomes;

        }

        /*
        * Desenvolma um método que retorne a soma total das quantidades de estoque dos itens
        * Dica: A classe Repository possui as informções dos Products
        */
        public static int GetSumStock() 
        {
            Repository repositorio = new Repository();
            int sum=0;
            foreach(Product produto in repositorio.Products)
            {
                sum+= produto.Stock.Quantity;
            }
            return sum;
        }

        /*
         * Crie um método que verifique, dado Id e quantidade solicitada do produto
         * se o mesmo possui quantidade em estoque para venda
         * Dica: A classe Repository possui as informções dos Products
         * 
         */
        public static bool IsSalePossible(int productId, int orderQuantity) 
        {
            Repository repositorio = new Repository();

            Product produto = repositorio.Products.Where(prod => prod.Id == productId).FirstOrDefault();

            return produto.Stock.Quantity >= orderQuantity ? true : false;
        }
    }
}
