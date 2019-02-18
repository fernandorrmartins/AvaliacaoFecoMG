using FecoMG.Entidade;
using FecoMG.Enumerador;
using System.Web.Http;

namespace API
{
    /// <summary>
    /// Controlador para Manuseio dos Boletos pela API
    /// </summary>
    [RoutePrefix("api/BoletoPadraoBaixarConsultar")]
    public class BoletoPadraoBaixarConsultarController : ApiController
    {
        #region Métodos do Boleto Padrão
        /// <summary>
        /// Overload
        /// Método que Recebe um Objeto do tipo BoletoPadraoEntidade e faz a inclusão na base de dados
        /// </summary>
        /// <param name="boleto"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("Baixar")]
        public bool Post(BoletoPadraoEntidade boleto)
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
        [HttpPut]
        [Route("Consultar")]
        public bool Put(BoletoPadraoEntidade boleto)
        {
            // Retorno do método. Resposta da API para o usuário informando se a solicitação foi efetuada
            // com sucesso
            bool finalizadoComSucesso = true;

            return finalizadoComSucesso;
        }
        #endregion
    }
}
