using shared.models.common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shared.models
{
    public class ApplicationUser : BaseObject
    { 

        public string Name { get; set; }
        public string Email { get; set; }  
      
    }
}
