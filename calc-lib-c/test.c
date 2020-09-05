#include <stdio.h>
#include "calc.h"

int main(void){
    int a,b;
    printf("Sum of two numbers\n");
    printf("A: ");
    scanf("%d",&a);
    printf("B: ");
    scanf("%d",&b);
    printf("%d\n", sum(a,b));
    return 0;
}