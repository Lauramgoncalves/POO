
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO // PROGRAMAÇÃO ORIENTADA A OBJETOS - ESTILO DE PROGRAMAR
{

     //CLASSIFICAÇÃO - Agrupar coisas semelhantes.
        // * Atributos - são dados da classe, agrupar coisas com caracteristicas/informações em comum, ex: faixa etaria, nome do autor, produtora, preço ou genero. 
        // *Metodos - Açoes da classe, exemplo: Abrir, carregar, fechar, atualizar, ligar, desligar ou executar.

        class Jogo // Classes
        {
            public string titulo;
            public string produtora; // Atributos
            public float preco;


            public void Abrir() // - Função dentro de classe se chama metódo.
            {
                Console.WriteLine("Abrindo..." +titulo);
            }
            public void Carregar()
            {
                Console.WriteLine("Carregando...");
            }
            public void Fechar()
            {
                Console.WriteLine("Aperte ESC para sair...");
            }
        }
    }


// Abstração - Aspectos essenciais de um contexto(aplicação) qualquer.
// * Observar a realidade e dela abstrair entidades, açoes e caracteristicas consideradas essenciais para uma aplicação.



/*Diferença entre classe e objeto
Classe - exp. é um planejamento do ue um carro vai ter, numero de portas, ano, modelo e etc.
Classe - 1 copia.
Objeto - um objeto seria o carro materializado
Objeto - inf copias.*/


/* Static - dá pra criar variaveis globais e usar em todas as partes do programa.
  Exemplo: 
   static public plataforma;
campos estáticos só podem ser acessados pela classe ex. Jogo. , e campos não estáticos só pelos objetos da classe Jogos jogo = new Jogos();
*/


