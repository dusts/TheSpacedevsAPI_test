using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSpacedevsAPI_test.Responses
{
    internal class AgenciesResponse
    {
        public int Count { get; set; }
        public string Next { get; set; }
        public string Previous { get; set; }
        public List<Agency> Results { get; set; }
    }
}
