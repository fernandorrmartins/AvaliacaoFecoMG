using FecoMG.Dados;
using FecoMG.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FecoMG.Negocio
{
    /// <summary>
    /// Classe Responsavel pelas Funcionalidades de Negocio dos Boletos
    /// </summary>
    public class BoletoNegocio
    {
        BoletoDados boletoDados = new BoletoDados();

        #region Boleto Padrão
        /// <summary>
        /// Função responsável por incluir um boleto na base de dados
        /// </summary>
        /// <param name="boleto">Recebe um BoletoPadraoEntidade como parâmetro</param>
        /// <returns></returns>
        public bool IncluirBoleto(BoletoPadraoEntidade boleto)
        {
            return boletoDados.IncluirBoleto(boleto);
        }

        /// <summary>
        /// Função responsável por Alterar um boleto na base de dados
        /// </summary>
        /// <param name="boleto">Recebe um BoletoPadraoEntidade como parâmetro</param>
        /// <returns></returns>
        public bool AlterarBoleto(BoletoPadraoEntidade boleto)
        {
            return boletoDados.AlterarBoleto(boleto);
        }

        /// <summary>
        /// Função responsável por Baixar um boleto na base de dados
        /// </summary>
        /// <param name="boleto">Recebe um BoletoPadraoEntidade como parâmetro</param>
        /// <returns></returns>
        public bool BaixarBoleto(BoletoPadraoEntidade boleto)
        {
            return boletoDados.BaixarBoleto(boleto);
        }

        /// <summary>
        /// Função responsável por Baixar um boleto na base de dados
        /// </summary>
        /// <param name="boleto">Recebe um BoletoPadraoEntidade como parâmetro</param>
        /// <returns></returns>
        public bool ConsultarBoleto(BoletoPadraoEntidade boleto)
        {
            return boletoDados.ConsultarBoleto(boleto);
        }
        #endregion

        #region Boleto Personalizado
        /// <summary>
        /// Função responsável por incluir um boleto na base de dados
        /// </summary>
        /// <param name="boleto">Recebe um BoletoPersonalizadoEntidade como parâmetro</param>
        /// <returns></returns>
        public bool IncluirBoleto(BoletoPersonalizadoEntidade boleto)
        {
            return boletoDados.IncluirBoleto(boleto);
        }

        /// <summary>
        /// Função responsável por Alterar um boleto na base de dados
        /// </summary>
        /// <param name="boleto">Recebe um BoletoPersonalizadoEntidade como parâmetro</param>
        /// <returns></returns>
        public bool ModificarBoleto(BoletoPersonalizadoEntidade boleto)
        {
            return boletoDados.ModificarBoleto(boleto);
        }

        /// <summary>
        /// Função responsável por Baixar um boleto na base de dados
        /// </summary>
        /// <param name="boleto">Recebe um BoletoPersonalizadoEntidade como parâmetro</param>
        /// <returns></returns>
        public bool BaixarBoleto(BoletoPersonalizadoEntidade boleto)
        {
            return boletoDados.BaixarBoleto(boleto);
        }

        /// <summary>
        /// Função responsável por Baixar um boleto na base de dados
        /// </summary>
        /// <param name="boleto">Recebe um BoletoPersonalizadoEntidade como parâmetro</param>
        /// <returns></returns>
        public bool ConsultarBoleto(BoletoPersonalizadoEntidade boleto)
        {
            return boletoDados.ConsultarBoleto(boleto);
        }
        #endregion
    }
}