using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
namespace MaximCode.Data
{
    public class MaximDBContext : DbContext
    {
        public MaximDBContext() : base("Name = MaximDBContext")
        {
        }
            public virtual DbSet<Car> Cars { get; set; }
    
        
    }
}
