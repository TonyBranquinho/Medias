using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace medidas {
    class Program {
        static void Main(string[] args) {
            CultureInfo CI = CultureInfo.InvariantCulture;

            double a, b, c, areaQuad, areaTri, areaTra;

            Console.Write("Digite a medida A: ");
            a = double.Parse(Console.ReadLine(), CI);
            Console.Write("Digite a medida B: ");
            b = double.Parse(Console.ReadLine(), CI);
            Console.Write("Digite a medida C: ");
            c = double.Parse(Console.ReadLine(), CI);

            areaQuad = a * a;
            areaTri = (a * b) / 2;
            areaTra = (a + b) * c / 2;

            Console.WriteLine("AREA DO QUADRADO = "+areaQuad.ToString("F3", CI));
            Console.WriteLine("AREA DO TRIANGULO = "+areaTri.ToString("F3", CI));
            Console.WriteLine("AREA DO TRAPEZIO = "+areaTra.ToString("F3", CI));

        }
    }
}
