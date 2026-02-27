using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace registro.Models
{
    public class EmprestimosModel
    {
        public int Id { get; set; }
        public string Recebedor {get; set; } = null!;
        public string Fornecedor { get; set; } = null!;
        public string LivroEmprestado { get; set; } = null!;
        public DateTime dataUltimaUtilizacao { get; set; } = DateTime.Now;
    }
}