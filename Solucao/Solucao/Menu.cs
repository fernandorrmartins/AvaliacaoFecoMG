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
            // Preenche variável responsavel pelos comandos com vazio
            cmd = "";
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
            while (!cmd.Equals("0"))
            {
                Console.Write(opcoesMenuPrincipal);
                cmd = Console.ReadLine(); // Lê a opção digitada pelo usuário

                switch (cmd)
                {
                    // Solicitação para Funcionalidades do Boleto Padrão
                    case "1":
                        Console.Clear();
                        solicitacaoBoletoPadrao();
                        cmd = "";
                        break;
                    // Solicitação para Funcionalidades do Boleto Personalizado
                    case "2":
                        Console.Clear();
                        solicitacaoBoletoPersonalizado();
                        cmd = "";
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
                        break;
                }
            }
        }

        #region Métodos para Boleto Padrão
        /// <summary>
        /// Método para apresentar menu das opções do Boleto Padrão
        /// </summary>
        public void solicitacaoBoletoPadrao()
        {
            BoletoPadraoEntidade boleto = new BoletoPadraoEntidade(); // Objeto BoletoPadrao
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

                // Casos de Opção do Menu
                switch (cmd)
                {
                    case "1":
                        if (IncluirBoleto(boleto))
                            Console.WriteLine("Solicitação efetuada com sucesso!");
                        cmd = "0";
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "2":
                        if (AlterarBoleto(boleto))
                            Console.WriteLine("Solicitação efetuada com sucesso!");
                        break;
                    case "3":
                        if (BaixarBoleto(boleto))
                            Console.WriteLine("Solicitação efetuada com sucesso!");
                        break;
                    case "4":
                        if (ConsultarBoleto(boleto))
                            Console.WriteLine("Solicitação efetuada com sucesso!");
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

        /// <summary>
        /// Método para incluir boleto padrão
        /// </summary>
        /// <returns></returns>
        public bool IncluirBoleto(BoletoPadraoEntidade boleto)
        {
            // Interação com Usuário
            Console.Write("Número do Documento: ");
            boleto.NumeroDocumento = Console.ReadLine();
            Console.Write("Valor do boleto: ");
            boleto.ValorBoleto = Console.ReadLine();
            Console.Write("Valor do desconto: ");
            boleto.ValorDesconto = Console.ReadLine();
            Console.Write("Valor do abatimento: ");
            boleto.ValorAbatimento = Console.ReadLine();
            Console.Write("Nosso número: ");
            boleto.NossoNumero = Console.ReadLine();
            Console.Write("Linha digitável: ");
            boleto.LinhaDigitavel = Console.ReadLine();
            Console.Write("Data de vencimento: ");
            boleto.DataVencimento = Console.ReadLine();

            // Define o Tipo de Operação
            boleto.CodigoOperacao = FecoMG.Enumerador.BoletoPadraoEnum.Incluir;

            return new BoletoNegocio().IncluirBoleto(boleto);
        }

        /// <summary>
        /// Método para Alterar boleto padrão
        /// </summary>
        /// <returns></returns>
        public bool AlterarBoleto(BoletoPadraoEntidade boleto)
        {
            // Interação com Usuário
            Console.Write("Número do Documento a ser alterado: ");
            boleto.NumeroDocumento = Console.ReadLine();
            Console.Write("Valor do boleto: ");
            boleto.ValorBoleto = Console.ReadLine();
            Console.Write("Valor do desconto: ");
            boleto.ValorDesconto = Console.ReadLine();
            Console.Write("Valor do abatimento: ");
            boleto.ValorAbatimento = Console.ReadLine();
            Console.Write("Nosso número: ");
            boleto.NossoNumero = Console.ReadLine();
            Console.Write("Linha digitável: ");
            boleto.LinhaDigitavel = Console.ReadLine();
            Console.Write("Data de vencimento: ");
            boleto.DataVencimento = Console.ReadLine();

            // Define o Tipo de Operação
            boleto.CodigoOperacao = FecoMG.Enumerador.BoletoPadraoEnum.Alterar;

            return new BoletoNegocio().AlterarBoleto(boleto);
        }

        /// <summary>
        /// Método para Baixar boleto padrão
        /// </summary>
        /// <returns></returns>
        public bool BaixarBoleto(BoletoPadraoEntidade boleto)
        {

            // Interação com Usuário
            Console.Write("Número do Documento a ser baixado: ");
            boleto.NumeroDocumento = Console.ReadLine();

            // Define o Tipo de Operação
            boleto.CodigoOperacao = FecoMG.Enumerador.BoletoPadraoEnum.Baixar;

            return new BoletoNegocio().BaixarBoleto(boleto);
        }

        /// <summary>
        /// Método para Consultar boleto padrão
        /// </summary>
        /// <returns></returns>
        public bool ConsultarBoleto(BoletoPadraoEntidade boleto)
        {

            // Interação com Usuário
            Console.Write("Número do Documento a ser consultado: ");
            boleto.NumeroDocumento = Console.ReadLine();

            // Define o Tipo de Operação
            boleto.CodigoOperacao = FecoMG.Enumerador.BoletoPadraoEnum.Consultar;

            return new BoletoNegocio().BaixarBoleto(boleto);
        }
        #endregion

        #region Métodos para Boleto Personalizado
        /// <summary>
        /// Método para apresentar menu das opções do Boleto Personalizado
        /// </summary>
        public void solicitacaoBoletoPersonalizado()
        {
            BoletoPersonalizadoEntidade boleto = new BoletoPersonalizadoEntidade(); // Objeto BoletoPersonalizado
            String cmd = "";                                    // Seleção de Opções do Boleto Personalizado pelo Usuário
            while (!cmd.Equals("0"))
            {
                StringBuilder opcoesMenu = new StringBuilder(); // Menu da Solicitação do Boleto Personalizado
                opcoesMenu.Append("(1) OPERAÇÃO:    Incluir     |   CÓDIGO: 02\n");
                opcoesMenu.Append("(2) OPERAÇÃO:    Modificar   |   CÓDIGO: 01\n");
                opcoesMenu.Append("(3) OPERAÇÃO:    Baixar      |   CÓDIGO: 04\n");
                opcoesMenu.Append("(4) OPERAÇÃO:    Consultar   |   CÓDIGO: 05\n");
                opcoesMenu.Append("(0) Finalizar Operação\n\n");
                opcoesMenu.Append("Digite sua opção: ");

                Console.Write(opcoesMenu);
                cmd = Console.ReadLine();
                Console.Clear();

                // Casos de Opção do Menu
                switch (cmd)
                {
                    case "1":
                        if (IncluirBoleto(boleto))
                            Console.WriteLine("Solicitação efetuada com sucesso!");
                        cmd = "0";
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "2":
                        if (AlterarBoleto(boleto))
                            Console.WriteLine("Solicitação efetuada com sucesso!");
                        break;
                    case "3":
                        if (BaixarBoleto(boleto))
                            Console.WriteLine("Solicitação efetuada com sucesso!");
                        break;
                    case "4":
                        if (ConsultarBoleto(boleto))
                            Console.WriteLine("Solicitação efetuada com sucesso!");
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

        /// <summary>
        /// Método para incluir boleto presonalizado
        /// </summary>
        /// <returns></returns>
        public bool IncluirBoleto(BoletoPersonalizadoEntidade boleto)
        {
            // Interação com Usuário
            Console.Write("Número do Documento: ");
            boleto.NumeroDocumento = Console.ReadLine();
            Console.Write("Valor do boleto: ");
            boleto.ValorBoleto = Console.ReadLine();
            Console.Write("Valor do desconto: ");
            boleto.ValorDesconto = Console.ReadLine();
            Console.Write("Valor do abatimento: ");
            boleto.ValorAbatimento = Console.ReadLine();
            Console.Write("Nosso número: ");
            boleto.NossoNumero = Console.ReadLine();
            Console.Write("Linha digitável: ");
            boleto.LinhaDigitavel = Console.ReadLine();
            Console.Write("Data de vencimento: ");
            boleto.DataVencimento = Console.ReadLine();

            // Define o Tipo de Operação
            boleto.CodigoOperacao = FecoMG.Enumerador.BoletoPersonalizadoEnum.Incluir;

            return new BoletoNegocio().IncluirBoleto(boleto);
        }

        /// <summary>
        /// Método para Alterar boleto presonalizado
        /// </summary>
        /// <returns></returns>
        public bool AlterarBoleto(BoletoPersonalizadoEntidade boleto)
        {
            // Interação com Usuário
            Console.Write("Número do Documento a ser alterado: ");
            boleto.NumeroDocumento = Console.ReadLine();
            Console.Write("Valor do boleto: ");
            boleto.ValorBoleto = Console.ReadLine();
            Console.Write("Valor do desconto: ");
            boleto.ValorDesconto = Console.ReadLine();
            Console.Write("Valor do abatimento: ");
            boleto.ValorAbatimento = Console.ReadLine();
            Console.Write("Nosso número: ");
            boleto.NossoNumero = Console.ReadLine();
            Console.Write("Linha digitável: ");
            boleto.LinhaDigitavel = Console.ReadLine();
            Console.Write("Data de vencimento: ");
            boleto.DataVencimento = Console.ReadLine();

            // Especificos do Personalizado
            Console.Write("Capital social da empresa: ");
            boleto.CapitalSocialEmpresa = Console.ReadLine();
            Console.Write("Número de funcionários: ");
            boleto.NumeroFuncionarios = Console.ReadLine();

            // Define o Tipo de Operação
            boleto.CodigoOperacao = FecoMG.Enumerador.BoletoPersonalizadoEnum.Modificar;

            return new BoletoNegocio().AlterarBoleto(boleto);
        }

        /// <summary>
        /// Método para Baixar boleto presonalizado
        /// </summary>
        /// <returns></returns>
        public bool BaixarBoleto(BoletoPersonalizadoEntidade boleto)
        {

            // Interação com Usuário
            Console.Write("Número do Documento a ser baixado: ");
            boleto.NumeroDocumento = Console.ReadLine();

            // Define o Tipo de Operação
            boleto.CodigoOperacao = FecoMG.Enumerador.BoletoPersonalizadoEnum.Baixar;

            return new BoletoNegocio().BaixarBoleto(boleto);
        }

        /// <summary>
        /// Método para Consultar boleto presonalizado
        /// </summary>
        /// <returns></returns>
        public bool ConsultarBoleto(BoletoPersonalizadoEntidade boleto)
        {

            // Interação com Usuário
            Console.Write("Número do Documento a ser consultado: ");
            boleto.NumeroDocumento = Console.ReadLine();

            // Define o Tipo de Operação
            boleto.CodigoOperacao = FecoMG.Enumerador.BoletoPersonalizadoEnum.Consultar;

            return new BoletoNegocio().BaixarBoleto(boleto);
        }
        #endregion
    }
}