using System;
using System.ComponentModel;

namespace FecoMG.Enumerador
{
    /// <summary>
    /// Classe com enumeradores que representam as possíveis operações para
    /// 'Integração 2 – Boleto de cobrança personalizado'
    /// </summary>
    public enum BoletoPersonalizadoEnum : Int16
    {
        #region Possíveis Operações
        [Description("Incluir")]
        Incluir = 02,

        [Description("Modificar")]
        Alterar = 01,

        [Description("Baixar")]
        Baixar = 04,

        [Description("Consultar")]
        Consultar = 05
        #endregion
    }
}
