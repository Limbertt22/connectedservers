using System;
using System.Collections.Generic;

class Servidores
{
    static void Main(string[] args)
    {
        int[][] servidores = {
           new int[] {1,1,0,0},
           new int[] {0,0,1,0},
           new int[] {0,0,1,0},
           new int[] {0,0,0,1}
        };

        int result =CountServers(servidores);
        Console.WriteLine($"Número de servidores detectados: {result}");
    }

    public static int CountServers(int[][] grid)
    {
        HashSet<string> lista = new HashSet<string>();

        for (int i = 0; i < grid.Length; i++)
        {
            for (int j = 0; j < grid[0].Length; j++)
            {   
            
                if (grid[i][j] == 1)
                {
                    Validacion(grid, i, j, lista);
                }
            }
        
        }

        return lista.Count;
    }

    public static void Validacion(int[][] servidores, int i, int j, HashSet<string> lista)
    {
        int cont = 0;
        for (int k = 0; k < servidores[0].Length; k++)
        {
            if (servidores[i][k] == 1 && !lista.Contains($"({i},{k})") && k != j)
            {
                cont++;
                lista.Add($"({i},{k})");
            }
        }

    
        for (int l = 0; l < servidores.Length; l++)
        {
            if (servidores[l][j] == 1 && !lista.Contains($"({l},{j})") && l != i )
            {
                lista.Add($"({l},{j})");
                cont++;
            }
        }

        if(cont > 1){
            lista.Add($"({i},{j})");
        }
    }
}