using FecoMG.Entidade;
using FecoMG.Enumerador;
using System.Web.Http;

namespace API
{
    /// <summary>
    /// Controlador para Manuseio dos Boletos pela API
    /// </summary>
    [RoutePrefix("api/Boleto")]
    public class BoletoController : ApiController
    {
        #region Métodos do Boleto Padrão
        /// <summary>
        /// Overload
        /// Método que Recebe um Objeto do tipo BoletoPadraoEntidade e faz a inclusão na base de dados
        /// </summary>
        /// <param name="boleto"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("Incluir")]
        public bool Incluir(BoletoPadraoEntidade boleto)
        {
            // Retorno do método. Resposta da API para o usuário informando se a solicitação foi efetuada
            // com sucesso
            bool finalizadoComSucesso = true;

            return finalizadoComSucesso;
        }

        /// <summary>
        /// Overload
        /// Método que Recebe um Objeto do tipo BoletoPadraoEntidade e faz a inclusão na base de dados
        /// </summary>
        /// <param name="boleto"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("Alterar")]
        public bool Alterar(BoletoPadraoEntidade boleto)
        {
            // Retorno do método. Resposta da API para o usuário informando se a solicitação foi efetuada
            // com sucesso
            bool finalizadoComSucesso = true;

            return finalizadoComSucesso;
        }

        /// <summary>
        /// Overload
        /// Método que Recebe um Objeto do tipo BoletoPadraoEntidade e faz a inclusão na base de dados
        /// </summary>
        /// <param name="boleto"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("Baixar")]
        public bool Baixar(BoletoPadraoEntidade boleto)
        {
            // Retorno do método. Resposta da API para o usuário informando se a solicitação foi efetuada
            // com sucesso
            bool finalizadoComSucesso = true;

            return finalizadoComSucesso;
        }

        /// <summary>
        /// Overload
        /// Método que Recebe um Objeto do tipo BoletoPadraoEntidade e faz a inclusão na base de dados
        /// </summary>
        /// <param name="boleto"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("Consultar")]
        public bool Consultar(BoletoPadraoEntidade boleto)
        {
            // Retorno do método. Resposta da API para o usuário informando se a solicitação foi efetuada
            // com sucesso
            bool finalizadoComSucesso = true;

            return finalizadoComSucesso;
        }
        #endregion

        #region Métodos do Boleto Personalizado
        /// <summary>
        /// Overload
        /// Método que Recebe um Objeto do tipo BoletoPersonalizadoEntidade e faz a inclusão na base de dados
        /// </summary>
        /// <param name="boleto"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("Incluir")]
        public bool Incluir(BoletoPersonalizadoEntidade boleto)
        {
            // Retorno do método. Resposta da API para o usuário informando se a solicitação foi efetuada
            // com sucesso
            bool finalizadoComSucesso = true;

            return finalizadoComSucesso;
        }

        /// <summary>
        /// Overload
        /// Método que Recebe um Objeto do tipo BoletoPersonalizadoEntidade e faz a inclusão na base de dados
        /// </summary>
        /// <param name="boleto"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("Alterar")]
        public bool Alterar(BoletoPersonalizadoEntidade boleto)
        {
            // Retorno do método. Resposta da API para o usuário informando se a solicitação foi efetuada
            // com sucesso
            bool finalizadoComSucesso = true;

            return finalizadoComSucesso;
        }

        /// <summary>
        /// Overload
        /// Método que Recebe um Objeto do tipo BoletoPersonalizadoEntidade e faz a inclusão na base de dados
        /// </summary>
        /// <param name="boleto"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("Baixar")]
        public bool Baixar(BoletoPersonalizadoEntidade boleto)
        {
            // Retorno do método. Resposta da API para o usuário informando se a solicitação foi efetuada
            // com sucesso
            bool finalizadoComSucesso = true;

            return finalizadoComSucesso;
        }

        /// <summary>
        /// Overload
        /// Método que Recebe um Objeto do tipo BoletoPersonalizadoEntidade e faz a inclusão na base de dados
        /// </summary>
        /// <param name="boleto"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("Consultar")]
        public bool Consultar(BoletoPersonalizadoEntidade boleto)
        {
            // Retorno do método. Resposta da API para o usuário informando se a solicitação foi efetuada
            // com sucesso
            bool finalizadoComSucesso = true;

            return finalizadoComSucesso;
        }
        #endregion
    }
}
