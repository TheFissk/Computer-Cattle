using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Computer_Cattle
{
    public partial class Form1 : Form
    {
        public static Random rand;
        DataTable table;
        BindingSource table1;

        public Form1()
        {
            InitializeComponent();
            rand = new Random();
            table = new DataTable();
            table1 = new BindingSource();
            table1.Add(table);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Animal Sire, Dam, Calf;

            Sire = new Animal();            
            Dam = new Animal();
            Calf = new Animal();

            Sire.GenerateNewRandomAnimal("Male");
            Dam.GenerateNewRandomAnimal("Female");
            Calf.BreedNewAnimal(Sire, Dam);

            table.Columns.Add("Gender", typeof(int));
            table.Columns.Add("Gene 15, 1", typeof(int));
            table.Columns.Add("Gene 15, 2", typeof(int));
            table.Columns.Add("Gene 82, 1", typeof(int));
            table.Columns.Add("Gene 82, 2", typeof(int));
            table.Columns.Add("Gene 217, 1", typeof(int));
            table.Columns.Add("Gene 217, 2", typeof(int));

            table.Rows.Add(Sire.genetics[0].sire, Sire.genetics[15].sire, Sire.genetics[15].dam, Sire.genetics[82].sire, Sire.genetics[82].dam, Sire.genetics[217].sire, Sire.genetics[217].dam);
            table.Rows.Add(Dam.genetics[0].sire, Dam.genetics[15].sire, Dam.genetics[15].dam, Dam.genetics[82].sire, Dam.genetics[82].dam, Dam.genetics[217].sire, Dam.genetics[217].dam);
            table.Rows.Add(Calf.genetics[0].sire, Calf.genetics[15].sire, Calf.genetics[15].dam, Calf.genetics[82].sire, Calf.genetics[82].dam, Calf.genetics[217].sire, Calf.genetics[217].dam);

            dataGridView1.DataSource = table;
        }

        //All of the random Classes that we need

        public class Animal
        {
            //I'd rather do without this

            //Each animal has 300 genes
            public Gene[] genetics;
            public AnimalPedigree pedigree;

            //All of these important things
            public Phenotype phenotype;
            public Genotype genotype;
            public EnvironmentInfo envInfo;
            public int animalNumber;


            //may still need to create the genotype and the phenotype data, as well as the EnvironementInfo
            public void GenerateNewRandomAnimal(string gender)
            {
                this.InitializeAnimal();

                this.genetics[0] = new Gene();
                this.genetics[0].dam = 2;
                this.genetics[0].sire = gender.Equals("Male") ? 1 : 2;
                for (int i = 1; i < 300; i++)
                {
                    this.genetics[i] = new Gene();
                    this.genetics[i].setGene(Form1.rand.Next(1, 7), Form1.rand.Next(1, 7));
                }

            }


            //Creates a new animal from 2 existing animals (a sire and a dam)
            public void BreedNewAnimal(Animal sire, Animal dam)
            {
                //checks to make sure this is valid breeding
                if (sire.genetics[0].sire != 1)
                {
                    Console.WriteLine(sire.animalNumber + " is not male, breeding failed horribly");
                    return;
                }

                this.InitializeAnimal();
                bool sireSide, damSide;

                this.pedigree.SetPedigree(this.animalNumber, sire.pedigree, dam.pedigree);

                //Creates the genetics of the Animal
                //each animal has 30 chromosomes, 10 genes per chromosome
                for (int chromosome = 0; chromosome < 30; chromosome++)
                {
                    //Decides which side on the chromosome to start on
                    sireSide = Form1.rand.Next(1, 3).Equals(1);
                    damSide = Form1.rand.Next(1, 3).Equals(1);
                    //Mashes two genes together
                    for (int currentGene = 0; currentGene < 10; currentGene++)
                    {
                        //Do we switch sides?
                        if (Form1.rand.Next(1, 11).Equals(10))
                        {
                            sireSide = sireSide ? false : true;
                        }
                        if (Form1.rand.Next(1, 11).Equals(10))
                        {
                            damSide = damSide ? false : true;
                        }
                        this.genetics[chromosome * 10 + currentGene] = new Gene();
                        this.genetics[chromosome * 10 + currentGene].sire = sireSide ? (sire.genetics[chromosome * 10 + currentGene].sire) : (sire.genetics[chromosome * 10 + currentGene].dam);
                        this.genetics[chromosome * 10 + currentGene].dam = damSide ? (dam.genetics[chromosome * 10 + currentGene].sire) : (dam.genetics[chromosome * 10 + currentGene].dam);
                    }
                }
            }



            private void InitializeAnimal ()
            {
                this.genetics = new Gene[300];
                this.pedigree = new AnimalPedigree();
                this.phenotype = new Phenotype();
                this.genotype = new Genotype();
                this.envInfo = new EnvironmentInfo();
            }

            public void CreatePhenotype()
            {
                //Creates the phenotype of the animal
            }

            public void CreateGenotype()
            {
                //Creates the genotype of the animal
            }


        }

        //Stores the parents, set with setPedigree
        //Does this need to store the Animals numbers?
        public class AnimalPedigree
        {
            public int animalNumber;
            public bool generationOne = true;
            public AnimalPedigree sire;
            public AnimalPedigree dam;

            public void SetPedigree (int _animalNumber)
            {
                animalNumber = _animalNumber;
            }

            public void SetPedigree (int _animalNumber, AnimalPedigree _sire, AnimalPedigree _dam)
            {
                animalNumber = _animalNumber;
                sire = _sire;
                dam = _dam;
            }
        }

        //A single gene, ranges from 1-7 as follows
        //1 = Most dominant, or the Male Gene
        //2 = Dominant, or the Female Gene
        //3 = Co-dominant with 4
        //4 = Co-dominant with 3
        //5 = least reccessive
        //6 = most reccessive
        //7 = Has genetic disease
        public class Gene
        {
            public int sire = -1;
            public int dam = -1;

            public void setGene(int _sire, int _dam)
            {
                sire = _sire;
                dam = _dam;
            }
        }

        //the combination of the genotype and the environment
        public class Phenotype
        {
            //The behind the scences numbers
            public double fertility, birthweight, milk, preWeanGrowth, yearlingGrowth, feedEfficiency, dailyGain, fatThickness, finalWeight;
            //The publically available numbers that aren't above
            public double printedSex, printedWeaningWeight, printedFatThickness, printedDailyGain, printedFinalWeight, printedInbreedingCoEfficient;

            public void GeneratePrintedValues ()
            {

            }
        }

        //The performance values without the environmental factors
        public class Genotype
        {
            public double fertility, birthweight, milk, preWeanGrowth, yearlingGrowth, feedEfficiency, dailyGain, fatThickness, finalWeight;
        }

        public class EnvironmentInfo
        {
            //Contains the environment info for the year as doubles
            public double earlyCalving, beforeWeaning, afterWeaning;
        }
    }
}
