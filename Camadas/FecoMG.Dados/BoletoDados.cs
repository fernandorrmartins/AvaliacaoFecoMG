using FecoMG.Entidade;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Net;
using System.Resources;

namespace FecoMG.Dados
{
    /// <summary>
    /// Classe responsável pelos dados dos boletos
    /// </summary>
    public class BoletoDados : BaseDados
    {
        #region Métodos do Boleto Padrão
        /// <summary>
        /// Metódo Responsável por Enviar o objeto BoletoPadrão para a Api que será analisado e retornará se foi possível 
        /// executar a ação
        /// </summary>
        /// <param name="UrlApiController"></param>
        /// <param name="boleto"></param>
        /// <returns></returns>
        public bool ConectarApiPost(String UrlApiController, BoletoPadraoEntidade boleto)
        {
            try
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
            } catch(Exception e)
            {
                Utilitario.Ultilitario.MensagemErro(e.Message);
                return false;
            }
        }

        /// <summary>
        /// Função responsável por Consultar um boleto na base de dados
        /// </summary>
        /// <param name="boleto">Recebe um BoletoPadraoEntidade como parâmetro</param>
        /// <returns></returns>
        public bool ConsultarBoleto(BoletoPadraoEntidade boleto)
        {
            try
            {
                return ConectarApiPost("api/Boleto/Consultar", boleto);
            } catch(Exception e)
            {
                Utilitario.Ultilitario.MensagemErro(e.Message);
                return false;
            }
}

        /// <summary>
        /// Função responsável por Baixar um boleto na base de dados
        /// </summary>
        /// <param name="boleto">Recebe um BoletoPadraoEntidade como parâmetro</param>
        /// <returns></returns>
        public bool BaixarBoleto(BoletoPadraoEntidade boleto)
        {
            try
            {
                return ConectarApiPost("api/Boleto/Baixar", boleto);
            }
            catch (Exception e)
            {
                Utilitario.Ultilitario.MensagemErro(e.Message);
                return false;
            }
        }

        /// <summary>
        /// Função responsável por Alterar um boleto na base de dados
        /// </summary>
        /// <param name="boleto">Recebe um BoletoPadraoEntidade como parâmetro</param>
        /// <returns></returns>
        public bool AlterarBoleto(BoletoPadraoEntidade boleto)
        {
            try
            {
                return ConectarApiPost("api/Boleto/Alterar", boleto);
            }
            catch (Exception e)
            {
                Utilitario.Ultilitario.MensagemErro(e.Message);
                return false;
            }
        }

        /// <summary>
        /// Função responsável por Incluir um boleto na base de dados
        /// </summary>
        /// <param name="boleto">Recebe um BoletoPadraoEntidade como parâmetro</param>
        /// <returns></returns>
        public bool IncluirBoleto(BoletoPadraoEntidade boleto)
        {
            try
            {
                return ConectarApiPost("api/Boleto/Incluir", boleto);
            }
            catch (Exception e)
            {
                Utilitario.Ultilitario.MensagemErro(e.Message);
                return false;
            }
        }
        #endregion
        
        #region Métodos do Boleto Personalizado
        /// <summary>
        /// Metódo Responsável por Enviar o objeto BoletoPersonalizado para a Api que será analisado e retornará se foi possível 
        /// executar a ação
        /// </summary>
        /// <param name="UrlApiController"></param>
        /// <param name="boleto"></param>
        /// <returns></returns>
        public bool ConectarApiPost(String UrlApiController, BoletoPersonalizadoEntidade boleto)
        {
            try
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
            catch (Exception e)
            {
                Utilitario.Ultilitario.MensagemErro(e.Message);
                return false;
            }
        }

        /// <summary>
        /// Função responsável por Consultar um boleto na base de dados
        /// </summary>
        /// <param name="boleto">Recebe um BoletoPersonalizadoEntidade como parâmetro</param>
        /// <returns></returns>
        public bool ConsultarBoleto(BoletoPersonalizadoEntidade boleto)
        {
            try
            {
                return ConectarApiPost("api/Boleto/Consultar", boleto);
            }
            catch (Exception e)
            {
                Utilitario.Ultilitario.MensagemErro(e.Message);
                return false;
            }
        }

        /// <summary>
        /// Função responsável por Baixar um boleto na base de dados
        /// </summary>
        /// <param name="boleto">Recebe um BoletoPersonalizadoEntidade como parâmetro</param>
        /// <returns></returns>
        public bool BaixarBoleto(BoletoPersonalizadoEntidade boleto)
        {
            try
            {
                return ConectarApiPost("api/Boleto/Baixar", boleto);
            }
            catch (Exception e)
            {
                Utilitario.Ultilitario.MensagemErro(e.Message);
                return false;
            }
        }

        /// <summary>
        /// Função responsável por Alterar um boleto na base de dados
        /// </summary>
        /// <param name="boleto">Recebe um BoletoPersonalizadoEntidade como parâmetro</param>
        /// <returns></returns>
        public bool AlterarBoleto(BoletoPersonalizadoEntidade boleto)
        {
            try
            {
                return ConectarApiPost("api/Boleto/Alterar", boleto);
            }
            catch (Exception e)
            {
                Utilitario.Ultilitario.MensagemErro(e.Message);
                return false;
            }
        }

        /// <summary>
        /// Função responsável por Incluir um boleto na base de dados
        /// </summary>
        /// <param name="boleto">Recebe um BoletoPersonalizadoEntidade como parâmetro</param>
        /// <returns></returns>
        public bool IncluirBoleto(BoletoPersonalizadoEntidade boleto)
        {
            try
            {
                return ConectarApiPost("api/Boleto/Incluir", boleto);
            }
            catch (Exception e)
            {
                Utilitario.Ultilitario.MensagemErro(e.Message);
                return false;
            }
        }
        #endregion
    }
}