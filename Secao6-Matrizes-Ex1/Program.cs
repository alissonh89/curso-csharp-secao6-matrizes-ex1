using System;

namespace Secao6_Matrizes_Ex1 {
    class Program {
        static void Main(string[] args) {
                        
            string[] matLenght = Console.ReadLine().Split(' '); //criando uma matriz string, e o separador dos textos é o espaço ' '
            int line = int.Parse(matLenght[0]);
            int col = int.Parse(matLenght[1]);
            int[,] mat = new int[line, col];

            //for para ler todas as linhas
            for (int i = 0; i < line; i++) {
                //irá ler todos os valores de uma linha, com separador ' ', no formato string
                string[] values = Console.ReadLine().Split(' ');
                //for para entrar com todos os valores das colunas
                for (int j = 0; j < col; j++) {
                    mat[i, j] = int.Parse(values[j]);
                }
            }

            int valor = int.Parse(Console.ReadLine());

            //for para ler todas as linhas
            for (int i = 0; i < line; i++) {
                //for para ler todos os valores das colunas, na linha i
                for (int j = 0; j < col; j++) {
                    if (valor == mat [i, j]) {
                        Console.WriteLine("Position " + i + "," + j + ":");
                        if (j>0) {
                            Console.WriteLine("Left: " + mat[i,j - 1]);
                        }
                        if (i>0) {
                            Console.WriteLine("Up : " + mat[i - 1,j]);
                        }
                        if (j < col - 1) {
                            Console.WriteLine("Right: " + mat[i,j + 1]);
                        }
                        if (i < line - 1) {
                            Console.WriteLine("Down: " + mat[i + 1,j]);
                        }

                    }
                }
            }



        }
    }
}
