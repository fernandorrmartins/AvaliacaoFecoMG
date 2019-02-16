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
    /// Classe Responsavel pelas Funcionalidades de Negocio da 'Integração 1 – Boleto de cobrança padrão'
    /// </summary>
    public class BoletoPadraoNegocio
    {
        BoletoPadraoDados boletoDados = new BoletoPadraoDados();

        /// <summary>
        /// Função responsável por incluir um boleto na base de dados
        /// </summary>
        /// <param name="boleto">Recebe um BoletoPadraoEntidade como parâmetro</param>
        /// <returns></returns>
        public bool IncluirBoleto()
        {
            return boletoDados.IncluirBoleto();
        }
    }
}
