#include <stdio.h>
#include <stdlib.h>
#include <string.h>
int main()
{
    char Nome[15][15];
    int Cod[15], i, j, MaiorLucro = 0, MenorLucro = 0;
    float Preco[15], Lucro[15], totalLucro = 0;
    for (i = 0; i < 15; i++){
        printf("Digite o NOME do %d produto: \n", i + 1);
        fflush(stdin);
        for(j = 0; j < 14; j++){
            Nome[i][j] = getchar();
            if(Nome[i][j] == '\r' || Nome[i][j] =='\n' || Nome[i][j] == '\0')
                break;
        }
        Nome[i][++j] = '\0';
        printf("Digite o CODIGO do %d produto: \n", i + 1);
        scanf("%d", &Cod[i]);
        printf("Digite o PRECO do %d produto: \n", i + 1);
        scanf("%f", &Preco[i]);
        printf("Digite a PORCENTAGEM DE LUCRO do %d produto: \n", i + 1);
        scanf("%f", &Lucro[i]);
        totalLucro = totalLucro + ((Lucro[i] * 100)/ Preco[i]);
        MenorLucro = Lucro[i];
        if (Lucro [i] > MaiorLucro){
            MaiorLucro = Cod[i];
        }
        else if (Lucro[i] < MenorLucro){
            MenorLucro = Cod[i];
        }
    }

    printf("\n\n");
    printf("RELATORIO GERAL:");
    printf("\n\n");

    for(i = 0; i < 15; i++){
        printf("Nome do %d produto: %s | ", i+1, Nome[i]);
        printf("Codigo do %d produto: %d | ", i+1, Cod[i]);
        printf("Preco do %d produto: %f | ", i+1, Preco[i]);
        printf("Porcentagem de lucro sobre o %d produto : %.2f%%.\n", i+1, Lucro[i]);
    }
        printf("\nLucro total na venda de uma unidade de cada produto: %.2f\n", totalLucro);
        printf("\nCodigo do produco com MENOR lucro: %d", MenorLucro);
        printf("\nCodigo do produto com MAIOR lucro: %d", MaiorLucro);
    return 0;
}
