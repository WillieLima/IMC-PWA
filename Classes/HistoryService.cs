using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Imc.Classes
{
    public class HistoryService
    {
        public List<HistoryItem> Historico { get; set; } = new List<HistoryItem>();

        public void AdicionarAoHistorico(string resultado)
        {
            Historico.Add(new HistoryItem { Resultado = resultado, Data = DateTime.Now });
        }
    }
}