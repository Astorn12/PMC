using PMC_Optymalizer.MathMedia;

namespace PMC_Optymalizer.Optymalizers
{
    public class FirstNecessaryCondition : NecessaryCondition
    {
        public bool IfFulfillNecessaryCondition(Matrix matrix, int m)
        {
            return matrix.N>=2*m+1;
        }
    }
}