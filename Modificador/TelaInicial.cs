namespace Modificador
{
    public class TelaInicial
    {

        public void Display(){

            System.Console.WriteLine("Insira a opão desejada: \n1.Adicionar\n2.Ver os produtos adicionados\n3.Preço total dos produtos selecionados.\n4.Remover produto");
            int opcao = int.Parse(Console.Readline());

            while (opcao != 4)
            {
                case 1:
                Opcoes.Adicionar();
                break;

                case 2:
                Opcoes.Ver();
                break;

                case 3:
                Opcoes.Preco();

                case 4:
                Opcoes.Remover()

                break;
                
            }

           


        }

        
    }

}