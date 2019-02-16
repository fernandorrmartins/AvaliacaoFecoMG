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
        /// <summary>
        /// Overload
        /// Método que Recebe um Objeto do tipo BoletoPadraoEntidade e trata a requisição feita pelo usuário
        /// </summary>
        /// <param name="boleto"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("Incluir")]
        public bool Incluir(BoletoPadraoEntidade boleto)
        {
            // Retorno do método. Resposta da API para o usuário informando se a solicitação foi efetuada
            // com sucesso
            bool finalizadoComSucesso = false;

            // Trata e executa a solicitação feita pelo usuário
            switch (boleto.CodigoOperacao)
            {
                case BoletoPadraoEnum.Incluir:

                    break;
                case BoletoPadraoEnum.Alterar:

                    break;
                case BoletoPadraoEnum.Baixar:

                    break;
                case BoletoPadraoEnum.Consultar:

                    break;
            }

            return false;
        }

        /// <summary>
        /// Overload
        /// Método que Recebe um Objeto do tipo BoletoPersonalizadoEntidade e trata a requisição feita pelo usuário
        /// </summary>
        /// <param name="boleto"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("Post")]
        public bool Post(BoletoPersonalizadoEntidade boleto)
        {
            // Retorno do método. Resposta da API para o usuário informando se a solicitação foi efetuada
            // com sucesso
            bool finalizadoComSucesso = false;

            // Trata e executa a solicitação feita pelo usuário
            switch (boleto.CodigoOperacao)
            {
                case BoletoPersonalizadoEnum.Incluir:

                    break;
                case BoletoPersonalizadoEnum.Modificar:

                    break;
                case BoletoPersonalizadoEnum.Baixar:

                    break;
                case BoletoPersonalizadoEnum.Consultar:

                    break;
            }
            
            return finalizadoComSucesso;
        }
    }
}
