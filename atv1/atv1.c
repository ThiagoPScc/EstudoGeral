#include<stdio.h>

int main() {
    int vetor[5] = {1,2,5,9,0};
    int vetorInvertido [sizeof(vetor)/sizeof(vetor[0])];
    int i;
    int tamanho =sizeof(vetor)/sizeof(vetor[0]);
    printf("%d",tamanho);
    printf("\n");
    for (i = 0; i < tamanho;i++){
    vetorInvertido[tamanho - i -1] = vetor[i];
        
    }
    printf("\n");
    for (i=0;i< tamanho;i++){
    printf("%d",vetor[i]);
    }
    printf("\n");
    for (i=0;i< tamanho;i++){
    printf("%d",vetorInvertido[i]);
    }
}
