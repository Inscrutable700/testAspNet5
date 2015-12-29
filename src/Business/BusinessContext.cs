using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Data;

namespace Business
{
    public class BusinessContext
    {
        private DataContext DataContext;
        
        public BusinessContext()
        {
            this.DataContext = new DataContext();
        }
    }
}
