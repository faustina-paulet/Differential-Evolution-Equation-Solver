using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IA_Proiect
{
    /// <summary>
    /// Clasa care reprezinta operatia de selectie
    /// </summary>
    public class Selection
    {
        // Cu functia GetBest se returnează individul din populație cu funcția de adaptare maximă
        public static Chromosome GetBest(List<Chromosome> population)
        {
            var best = population[0];
            for (var i = 1; i < population.Count; ++i)
            {
                if (best.Fitness < population[i].Fitness)
                {
                    best = population[i];
                }
            }
            return new Chromosome(best);

        }
    }

    /// <summary>
    /// Clasa care implementeaza algoritmul diferential pentru optimizare
    /// </summary>
    public class DifferentialEvolutionaryAlgorithm
    {
        private static readonly Random _rand = new Random();

        /// <summary>
        /// Metoda de optimizare care gaseste solutia problemei
        /// </summary>
        public Chromosome Solve(IOptimizationProblem p, int populationSize, int maxGenerations)
         {

            double pc = 0.9;
            double pm = 0.8;

            List<Chromosome> population = new List<Chromosome>(); 

            // initializare
            for (int i = 0; i < populationSize; i++)
            {
                population.Add(p.MakeChromosome());     
                p.ComputeFitness(population[i]);     
            }
         

            for (int gen = 0; gen < maxGenerations; gen++) 
            {
                List<Chromosome> newPopulation = new List<Chromosome>();

                // mutatie
                foreach (Chromosome cr in population) 
                {
                    int ind1, ind2, ind3;

                    ind1 = _rand.Next(0, population.Count);    
                    ind2 = _rand.Next(0, population.Count);    
                    ind3 = _rand.Next(0, population.Count);

                    Chromosome cr1 = population[ind1];
                    Chromosome cr2 = population[ind2];
                    Chromosome cr3 = population[ind3];     

                    Chromosome individPotential = new Chromosome(cr1);          
                    int pctDivizare = _rand.Next(0, population.Count);   
                    for (int i = 0; i < individPotential.Genes.Length; i++) 
                    {
                        // incrucisare
                        if (_rand.NextDouble() < pc  || i == pctDivizare)
                        {
                            individPotential.Genes[i] = cr1.Genes[i] + pm * (cr2.Genes[i] - cr3.Genes[i]);
                        }
                        else
                        {
                            individPotential.Genes[i] = cr.Genes[i];   
                        }
       
                    }

                    // selectie
                    p.ComputeFitness(individPotential); 
                    if (individPotential.Fitness >= cr.Fitness)
                    {
                        newPopulation.Add(individPotential); 
                    }
                    else
                    {
                        newPopulation.Add(cr); 
                    }
    
                }
                population = newPopulation;
            }

            return Selection.GetBest(population);
        }
    }
}
