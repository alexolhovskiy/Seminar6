/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.



Alex Olhovskiy
*******************************************************************************/
using System;
class HelloWorld {
    static void  Main()
    {
        //Amount of positive numbers
        Console.WriteLine("Amount of positive numbers is: "+PositiveNumAmount(MakeArr()));
        
        //Intersection point
        double [] arr=new double[2];
        arr=GetIntersectionPoint(MakeLinesArr(),0,1);
        Console.WriteLine("Intersection point: "+arr[0]+","+arr[1]);
        
    }
    
    public static double[,]MakeLinesArr()
    {
        string str="kb";
        
        double[,]arr=new double[2,2];
        
        for(int i=0;i<2;i++)
        {
            Console.WriteLine("Enter line "+(i+1)+" parameters");
            for(int j=0;j<2;j++)
            {
                Console.WriteLine("Enter "+str[j]+""+(i+1)+":");
                arr[i,j]=double.Parse(Console.ReadLine());
            }
        }
        return arr;
    }
    
    
    public static double[] GetIntersectionPoint(double [,]arr,int line_1,int line_2)
    {
        double [] point=new double [2];
        double temp=arr[line_1,0]-arr[line_2,0];
        if(temp==0)
        {
           Console.WriteLine("Lines does not intersect");
           point[0]=double.PositiveInfinity;
           point[1]=double.PositiveInfinity;
        }
        else
        {
            point[0]=(arr[line_2,1]-arr[line_1,1])/temp;
            point[1]=arr[line_1,0]*point[0]+arr[line_1,1];
        }
        
        return point;
    }
    
  
    public static int[] MakeArr()
    {
        Console.WriteLine("Enter amount of numbers");
        int size=int.Parse(Console.ReadLine());
        int [] arr=new int [size];
        for(int i=0;i<size;i++)
        {
            Console.WriteLine("Enter number #"+(i+1));
            arr[i]=int.Parse(Console.ReadLine());
        }
        return arr;
    }
    
    
    public static int PositiveNumAmount(int [] arr)
    {
        int num=0;
        for(int i=0;i<arr.Length;i++)
        {
            if(arr[i]>0)
            {
                num++;
            }
        }
        return num;
    }
}
