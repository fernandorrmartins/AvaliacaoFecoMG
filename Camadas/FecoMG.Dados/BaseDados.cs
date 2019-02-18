using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace FecoMG.Dados
{
    /// <summary>
    /// Classe Base para todas classes na camada dados
    /// Possui atributos e funções que são usadas ou sobrepostas pelas classes que a herdam
    /// </summary>
    public class BaseDados
    {
        #region Atributos da Classe
        public string UrlApi = "http://localhost/";   // Url da Api
        #endregion
    }
}
