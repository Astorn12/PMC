using System.Collections.Generic;
using System.Linq;
using PMC_Optymalizer.MathMedia;

namespace PMC_Optymalizer.Optymalizers
{
    public class HASyfficientCondition : SufficientCondition
    {
        public bool IfFulfillSufficientCondition(Matrix matrix, int m)
        {

            for (int p = 0; p < m; p++)
            {
                int subsetSize = matrix.N - 2 * m + p;


                IEnumerable<IEnumerable<int>> v = Subsets(matrix.N, subsetSize);
                //OutputSubset(v);


                foreach (IEnumerable<int> e in v)
                {

                  //  foreach (int i in e) System.Console.Write(i+1 +" ");


                   // System.Console.WriteLine(": "+GetNumberOfOutGoingArchesFromSubset(matrix, e));
                 //   System.Console.WriteLine("");
                    if (GetNumberOfOutGoingArchesFromSubset(matrix, e) <= p) return false;
                }
            }
            return true;
        }


        public int GetNumberOfOutGoingArchesFromSubset(Matrix matrix, IEnumerable<int> subset)
        {
            
            List<int> visitedTops= new List<int>();
            for (int i = 0; i < subset.Count(); i++)
            {
                for (int col = 0; col < matrix.N; col++)
                {
                    if (matrix.Mat[subset.ElementAt(i), col] == 1 && !ArrayContain(subset, col)) 
                    {
                        if(!ArrayContain(visitedTops,col)) visitedTops.Add(col);
                    }
                }
            }

            return visitedTops.Count;
        }


        private bool ArrayContain(IEnumerable<int> subset, int col)
        {
            foreach (int i in subset)
            {
                if (i == col) return true;
            }
            return false;
        }



        private void Show(IEnumerable<IEnumerable<int>> mat)
        {
            foreach (IEnumerable<int> e in mat)
            {
                foreach (int i in e)
                {
                    System.Console.Write(" " + i);
                }
                System.Console.WriteLine("");
            }
        }


        private IEnumerable<IEnumerable<int>> Subsets(int n, int subsetSize)
        {
            IEnumerable<int> sequence = Enumerable.Range(0, n);

            // generate list of sequences containing only 1 element e.g. {1}, {2}, ...
            var oneElemSequences = sequence.Select(x => new[] { x }).ToList();

            // generate List of int sequences
            var result = new List<List<int>>();
            // add initial empty set
            result.Add(new List<int>());

            // generate powerset, but skip sequences that are too long
            foreach (var oneElemSequence in oneElemSequences)
            {
                int length = result.Count;

                for (int i = 0; i < length; i++)
                {
                    if (result[i].Count >= subsetSize)
                        continue;

                    result.Add(result[i].Concat(oneElemSequence).ToList());
                }
            }

            return result.Where(x => x.Count == subsetSize);
        }

        private void OutputSubset(IEnumerable<IEnumerable<int>> subsets)
        {
            //   System.Console.WriteLine("n: {0}", n);
            foreach (var subset in subsets)
            {
                System.Console.WriteLine("\t{0}", string.Join(" ", subset.Select(x => x.ToString())));
            }
        }





    }
}