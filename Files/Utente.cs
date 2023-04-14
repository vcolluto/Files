using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Files
{
    internal class Utente
    {
        public string? Nome { get; set; }
        public string? Cognome { get; set; }
        public DateOnly DataDiNascita { get; set; }

        public Utente(string nome, string cognome, DateOnly dataDiNascita) 
        { 
            Nome = nome;
            Cognome = cognome;
            DataDiNascita = dataDiNascita;
        }
    }
}
