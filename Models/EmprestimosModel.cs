using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace registro.Models
{
    public class Emprestimo
    {
        public int Id { get; set; }
        public string Recebedor {get; set; } 
        public string Fornecedor { get; set; } 
        public string LivroEmprestado { get; set; } 
        public DateTime DataEmprestimo { get; set; } = DateTime.Now;
    }
}