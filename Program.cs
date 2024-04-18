//Задание 1. Напишите программу, которая принимает на
// вход трёхзначное число и удаляет вторую
// 
using System.Threading.Tasks.Dataflow;

int DelSecond (int num)
{

    if (num/1000==0){
        int dz = num/100*10;
        int un = num%10;
        return dz+un;
    }
    else{
        System.Console.WriteLine("This number is not tree-digit");
        return 0;
    }
}
void DelSecond2 (int num){
    if (num/1000==0){
        int dz = num/100*10;
        int un = num%10;
        System.Console.WriteLine(dz+un);
    }
     else{
        System.Console.WriteLine("This number is not tree-digit");
    }
}

System.Console.WriteLine("Enter three-digit number");

int a = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(DelSecond(a));
DelSecond2(a);

// Задание 2. Напишите программу, которая принимает на вход
// трёхзначное число и возводит вторую цифру этого
// числа в степень, равную третьей цифре.

int exponentiation (int num)
{

    if (num/1000==0){
        int dz = num/10%10;
        int un = num%10;
        int i = 1;
        int res = dz;
        while(i<un){
            res = res * dz;
            i=i+1;
        }
        return res;
    }
    else{
        System.Console.WriteLine("This number is not tree-digit:");
        return 0;
    }
}
void exponentiation2 (int num){
    if (num>=100 && num<=999){
        int dz = num/10%10;
        int un = num%10;
        int i = 1;
        int res = dz;
        while(i<un){
            res = res * dz;
            i=i+1;
        }
        System.Console.WriteLine(res);
    }
     else{
        System.Console.WriteLine("This number is not tree-digit");
    }
}

Console.WriteLine("Enter a three-digit number:");

int b = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(exponentiation(b));
exponentiation2(b);

// Задание 3. 
// Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли первое число
// кратным второму. Если первое число некратно
// второму, то программа выводит остаток от деления.



int multiplicity (int a, int b)
{
    if (a%b==0)
    {
        System.Console.WriteLine("These numbers are multiples of");
        return 0;
    }
    else{
        return a%b;
    }
}

void multiplicity2 (int a, int b)
{
    if (a%b==0)
    {
        System.Console.WriteLine("These numbers are multiples of");
    }
    else{
        System.Console.WriteLine(a%b);
    }
}

Console.WriteLine("Enter two any numbers:");

int c = Convert.ToInt32(Console.ReadLine());
int cc = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(multiplicity (c,cc));
multiplicity2(c,cc);


// Задание 4*. 
// Напишите программу, которая выводит третью с
// конца цифру заданного числа или сообщает, что
// третьей цифры нет.

int ReleaseThird(int num){
    if (num>=100){
        num=num/100;
        int res = num%10;
        return res;
    }
    else {
        System.Console.WriteLine("This number hasn't third figure");
        return 0;
    }
}

void ReleaseThird2(int num){
    if (num>=100){
        num=num/100;
        int res = num%10;
        System.Console.WriteLine(res);
    }
    else {
        System.Console.WriteLine("This number hasn't third figure");
    }
}

Console.WriteLine("Enter any number more ninety nine");

int d = Convert.ToInt32(System.Console.ReadLine());
System.Console.WriteLine(ReleaseThird(d));
ReleaseThird2(d);
