numero = 1259
i = 2
if numero > 1:
  for i in range(i, numero):
    if numero % i == 0:
      print("numero não é primo")
      break
  else:
    print("numero é primo")
else:
  print("numero não é primo")