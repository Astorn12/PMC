using System;
using System.Collections.Generic;
using PMC_Optymalizer.MathMedia;

namespace PMC_Optymalizer.ShitHelpers
{
    public class ShitdiagAdapter
    {
        




        public int GetNumberOfOnes(string graf){

            int sum=0;
            char[] cs= graf.ToCharArray();

            foreach(char c in cs){
                if(c=='1')sum+=1;
            }

            return sum;

        }

        public Matrix GetMatrixFromString(string s){
            List<int> ones= new List<int>();
            
           char[] cs= s.ToCharArray();

            foreach(char c in cs){
                if(c=='1')ones.Add(1);
                else if(c=='0')ones.Add(0);
            }

            Matrix matrix= new Matrix((int)(Math.Sqrt((double)ones.Count)+0.5));
            matrix.Initiateparams(ones.ToArray());

            return matrix;
        }
    }
}