namespace Modificador
{
    public static class Produto
    {
        public double preco;

        public string nome;

        private list<Produto> produtos = new list();

        public string ToString(){
            return "" +nome + preco+ "";
       }
         

    }
}