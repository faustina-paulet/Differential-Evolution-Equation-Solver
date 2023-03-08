using org.mariuszgromada.math.mxparser;
using System;
using System.Collections.Generic;
using System.Text;


namespace IA_Proiect
{
    public class EquationSolver : IOptimizationProblem
    {
        Function mathEquation;
        int roots;
        double minGenes;
        double maxGenes;

        public EquationSolver(Function equation, int solutions)
        {
            mathEquation = equation;
            roots = solutions;
            minGenes = -10;
            maxGenes = 10;
        }

        public void ComputeFitness(Chromosome c)
        {
            double sum = 0;

            if (c.Genes.Length > 0)
            {
                foreach (var gene in c.Genes)
                {
                    sum += -Math.Abs(mathEquation.calculate(gene));
                }
                c.Fitness = sum;
            }
            else
            {
                c.Fitness = -Math.Abs(mathEquation.calculate(c.Genes[0]));
            }

        }

        public Chromosome MakeChromosome()
        {
            return new Chromosome(roots, minGenes, maxGenes);
        }
    }

}