﻿using FecoMG.Entidade;
using FecoMG.Enumerador;
using System.Web.Http;

namespace API
{
    /// <summary>
    /// Controlador para Manuseio dos Boletos pela API
    /// </summary>
    [RoutePrefix("api/BoletoPersonalizadoIncluirModificar")]
    public class BoletoPersonalizadoIncluirModificarController : ApiController
    {
        #region Métodos do Boleto Personalizado
        /// <summary>
        /// Overload
        /// Método que Recebe um Objeto do tipo BoletoPersonalizadoEntidade e faz a inclusão na base de dados
        /// </summary>
        /// <param name="boleto"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("Incluir")]
        public bool Post(BoletoPersonalizadoEntidade boleto)
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
        [HttpPut]
        [Route("Modificar")]
        public bool Put(BoletoPersonalizadoEntidade boleto)
        {
            // Retorno do método. Resposta da API para o usuário informando se a solicitação foi efetuada
            // com sucesso
            bool finalizadoComSucesso = true;

            return finalizadoComSucesso;
        }
        #endregion
    }
}
