
using System;
using PMC_Optymalizer.MathMedia;
using PMC_Optymalizer.Optymalizers.ArchesTestRemover;

namespace PMC_Optymalizer.Optymalizers
{
    public class PMC
    {
      public Matrix Matrix{get;set;}
      FirstNecessaryCondition first;
      SecondNecessaryCondition second;
      HASyfficientCondition hA;
      int m;

      ArchRemoverComposite archRemoverComposite;

        public PMC(Matrix matrix,int m)
        {
            this.Matrix = matrix;
            this.first= new FirstNecessaryCondition();
            this.second= new SecondNecessaryCondition();
            this.hA=new HASyfficientCondition();
            this.m=m;



            this.archRemoverComposite= new ArchRemoverComposite(




            );
        }

        public bool CheckIfDiagnozable(){

            if(!this.first.IfFulfillNecessaryCondition(Matrix,m))return false;
            System.Console.WriteLine("First NecessaryCondition Pass");
            if(!this.second.IfFulfillNecessaryCondition(Matrix,m))return false;
            System.Console.WriteLine("Second NecessaryCondition Pass");

            return hA.IfFulfillSufficientCondition(Matrix,m);
        }


        public Matrix Optimalize(){

            for(int row=0;row<this.Matrix.N;row++){
                for(int col=0;col<this.Matrix.N;col++){
                    if(this.Matrix.Mat[row,col]==1)
                        TryToRemoveArch(row,col);
                }
            }

            return this.Matrix;

        }



        private void TryToRemoveArch(int row, int col){
            if(this.archRemoverComposite.CanRemoveArch(this.Matrix,this.m,row,col)){

                RemoveArch(row, col);

              //  this.Matrix.Show();
                if(!CheckIfDiagnozable()){
                    ComeBackWithThatArch(row,col);
                    //System.Console.WriteLine("Ten przypadek nie jest diagnozowalny");
                }
                else{
                   // System.Console.WriteLine("Diagnozowalne lecimy dalej");
                }
                
                    
            }
        }

        private void ComeBackWithThatArch(int row, int col)
        {
              this.Matrix.Mat[row,col]=1;
        }

        private void RemoveArch(int row, int col){
            this.Matrix.Mat[row,col]=0;
        }




    }
}