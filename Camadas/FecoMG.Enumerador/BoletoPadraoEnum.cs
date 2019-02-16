using System;
using System.ComponentModel;

namespace FecoMG.Enumerador
{
    /// <summary>
    /// Classe com enumeradores que representam as possíveis operações para
    /// 'Integração 1 – Boleto de cobrança padrão'
    /// </summary>
    public enum BoletoPadraoEnum : Int16
    {
        #region Possíveis Operações
        [Description("Incluir")]
        Incluir = 01,

        [Description("Alterar")]
        Alterar = 02,

        [Description("Baixar")]
        Baixar = 03,

        [Description("Consultar")]
        Consultar = 04
        #endregion
    }
}
