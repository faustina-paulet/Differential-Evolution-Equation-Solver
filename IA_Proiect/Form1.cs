using org.mariuszgromada.math.mxparser;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IA_Proiect
{
    public partial class Form1 : Form
    {
        

        private DifferentialEvolutionaryAlgorithm algorithm = new DifferentialEvolutionaryAlgorithm();

        private int population;
        private int generationSize;
        private int NrGene;
      
      
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var mathEquation = new Function("equation", textBoxEcuatie.Text.ToString(), "x");

            try
            {
                getVariablesFromTextBoxes();
                var problem = new EquationSolver(mathEquation, NrGene);
                textBoxRezultat.Text = solveEquation(problem);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private string solveEquation(IOptimizationProblem problem)
        {
            Chromosome bestCr = algorithm.Solve(problem, population, generationSize);
            string solutions = "";
        
            foreach (var gene in bestCr.Genes)
            {
                solutions = solutions + gene.ToString() + System.Environment.NewLine;   
            }
            return solutions;
        }

        private void getVariablesFromTextBoxes()
        {
           
            try
            {
                population = Exceptii.parseIntoIntegerFromTextbox(textBoxNrPopulatie.Text);
                Exceptii.ExceptionNumberPopulation(population);
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
            try
            {
                generationSize = Exceptii.parseIntoIntegerFromTextbox(textBoxNrGeneratiilor.Text);
                Exceptii.ExceptionNumberGeneration(generationSize);
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }

            try
            {
                NrGene = Exceptii.parseIntoIntegerFromTextbox(textBoxNrGene.Text);
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
            
        }

        private void textBoxRezultat_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxRataIncrucisare_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxNrGene_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxNrMinGene_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBoxNrPopulatie_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
