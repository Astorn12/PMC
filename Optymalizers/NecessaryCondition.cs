using PMC_Optymalizer.MathMedia;

namespace PMC_Optymalizer.Optymalizers
{
    public interface NecessaryCondition
    {
         bool IfFulfillNecessaryCondition(Matrix matrix, int m);
    }
}