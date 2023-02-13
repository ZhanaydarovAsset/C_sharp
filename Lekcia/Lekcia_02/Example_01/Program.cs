int a1 = 1;
int b1 = 2;
int c1 = 53;
int a2 = 4;
int b2 = 5225;
int c2 = 6;
int a3 = 744;
int b3 = 8;
int c3 = 9;

int max = a1;
if (b1 > max) max = b1;
if (c1 > max) max = c1;

if (a2 > max) max = a2;
if (b2 > max) max = b2;
if (c2 > max) max = c2;

if (a3 > max) max = a3;
if (b3 > max) max = b3;
if (c3 > max) max = c3;

Console.WriteLine(max);