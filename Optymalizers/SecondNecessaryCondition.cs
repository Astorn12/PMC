using PMC_Optymalizer.MathMedia;

namespace PMC_Optymalizer.Optymalizers
{
    public class SecondNecessaryCondition : NecessaryCondition
    {
        public bool IfFulfillNecessaryCondition(Matrix matrix, int m)
        {
            for(int row=0;row<matrix.N;row++){
                int numberOfIncoming=0;
                for(int i=0;i<matrix.N;i++){
                    if(matrix.Mat[i,row]==1)numberOfIncoming++;
                }
                if(numberOfIncoming<m)return false;
            }


            return true;
        }
    }
}