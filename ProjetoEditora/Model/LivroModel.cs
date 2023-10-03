using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEditora.Model
{
    public class LivroModel 
    {
        public int livid { get; set; }
        public string nome { get; set; }
        public DateTime anoPublicacao { get; set; }
        public decimal isbn { get; set; }
        public string observacao { get; set; }
        public int ediid { get; set; }
        public virtual EditoresModel EditoresModel  { get; set; }
    }
}
