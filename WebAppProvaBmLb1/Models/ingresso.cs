﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppProvaBmLb1.Models
{
    public class Ingresso
    {
        public int IngressoId { get; set; }
        public int Tipo { get; set; }
        public Sessao Sessao { get; set; }
        
    }
}