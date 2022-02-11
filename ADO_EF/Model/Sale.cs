using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO_EF.Model
{
    public class Sale
    {
        public int Cnt { get; set; }
        public Guid Id { get; set; }
        public Guid Id_manager { get; set; }
        public Guid Id_product { get; set; }
        public DateTime Moment { get; set; }

        public override string ToString()
        {
            return $"{Moment.ToShortDateString()}-{Cnt} pcs {Id_product.ToString().Substring(25)}-{Id_manager.ToString().Substring(25)}";
        }
    }
}
