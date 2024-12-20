using System; 

 
public class Program
{
    public static void Main() 
    {
        input a = new input();
        input b = new input(2);
        input c = new input(42,6);
    }       
}

class input
{
    public int num1;
    public int num2;


    public input(){
        num1=0;
        num2=0;
        count d = new count(num1, num2);
        d.Print();
    }
    public input(int n){
        num1=n;
        num2=0;
        count e = new count(num1, num2);
        e.Print();
    }
    public input(int n, int a){
        num1=n;
        num2=a;
        count f = new count(num1, num2);
        f.Print();
    }
}
class count
{
    public int umn;
    public double delenie;
    public int slozchenie;
    public int vichetanie;
    public count(int num1, int num2){
        slozchenie=num1+num2;
        umn=num1*num2;
        if(num2!=0){delenie=num1*10.0/num2/10.0;}
        vichetanie=num1-num2;
    }
    public void Print(){
        Console.WriteLine($"Сложение: {slozchenie}, Умножение: {umn}, Деление: {delenie}, Вычетание: {vichetanie}");
    }
}
