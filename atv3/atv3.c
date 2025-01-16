#include<stdio.h>

int main() {
    int numero, i, eh_primo = 1;
    numero = 1259;
    
    if(numero > 1) {
        for(i = 2; i <= numero / 2; i++) {
            if(numero % i == 0) {
                eh_primo = 0; 
                break;       
            }
        }
        
        if(eh_primo) {
            printf("O número é primo\n");
        } else {
            printf("O número não é primo\n");
        }
    } else {
        printf("O número não é primo\n");
    }

    return 0;
}
