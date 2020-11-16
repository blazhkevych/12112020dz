using System.Globalization;

namespace _12112020dz
{
    public class MeanAndStd
    {
        public double Mean { get; set; }
        public double Std { get; set; }
        public override string ToString() => 
            Mean.ToString(CultureInfo.InvariantCulture) + "±" + Std.ToString(CultureInfo.InvariantCulture);
    }
}