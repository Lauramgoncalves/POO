using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO // PROGRAMAÇÃO ORIENTADA A OBJETOS - ESTILO DE PROGRAMAR
{
    class Program
    {
        static void Main(string[] args)

        {
  /* Jogo -> Classe*/ Jogo jogo1 = new Jogo(); // -> new Jogo() -> Objeto
                      jogo1.titulo = "GTA";
                      jogo1.preco = 132.50f;
                      jogo1.produtora = "jsj";
                    
                       jogo1.Abrir();
            Console.ReadLine();

        }
        
    }
}
