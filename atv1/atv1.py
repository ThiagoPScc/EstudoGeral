#objetivo é fazer um código que inverta os numeros dentro de um vetor.
vetor = [1,2,5,7,9,0]
vetorInvertido = []
tamanho = len(vetor)

for i in range(len(vetor)):
    print(tamanho)
    tamanho = tamanho- 1
    vetorInvertido.append(vetor[tamanho])
    

print(vetor,vetorInvertido)