int Max(int arg1, int arg2, int arg3){
    int maximum = arg1;
    if (arg2 > maximum) maximum = arg2;
    if (arg3 > maximum) maximum = arg3;
    return maximum;
}

int a1 = 15;
int b1 =21;
int c1 = 346;
int a2 = 45;
int b2 =2121;
int c2 = 34;
int a3 = 55;
int b3 =24;
int c3 = 36;

int max = Max(Max(a1,b1,c1),Max(a2,b2,c2),Max(a3,b3,c3));
Console.WriteLine(max);