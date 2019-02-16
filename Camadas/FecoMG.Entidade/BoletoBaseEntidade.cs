using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FecoMG.Entidade
{
    /// <summary>
    /// Classe Base com todos Atributos presentes em ambos os Boletos
    /// </summary>
    class BoletoBaseEntidade
    {
        #region Atributos da Classe
        public string NumeroDocumento { get; set; } // Número do Documento
        public string ValorBoleto { get; set; }     // Valor do boleto
        public string ValorDesconto { get; set; }   // Valor do desconto
        public string ValorAbatimento { get; set; } // Valor do abatimento
        public string NossoNumero { get; set; }     // Nosso número
        public string LinhaDigitavel { get; set; }  // Linha digitável
        public string DataVencimento { get; set; }  // Data de vencimento
        #endregion
    }
}
