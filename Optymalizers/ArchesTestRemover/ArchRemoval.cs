using PMC_Optymalizer.MathMedia;

namespace PMC_Optymalizer.Optymalizers.ArchesTestRemover
{
    public interface ArchRemoval
    {
         bool CanRemoveArch(Matrix matrix,int m, int row, int column);
    }
}