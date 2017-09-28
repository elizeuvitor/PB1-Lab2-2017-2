using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppProvaBmLb1.Models
{
    public class Sessao
    {
        public int SessaoId { get; set; }
        public DateTime DataHoraInicio { get; set; }
        public DateTime DataHrafim { get; set; }
        public decimal ValorInteira { get; set; }
        public decimal ValorMeia { get; set; }
        public Boolean Encerrada { get; set; }
        public Sala Sala { get; set; }
        public Filme Filme { get; set; }
        public List<Ingresso> Ingressos { get; set; }
    }
}