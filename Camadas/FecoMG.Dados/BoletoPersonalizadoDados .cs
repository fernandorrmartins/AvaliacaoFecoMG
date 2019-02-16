using FecoMG.Entidade;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Net;
using System.Resources;

namespace FecoMG.Dados
{
    /// <summary>
    /// Fabrica BoletoPersonalizadoEntidade
    /// </summary>
    public class BoletoPersonalizadoDados : BaseDados
    {
        /// <summary>
        /// Metódo Responsável por Enviar o objeto Boleto para a Api que será analisado e retornará se foi possível 
        /// executar a ação
        /// </summary>
        /// <param name="UrlApiController"></param>
        /// <param name="boleto"></param>
        /// <returns></returns>
        public bool ConectarApiPost(String UrlApiController, BoletoPersonalizadoEntidade boleto)
        {
            var json = "";
            var httpWebRequest = (HttpWebRequest)WebRequest.Create(UrlApi + UrlApiController);
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                json = JsonConvert.SerializeObject(boleto);

                streamWriter.Write(json);
                streamWriter.Flush();
                streamWriter.Close();
            }

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                json = streamReader.ReadToEnd();
            }

            return Convert.ToBoolean(json);
        }

        /// <summary>
        /// Método para Criar um Boleto e enviar para API para Incluir na Base de Dados
        /// </summary>
        /// <param name="cmd"></param>
        /// <returns></returns>
        public bool IncluirBoleto()
        {
            try
            {
                // Objeto BoletoPadrao
                BoletoPersonalizadoEntidade boleto = new BoletoPersonalizadoEntidade();

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

                // Campos Especificos do Boleto Personalizado
                Console.Write("Capital Social da Empresa: ");
                boleto.CapitalSocialEmpresa = Console.ReadLine();
                Console.Write("Número de Funcionários: ");
                boleto.NumeroFuncionarios = Console.ReadLine();

                // Define o Tipo de Operação
                boleto.CodigoOperacao = Enumerador.BoletoPersonalizadoEnum.Incluir;

                return ConectarApiPost("api/Boleto/Incluir", boleto);
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
