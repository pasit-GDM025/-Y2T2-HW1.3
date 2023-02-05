using System;
class Program{
    public static void Main(string[]args){
        double Input, ans;
        Console.WriteLine("Input number:");
        Input = double.Parse(Console.ReadLine());

        Console.WriteLine("Ans:");
        Console.WriteLine(Cal(Input));

    }
    public static double Cal(double Input){
        if(Input<=0 && Input>-1){
            double ans = Math.Sqrt(1 - Math.Pow(Input,2));
            return ans;
        }
        else if(Input>0 && Input <=1){
            double ans = -(Math.Sqrt(1 - Math.Pow(Input,2)));
            return ans;
        }
        else if(Input<=-1){
            double ans = Cal(Input+2);
            return ans;
        }
        else{
            double ans = Cal(Input-2);
            return ans;
        }
    }
}
