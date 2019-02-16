using FecoMG.Enumerador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FecoMG.Entidade
{
    /// <summary>
    /// Classe que representa 'Integração 1 – Boleto de cobrança padrão'
    /// Herda do Boleto Base Entidade
    /// </summary>
    public class BoletoPadraoEntidade : BoletoBaseEntidade
    {
        #region Atributos da Classe
        public BoletoPadraoEnum CodigoOperacao { get; set; }    // Código da operação - Enumerador que representa as operações
        #endregion
    }
}
