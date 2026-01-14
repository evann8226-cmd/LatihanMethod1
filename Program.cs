 
static void tambah(int a, int b)
{
    int c = 0;

    c = a + b;
    Console.WriteLine($"{a} + {b} = {c}");
}

static void kurang(int a, int b)
{
    int c = 0; 

    c = a - b;
    Console.WriteLine($"{a} - {b} = {c}");
}

static void kali(int a, int b)
{
    int  c = 0;

    c = a * b;
    Console.WriteLine($"{a} * {b} = {c}");
}

static void bagi(int a, int b)
{
    int c = 0;

    c = a / b;
    Console.WriteLine($"{a} / {b} = {c}");
}

tambah(10,2);
tambah(15,4);
kurang(10,2);
kurang(15,3);
kali(10,2);
kali(15,8);
bagi(10,2);
bagi(15,5);
