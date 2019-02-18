using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FecoMG.Utilitario
{
    /// <summary>
    /// Classe com funções uteis, e gerais
    /// </summary>
    public class Ultilitario
    {
        public static void MensagemErro(string erro)
        {
            Console.Clear();
            Console.WriteLine(erro + "\n\nPressione qualquer tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
