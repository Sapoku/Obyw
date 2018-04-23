using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR1
{
    class Obyw
    {
        public string proizv { get; set; }
    public float razm { get; set; }
    public double sena { get; set; }

    public Obyw()
    {

    }
    public void Input()
    {
        proizv = Console.ReadLine();
        razm = float.Parse(Console.ReadLine());
        sena = Double.Parse(Console.ReadLine());
    }
}
}
