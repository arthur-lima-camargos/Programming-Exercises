using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioProposto2
{
    public class Operações
    {
        public void RetiraSenha(int X, Queue<int> Fila)
        {
            Fila.Enqueue(X);
            Console.WriteLine($"A Senha ({X}) foi retirada...");
        }
        public void AtendeSenha(Queue<int> Fila)
        {
            int Aux = Fila.Dequeue();
            Console.WriteLine($"A Senha {Aux} atendida...");
            Console.ReadKey();
        }
    }
}
