using System.Collections.Generic;
using PMC_Optymalizer.MathMedia;

namespace PMC_Optymalizer.Optymalizers.ArchesTestRemover
{
    public class ArchRemoverComposite :ArchRemoval
    {
        List<ArchRemoval> archRemovalConditions;
         public ArchRemoverComposite(){
             this.archRemovalConditions= new List<ArchRemoval>();
         }

         public ArchRemoverComposite(params ArchRemoval[] conditions):this(){
             
             this.archRemovalConditions.AddRange(conditions);
         }

        public bool CanRemoveArch(Matrix matrix, int m, int row, int column)
        {
         foreach(ArchRemoval archRemoval in this.archRemovalConditions){
             if(!archRemoval.CanRemoveArch(matrix,m,row,column)) return false;
         }  
         return true;
        }
    }
}