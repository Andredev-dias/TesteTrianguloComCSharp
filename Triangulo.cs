using System;
using System.Collections.Generic;
using System.Text;

namespace TesteTriangulo
{
    class Triangulo
    {
		public String verificarTipoDoTriangulo(double x, double y, double z)
		{
			if (validacaoDeValoresDeEntrada(x, y, z))
			{
				if (x < y + z && y < x + z && z < x + y)
				{
					if (x == y && y == z)
					{
						return ("Equilatero");
					}
					if (x == y && y != z || x == z && z != y || z == y && y != x)
					{
						return ("Isosceles");
					}
					if (x != y && y != z)
					{
						return ("Escaleno");
					}
				}

				return "Invalido";
			}
			return "Invalido";
		}

		public bool validacaoDeValoresDeEntrada(double x, double y, double z)
		{
			if (x <= 0 || y <= 0 || z <= 0)
			{
				return false;
			}
			return true;
		}
	}
}
