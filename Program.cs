using System;
using PMC_Optymalizer.MathMedia;
using PMC_Optymalizer.Optymalizers;
using PMC_Optymalizer.ShitHelpers;

namespace PMC_Optymalizer
{
    class Program
    {
        static void Main(string[] args)
        {
           /* Console.WriteLine("Hello World!");

           

            matrix.Initiateparams();

            foreach(int  i in matrix.GetCyclicGroupLevel())
            {
                System.Console.Write(i+" ");
            }
            PMC pmc= new PMC(matrix,4);
           
             Matrix optimalMatrix=pmc.Optimalize();
             

            System.Console.WriteLine("\n \n Struktura optymalna!!!");
            pmc.Matrix.Show();*/

            ShitdiagAdapter shitdiagAdapter= new ShitdiagAdapter();

            Matrix matrix1=shitdiagAdapter.GetMatrixFromString(
@"0,0,0,0,1,0,0,0,1,
1,0,1,0,0,0,0,0,0,
1,0,0,0,0,0,1,0,1,
1,1,1,0,0,0,0,0,0,
0,1,0,1,0,1,0,1,0,
0,1,0,1,1,0,1,1,0,
0,0,0,0,1,1,0,1,0,
0,0,1,0,0,1,1,0,1,
0,0,1,1,0,0,1,0,0,");
          //  matrix1.Show();

       
            PMC pmc = new PMC(matrix1,3);

            System.Console.WriteLine( pmc.CheckIfDiagnozable());








        }
    }
}
