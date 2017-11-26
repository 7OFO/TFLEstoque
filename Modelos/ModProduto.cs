using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class ModProduto
    {
        public int Id { get; set; }
              
        public string Prod { get; set; }
              
        public string Descricao { get; set; }
            
        public int Categoria { get; set; }
               
        public int Marca { get; set; }
            
        public int Unidade_Medida { get; set; }
             
        public int Fornecedor { get; set; }
            
        public double EMinimo { get; set; }
           
        public double EMaximo;
              
        public string Data { get; set; }
        
    }
}
