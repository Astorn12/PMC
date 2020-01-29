using System;
using System.Collections.Generic;
using System.Linq;

namespace PMC_Optymalizer.MathMedia
{
    public class Matrix
    {
        public int[,] Mat { get; set; }
        public int N { get; set; }
        public Matrix(int n){
            this.N=n;
            this.Mat= new int[this.N,this.N];
        }

        public void Initiateparams(params int[] ints){
            if(ints.GetLength(0)>0){
            if(ints.GetLength(0)!=Math.Pow(N,2)) 
                throw new WrongSizeOfTableToInitiateMatrixException(
                    $"Wymiar podanej tablicy wynosi {ints.GetLength(0)} natomiast powinien wynosić {Math.Pow(N,2)}");
            for(int i=0;i<N;i++){
                for (int j = 0; j < N ;j++)
                {
                    this.Mat[i,j]=ints[N*i+j];
                }
            }
        } else{


              for(int i=0;i<N;i++){
                for (int j = 0; j < N ;j++)
                {
                    if(i==j) this.Mat[i,j]=0;
                    else this.Mat[i,j]=1;
                }
            }
        }
        }

        internal IEnumerable<int> GetListOfNodes()
        {
            List<int> list= new List<int>();
            for (int i = 0; i < N; i++)
            {
                list.Add(i);
            }
            return list;
        }

        public void Show(){
            for(int i=0;i<this.N;i++){
                System.Console.Write(i+1+" [  ");
                for(int j=0;j<this.N;j++){
                    System.Console.Write(Mat[i,j]+" ");
                }
                System.Console.Write("  ]");
                System.Console.WriteLine(" ");
            }
        }

        public int GetNumberOfArch(){
          int sum=0;
            for(int i=0;i<this.N;i++){
               
                for(int j=0;j<this.N;j++){
                    sum+=this.Mat[i,j];
                }
              
            }
            return sum;
        }

        public List<int> GetCyclicGroupLevel(){
            
            List<int> maxGroup= new List<int>();



             for(int i=0;i<this.N;i++){
            
                    List<int> tmpin= new List<int>();
                    List<int> tmpout=GoToNext(tmpin,i);
                        
                    if(maxGroup.Count<tmpout.Count)maxGroup=tmpout;
            }

            return maxGroup;
        } 

        private List<int> GoToNext(List<int> last, int row ){

            List<List<int>> ciclicList= new List<List<int>>();

            for(int col=0;col<N;col++){
                if(this.Mat[row,col]==1&& !ArrayContain(last,col)){
                    List<int> newList=last.Select(i=>i).ToList();
                    newList.Add(col);
                    ciclicList.Add( GoToNext(newList,col));
                }
            }

            List<int> pointer= new List<int>();
            foreach(List<int> list in ciclicList){
                if(pointer.Count()<list.Count) pointer=list;
            }

            return pointer;
        }

         private bool ArrayContain(List<int> subset, int col)
        {
            foreach (int i in subset)
            {
                if (i == col) return true;
            }
            return false;
        }
        
    }
}