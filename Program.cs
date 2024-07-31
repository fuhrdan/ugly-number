//*****************************************************************************
//** 263. Ugly Number  leetcode                                              **
//** Simple, slow implementation at top, faster code below.      --Dan       **
//*****************************************************************************

bool isUgly(int n) {
//    printf("%d / 2 == %d\n",n,n%2);
//    printf("%d / 3 == %d\n",n,n%2);
//    printf("%d / 5 == %d\n",n,n%2);
    if(n <= 0) return false;
/*
    while (n % 2 == 0) n /= 2;
    while (n % 3 == 0) n /= 3;
    while (n % 5 == 0) n /= 5;
*/
    int factors[] = {2, 3, 5};
    for (int i = 0; i < 3; ++i) {
        while (n % factors[i] == 0) {
            n /= factors[i];
        }
    }    
    return n == 1;
}