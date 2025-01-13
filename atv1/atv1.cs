using System;

class Program
{
    static void Main() {
        int[] vetor = new int[5]{1,2,5,9,0};
        int[] vetorInvertido = new int[vetor.Length];
        int iInvert = vetor.Length - 1;
        foreach (int i in vetor){
            vetorInvertido[iInvert] = i;
            iInvert = iInvert - 1;
        }
        Console.Write("\n");
        foreach(int i in vetor){
        Console.Write(i);
        }
         Console.Write("\n");
        foreach(int i in vetorInvertido){
            Console.Write(i);
        }
        
        
    }
}
