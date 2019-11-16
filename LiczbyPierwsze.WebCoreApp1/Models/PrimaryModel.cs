using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LiczbyPierwsze.Main;

namespace LiczbyPierwsze.WebCoreApp1.Models
{
    public class PrimaryModel
    {
        
        public int DLimit { get; set; }
        public int ULimit { get; set; }

        public List<int> Numbers { get; set; }
    }
}
