// Task 1
/*int a = 3;
int b = 7;
Console.WriteLine(a + b);
*/
// Task 2

/*int a = 5;
Console.WriteLine(a * a);
*/
// Task 3

/* string a = "Mehpare";
 int z = 20;
 Console.WriteLine($"salam,menim adim {a}dir ve menim {z} yasim var");
*/

// Task 4
/*int a = 10;
int b = 20;
Console.WriteLine($" {a}nin evvelki deyeri 10, {b}nin evvelki deyeri 20dir");

b = a;
if (b == 10) ;

Console.WriteLine();*/

//Task 5

/*  int a = 12;
    int b = 14;
    int c = 7;
    Console.WriteLine(a + b + c);
    Console.WriteLine((a + b + c) / 3);*/

// Task 6

/*int sum = 0;
while (a > 0)
{
    sum = sum + a % 10;
    a = a / 10;
}
    Console.WriteLine(sum);*/



// Task 7

/*int a = Convert.ToInt32 (Console.ReadLine());
if (a % 2 == 0) ;
{
    Console.WriteLine("ededimiz cut ededdir");
}*/

// Task 8

/*int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
if (a > b)
{
    Console.WriteLine(a);
}
else
{
    Console.WriteLine(b);
}*/

// Task 9
/*int a = Convert.ToInt32(Console.ReadLine());
if (a > 0)
{
    Console.WriteLine(" eded musbetdir");
}
else if (a < 0)
{
    Console.WriteLine(" eded menfidir");
}
else
{
    Console.WriteLine("eded sifirdir");
}
*/
// Task 10
/*int a = Convert.ToInt32(Console.ReadLine());
if(a%3==0 && a % 5 == 0)
{
    Console.WriteLine("hem 3e, hem 5e bolunur");
}
else
{
    Console.WriteLine("hem 3e,hem 5e bolunmur");
}*/

// Task 11
/*int a = Convert.ToInt32(Console.ReadLine());
if(a%2==0 && a % 3 == 0)
{
    Console.WriteLine("hem 2e,hem 3e bolunur");
}
else
{
    Console.WriteLine("hem 2e,hem 3e bolunmur");
}*/

//Task 12
/*Console.WriteLine();
int month = Convert.ToInt32(Console.ReadLine());

switch (month)
{
    case 1:
        Console.WriteLine("yanvar");
        break;
    case 2:
        Console.WriteLine("fevral");
        break;
    case 3:
        Console.WriteLine("mart");
        break;
    case 4:
        Console.WriteLine("aprel");
        break;
    case 5:
        Console.WriteLine("may");
        break;
    case 6:
        Console.WriteLine("iyun");
        break;
    case 7:
        Console.WriteLine("iyul");
        break;
    case 8:
        Console.WriteLine("avqust");
        break;
    case 9:
        Console.WriteLine("sentyabr");
        break;
    case 10:
        Console.WriteLine("oktyabr");
        break;
    case 11:
        Console.WriteLine("noyabr");
        break;
    case 12:
        Console.WriteLine("dekabr");
        break;
    default:
        Console.WriteLine("ayi duzgun qeyd edin");
        break;
}*/

// Task 13
/*Console.WriteLine("balinizi daxil edin");
int bal = Convert.ToInt32(Console.ReadLine());
if (bal >= 91 && bal <= 100)
{
    Console.WriteLine("A aldiniz");
}
else if (bal >= 81 && bal <= 90)
{
    Console.WriteLine("B aldiniz");
}
else if (bal >= 71 && bal <= 80)
{
    Console.WriteLine(" C aldiniz");
}
else if (bal >= 61 && bal <= 70)
{
    Console.WriteLine("D aldiniz");
}
else if (bal >= 51 && bal <= 60)
{
    Console.WriteLine("E aldiniz");
}
else
{
    Console.WriteLine("muhasibatliq yolunuzu gozleyir");
}*/

// Task 14
/*Console.WriteLine();
Console.WriteLine("birinci ededi daxil edin");
double a = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("ikici ededi daxil edin");
double b = Convert.ToDouble(Console.ReadLine);
Console.WriteLine("isareni daxil edin");
char simvol= Convert.ToChar(Console.ReadLine());

switch (simvol)
{
    case '+':
        Console.WriteLine(" cavab:{a+b}");
        break;
    case '-':
        Console.WriteLine(" cavab:{a-b}");
        break;
    case '*':
        Console.WriteLine("cavab:{a*b}");
        break;
    case '/':
        if (b != 0)
        {
            Console.WriteLine(" cavab:{a/b}");
        }
        else {
            Console.WriteLine("0-a bolme yoxdur");
        }
            break;
    default:
        Console.WriteLine("yanlis emeliyyat secmisiniz");
        break;
} */

// Task 15
/*Console.WriteLine("meblegi daxil et");
double a = Convert.ToDouble(Console.ReadLine());
double endirim = 1;
if (a >= 100)
{
    endirim=a*90/100;
    Console.WriteLine($"alinan mehsulun deyeri {a} azn,odeyeceyiniz  mebleg {endirim} AZN(10% endirim tetbiq olundu) ");
}
else if(a>=50 && a <= 99)
{
    endirim = a * 95/100;
    Console.WriteLine($"alinan mehsulun deyeri {a} AZN.Odeyeceyiniz mebleg  {endirim} AZN(5% endirim tetbiq olundu");
}
else if(a>0 && a < 50)
{ 
    Console.WriteLine("endirim yoxdur");
}
else
{
    Console.WriteLine("Daxil etdiyiniz mebleg yanlisdir");
}*/

// Task 16
/*double sifre = 222;
Console.WriteLine("adinizi daxil edin");
string ad1 = Convert.ToString(Console.ReadLine());
if (ad1 == "admin")
{
    Console.WriteLine("daxil etdiyiniz ad dogrudur");
}
else
{
    Console.WriteLine("daxil etdiyiniz ad yanlisdir");
}
double sifre1 = Convert.ToDouble(Console.ReadLine());
if (sifre1 == 222)
{
    Console.WriteLine("daxil etdiyiniz sifre dogrudur");
}
else
{
    Console.WriteLine("daxil etdiyiniz sifre yanlisdir");
}*/



// Task 20
/*int[] numbers = { 2, 4, 6, 8, 10, 12 };
for(int i = 0; i< numbers.Length; i++)
{
    Console.WriteLine(nums[i]);
}*/

// Task 21
/*int[] numbers = { 12, 95, 92, 48, 62, 73 };
int sum = 0;
for(int i = 0; i < numbers.Length; i++)
{
    sum+=numbers[i];
}
Console.WriteLine(sum);*/

// Task 22
/*int[] numbers = { 1, 7, 9, 19 };
int sum = 0;
for(int i = 0; i < numbers.Length; i++)
{
    sum = sum + numbers.Length;
}
Console.WriteLine(sum/nums.Length);
*/

// Task 23
/*int[] numbers = { 26, 32, 45, 48, 56, 73 };
int maxElement;
int minElement;
maxElement = numbers[0];
minElement = numbers[0];
for (int i = 0; i < numbers.Length; i++) ;
{
    if (numbers[i] > maxElement)
    {
        maxElement = numbers[i];
    }
}
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] < minElement) 
    {
        minElement = numbers[i];
    }
}
Console.WriteLine($"massivin max elementi:{maxElement},min elementi:{minElement}");*/



// Task 24
/*int[] nums = { 666, 45, 34, 57, 91 };
for(int i = 0; i < nums.Length; i++)
{
    if (nums[i] % 2 == 0)
    {
        Console.WriteLine(nums[i]);
    }
}*/

// Task 25
/*int[] numbers = { 11, 44, 56, 78, 222 };
int[] reversedNumbers = new int[numbers.Length];
for(int i=0; i< numbers.Length; i++)
{
    reversedNumbers[i] = numbers[numbers.Length - 1 - i];
}
foreach(int i in reversedNumbers)
{
    Console.WriteLine(i);
}*/

// Task 27
/*int[] nums= { 1, 7, 14, 16, 14, 22 };
for (int i = 0; i < nums.Length; i++)
{
    for (int j = i+1; j < nums.Length; j++)
    {
        if (nums[i] == nums[j])
        {
            Console.WriteLine(nums[i]);
        }
    }
}*/

// Task 30
/*int a = Convert.ToInt32(Console.ReadLine());
int count = 0;
while (a > 0)
{
    count++;
    a = a / 10;
}
Console.WriteLine($"daxil etdiyiniz ededin reqemlerinin sayi {count}");*/
