using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solucao
{
    protected class Menu
    {
        /// <summary>
        /// Classe Responsável por Gerenciar o Menu e suas Opções
        /// </summary>
        #region Atributos da Classe
        /// <summary>
        /// Vairável que controla o fluxo do menu. Recebe o comando do usuário
        /// </summary>
        String cmd;
        /// <summary>
        /// Armazena a lista de opções
        /// </summary>
        StringBuilder opcoesMenu = new StringBuilder();
        #endregion

        /// <summary>
        /// Método Construtor da Classe Menu
        /// </summary>
        public Menu()
        {
            opcoesMenu.Append("############################################# Menu Principal #################################################\n");
            opcoesMenu.Append("#                                                                                                            #\n");
            opcoesMenu.Append("# (1)                                                                                       #\n");
            opcoesMenu.Append("# (2)                                                                                  #\n");
            opcoesMenu.Append("# (0) Sair                                                                                                   #\n");
            opcoesMenu.Append("#                                                                                                            #\n");
            opcoesMenu.Append("##############################################################################################################\nDigite sua opção: ");
            apresentarMenu();
        }

        /// <summary>
        /// Função que apresenta o menu para o usuário e gerencia a escolha das opções
        /// </summary>
        public void apresentarMenu()
        {
            Console.Write(opcoesMenu);
            cmd = Console.ReadLine();

            // 
            if (cmd.Equals("1"))
            {
                Console.Clear();



                this.apresentarMenu();
            }
            // 
            else if (cmd.Equals("2"))
            {
                Console.Clear();



                this.apresentarMenu();
            }
            // Condição para encerrar a solução
            else if (cmd.Equals("0"))
            {
                Console.Clear();
                Console.WriteLine("Sistema encerrado. Pressione qualquer tecla para fechar...");
                Console.ReadKey();
            }
            // Condição padrão para qualquer opção digitada inválida
            else
            {
                Console.Clear();
                Console.WriteLine("############################################# Opção Invalida #################################################");
                this.apresentarMenu();
            }
        }
    }
}