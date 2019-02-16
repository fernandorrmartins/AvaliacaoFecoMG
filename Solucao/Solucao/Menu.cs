using FecoMG.Entidade;
using FecoMG.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solucao
{
    public class Menu
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
        /// Armazena a lista de opções do Menu Principal
        /// </summary>
        StringBuilder opcoesMenuPrincipal = new StringBuilder();
        #endregion

        /// <summary>
        /// Método Construtor da Classe Menu
        /// </summary>
        public Menu()
        {
            // Preenche o Menu Princiapl e suas opções
            opcoesMenuPrincipal.Append("############################################# Menu Principal #################################################\n");
            opcoesMenuPrincipal.Append("#                                                                                                            #\n");
            opcoesMenuPrincipal.Append("# (1) Boleto Padrão                                                                                          #\n");
            opcoesMenuPrincipal.Append("# (2) Boleto Personalizado                                                                                   #\n");
            opcoesMenuPrincipal.Append("# (0) Sair                                                                                                   #\n");
            opcoesMenuPrincipal.Append("#                                                                                                            #\n");
            opcoesMenuPrincipal.Append("##############################################################################################################\nDigite sua opção: ");
            apresentarMenu();
        }

        /// <summary>
        /// Função que apresenta o menu para o usuário e gerencia a escolha das opções
        /// </summary>
        public void apresentarMenu()
        {
            Console.Write(opcoesMenuPrincipal);
            cmd = Console.ReadLine(); // Lê a opção digitada pelo usuário

            switch (cmd)
            {
                // Solicitação para Funcionalidades do Boleto Padrão
                case "1":
                    Console.Clear();
                    solicitacaoBoletoPadrao();
                    this.apresentarMenu();
                    cmd = null;
                    break;
                // Solicitação para Funcionalidades do Boleto Personalizado
                case "2":
                    break;
                // Condição para encerrar a solução
                case "0":
                    Console.Clear();
                    Console.WriteLine("Sistema encerrado. Pressione qualquer tecla para fechar...");
                    Console.ReadKey();
                    break;
                // Condição padrão para qualquer opção digitada inválida
                default:
                    Console.Clear();
                    Console.WriteLine("############################################# Opção Invalida #################################################");
                    this.apresentarMenu();
                    break;
            }
        }

        public void solicitacaoBoletoPadrao()
        {
            String cmd = "";                                    // Seleção de Opções do Boleto Padrão pelo Usuário
            while (!cmd.Equals("0"))
            {
                StringBuilder opcoesMenu = new StringBuilder(); // Menu da Solicitação do Boleto Padrão
                opcoesMenu.Append("(1) OPERAÇÃO:    Incluir     |   CÓDIGO: 01\n");
                opcoesMenu.Append("(2) OPERAÇÃO:    Alterar     |   CÓDIGO: 02\n");
                opcoesMenu.Append("(3) OPERAÇÃO:    Baixar      |   CÓDIGO: 03\n");
                opcoesMenu.Append("(4) OPERAÇÃO:    Consultar   |   CÓDIGO: 04\n");
                opcoesMenu.Append("(0) Finalizar Operação\n\n");
                opcoesMenu.Append("Digite sua opção: ");

                Console.Write(opcoesMenu);
                cmd = Console.ReadLine();
                Console.Clear();

                switch (cmd)
                {
                    case "1":
                        new BoletoPadraoNegocio().IncluirBoleto();
                        cmd = "0";
                        Console.Clear();
                        break;
                    case "2":

                        break;
                    case "3":

                        break;
                    case "4":
                        
                        cmd = "0";
                        Console.Clear();
                        break;
                    case "0":
                        Console.Clear();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("############################################# Opção Invalida #################################################");
                        break;
                }
            }
        }
    }
}