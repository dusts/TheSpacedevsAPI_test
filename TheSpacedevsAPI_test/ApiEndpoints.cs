using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSpacedevsAPI_test
{
    internal static class ApiEndpoints
    {
        static string baseApi = "https://lldev.thespacedevs.com/2.2.0";
        public static string agenciesList = baseApi + "/agencies/?limit=100";
        public static string astronautList = baseApi + "/astronaut/";
    }
}
