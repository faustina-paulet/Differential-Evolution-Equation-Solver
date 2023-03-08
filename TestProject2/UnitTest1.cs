using IA_Proiect;
using NUnit.Framework;

namespace TestProject2
{
    public class Tests
    {
        DifferentialEvolutionaryAlgorithm algorithm = new DifferentialEvolutionaryAlgorithm();
        int genes;
        int generations;
        int populationSize;
       

        [Test]
        public void Test1()
        {
            var function = new org.mariuszgromada.math.mxparser.Function("equation", "x+2", "x");
            populationSize = 100;
            generations = 100;
            genes = 1;
            var equation = new EquationSolver(function, genes);
            Chromosome bestCr = algorithm.Solve(equation, populationSize, generations);
            string solutions = "";
            foreach (var gene in bestCr.Genes)
            {
                solutions = solutions + gene.ToString() + System.Environment.NewLine;
            }
            System.Console.WriteLine("Raspuns corect: -2");
            System.Console.WriteLine(solutions);
            Assert.AreEqual(-2, bestCr.Genes[0], 0.01);
        }

        [Test]
        public void Test2()
        {
            var function = new org.mariuszgromada.math.mxparser.Function("equation", "x^2-9", "x");
            populationSize = 100;
            generations = 100;
            genes = 2;
            var equation = new EquationSolver(function, genes);
            Chromosome bestCr = algorithm.Solve(equation, populationSize, generations);
            string solutions = "";
            foreach (var gene in bestCr.Genes)
            {
                solutions = solutions + gene.ToString() + System.Environment.NewLine;
            }
            System.Console.WriteLine("Raspuns corect: -3,3");
            System.Console.WriteLine(solutions);
            Assert.AreEqual(-3, bestCr.Genes[0], 0.01);
        }

        [Test]
        public void Test3()
        {
            var function = new org.mariuszgromada.math.mxparser.Function("equation", "x^2-1", "x");
            populationSize = 100;
            generations = 100;
            genes = 2;
            var problem = new EquationSolver(function, genes);
            Chromosome bestCr = algorithm.Solve(problem, populationSize, generations);
            string solutions = "";
            foreach (var gene in bestCr.Genes)
            {
                solutions = solutions + gene.ToString() + System.Environment.NewLine;
            }
            System.Console.WriteLine("Raspuns corect: 1, 0.6, -1.6");
            System.Console.WriteLine(solutions);
            Assert.AreEqual(-1, bestCr.Genes[0], 0.01);
            Assert.AreEqual(1, bestCr.Genes[1], 0.01);
        }
    
        [Test]
        public void Test4()
        {
            var function = new org.mariuszgromada.math.mxparser.Function("equation", "x-5", "x");
            populationSize = 100;
            generations = 200;
            genes = 1;
            var equation = new EquationSolver(function, genes);
            Chromosome bestCr = algorithm.Solve(equation, populationSize, generations);
            string solutions = "";
            foreach (var gene in bestCr.Genes)
            {
                solutions = solutions + gene.ToString() + System.Environment.NewLine;
            }
            System.Console.WriteLine("Raspuns corect: -1,1");
            System.Console.WriteLine(solutions);
            Assert.AreEqual(5, bestCr.Genes[0], 0.01);
        }
    }
}
