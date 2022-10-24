using System;
class program{
   public static void Main(){
        double radie=2.4;
	Console.WriteLine("Cirkelns omkrets: "+CirkelOmkrets(radie));
	Console.WriteLine("Cirkelns area: "+CirkelArea(radie));
}
// pi-värde är bestämt för 3.14
static double CirkelOmkrets(double r){
    double omkrets= 2*3.14*r;
    return omkrets;
}

static double CirkelArea(double r){
    double area= r*r*3.14;
    return area;
}

    }