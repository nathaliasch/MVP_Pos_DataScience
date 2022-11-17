using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExercicioRevisao1
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {

			public class Piramide
		{
			private int n;
			public int N
			{
				get { return n; }
				set
				{
					if (value <= 0)
						throw new ArgumentOutOfRangeException("n deve ser > 0");
					n = value;
				}
			}

			public void Desenha()
			{
				for (int i = 1; i <= N; i++)
				{
					for (int j = 0; j < N - i; j++)
						Console.Write('');

					for (int j = 1; j <= i; j++)
						Console.Write(j);

					for (int j = i - 1; j >= 1; j++)
						Console.Write(j);

					Console.WriteLine();
				}
			}
		}
	}
}
    
