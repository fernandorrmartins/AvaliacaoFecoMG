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
    class BoletoPersonalizadoEntidade
    {
        #region Atributos da Classe
        public string CapitalSocialEmpresa { get; set; }            // Capital social da empresa
        public string NumeroFuncionarios { get; set; }              //  Número de funcionários
        public BoletoPersonalizadoEnum CodigoOperacao { get; set; } // Código da operação - Enumerador que representa as operações
        #endregion
    }
}
