using PMC_Optymalizer.MathMedia;

namespace PMC_Optymalizer.Optymalizers
{
    public interface SufficientCondition
    {
          bool IfFulfillSufficientCondition(Matrix matrix, int m);
    }
}