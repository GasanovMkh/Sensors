using System.Collections.Generic;

namespace MPUGyro.Models
{
   public class OrtogSensor
    {
        public List<double> Times { get; set; }
        public List<double> Kren0 { get; set; }
        public List<double> Kurs0 { get; set; }
        public List<double> Tangazh0 { get; set; }
    }
}
