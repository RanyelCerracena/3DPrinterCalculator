using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _3DPrinterCalculator.Models
{
    public class MaterialModel 
    {
        public int MaterialPrice { get; set; }
        
        public int ResinWeight { get; set; }
        public int ResinPrice { get; set; }
        public int FilamentPrice { get; set; }
        
        
        public MaterialModel()
        {
            var resinWeighInGrams = ResinWeight * 1000;
            var resinPriceInGrams = ResinPrice / 1000;
            var filamentPriceInGrams = FilamentPrice / 1000;
        }

    }
}