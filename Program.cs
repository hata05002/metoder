using System;
class program{
   public static void Main(){

Console.WriteLine("Skriv tre olika tal:");

double t1= Convert.ToDouble(Console.ReadLine());
double t2= Convert.ToDouble(Console.ReadLine());
double t3= Convert.ToDouble(Console.ReadLine());

Console.WriteLine("medelvärde av talen är:"+ Medel(t1,t2,t3));

}
 static double Medel(double a, double s, double d){
    double medel= a+s+d;
    double medelo= medel/3;
    return medelo;
    
}
     }