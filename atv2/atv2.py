print("bem vindo ao gerenciador de estudos")
horasPorDia = int(input("Digite quantas Horas você estuda por dia util: "))
validaFimSem = int(input("Estuda final de semana? 1)sim 2)não: "))
result = True if validaFimSem == 1 else False;
if result:
  horasFimDeSemana = int(input("Digite quantas horas estuda por semana: "))
  totalHoras = 22 * horasPorDia + horasFimDeSemana * 8
  print(totalHoras)
else:
  totalHoras = 22 * horasPorDia
  print(totalHoras)
