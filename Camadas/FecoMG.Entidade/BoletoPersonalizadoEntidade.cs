using FecoMG.Enumerador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FecoMG.Entidade
{
    /// <summary>
    /// Classe que representa 'Integração 2 – Boleto de cobrança personalizado'
    /// Herda do Boleto Base Entidade
    /// </summary>
    public class BoletoPersonalizadoEntidade : BoletoBaseEntidade
    {
        #region Atributos da Classe
        public string CapitalSocialEmpresa { get; set; }            // Capital Social da Empresa
        public string NumeroFuncionarios { get; set; }              // Número de Funcionários

        public BoletoPersonalizadoEnum CodigoOperacao { get; set; } // Código da Operação - Enumerador que representa as operações
        #endregion
    }
}
