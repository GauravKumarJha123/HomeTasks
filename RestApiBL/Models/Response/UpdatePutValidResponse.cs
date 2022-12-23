using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestApiBL.Models.Response
{
    public class UpdatePutValidResponse
    {
        public int id { get; set; }
        public string title { get; set; }

        public string author { get; set; }
    }
}
