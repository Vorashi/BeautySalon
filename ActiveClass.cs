using BeautySalon.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautySalon
{
    internal class ActiveClass
    {
        public string ActiveStr { get; set; }
        public string ActiveBg {  get; set; }
        public ActiveClass(Product product) 
        {
            ActiveStr = product.IsActive != true ? "UnActive" : "Active";
            ActiveBg = product.IsActive != true ? "Gray" : "#FFE1E4FF";
        }
    }
}
