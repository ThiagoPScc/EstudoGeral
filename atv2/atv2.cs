using System;

class Program
{
    static void Main() {
        string horasE,horasTotalE,horasFimE,validacaoE;
        int horas,horasTotal,horasFim,validacao;
        Console.WriteLine("Digite quantas horas você estuda por semana: \n");
        horasE = Console.ReadLine();
        horas = int.Parse(horasE);
        Console.WriteLine("Você estuda final de semana? 1)sim 2)não \n");
        validacaoE = Console.ReadLine();
        validacao = int.Parse(validacaoE);
        if(validacao == 1){
            Console.WriteLine("Digite quantas horas estuda por final de semana: \n");
            horasFimE = Console.ReadLine();
            horasFim = int.Parse(horasFimE);
            horasTotal = horas * 22 + horasFim * 8;
            Console.WriteLine(horasTotal);
        }
        else{
           horasTotal = horas * 22;
            Console.WriteLine(horasTotal);
        }
       
    }
}
