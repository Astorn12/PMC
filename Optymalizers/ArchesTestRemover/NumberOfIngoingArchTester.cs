using PMC_Optymalizer.MathMedia;

namespace PMC_Optymalizer.Optymalizers.ArchesTestRemover
{
    public class NumberOfIngoingArchTester : ArchRemoval
    {
        public bool CanRemoveArch(Matrix matrix, int m, int row, int column)
        {
            int nuberOfIncomingArch=0;
            for(int i=0;i<matrix.N;i++){
                if(matrix.Mat[i,column]==1)nuberOfIncomingArch++;
            }

            if(nuberOfIncomingArch>=m) return true;
            else return false;
        }
    }
}