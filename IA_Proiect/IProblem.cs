using System;
using System.Collections.Generic;
using System.Text;

namespace IA_Proiect
{
    /// <summary>
    /// Interfata pentru problemele de optimizare
    /// </summary>
    public interface IOptimizationProblem
    {
        void ComputeFitness(Chromosome c);

        Chromosome MakeChromosome();
    }
}
