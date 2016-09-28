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
        Random rand;
        public Form1()
        {
            InitializeComponent();
            rand = new Random();
        }



            //All the random Classes that we need

            public class Animal
            {
                //Each animal has 300 genes
                public Gene[] genetics;
                public AnimalPedigree pedigree;

                //All of these important things
                public Phenotype phenotype;
                public Genotype genotype;
                public EnvironmentInfo envInfo;
                public int animalNumber;

                public void GenerateNewRandomAnimal()
                {
                    rand = new Random();
                    genetics = new Gene[300];
                    genetics[0].setGene(rand.Next(1, 3), 2);
                    for (int i = 1; i < 300; i++)
                    {
                        genetics[i].setGene(rand.Next(1, 6), rand.Next(1, 6));
                    }
                }


                //Creates a new animal from 2 existing animals (a sire and a dam)
                public void BreedNewAnimal(Animal _Sire, Animal _Dam)
                {
                    rand = new Random();
                    bool sireSide, damSide;
                    int sireGene, damGene;
                    if (_Sire.genetics[1].sire != 1)
                    {
                        Console.WriteLine(_Sire.animalNumber + " is not male, breeding failed horribly");
                        return;
                    }

                    //each animal has 30 chromosomes, 10 genes per chromosome
                    for (int chromosome = 0; chromosome < 30; chromosome++)
                    {
                        if (rand.Next(1, 3) == 1)

                            for (int currentGene = 0; currentGene < 10; currentGene++)
                            {

                            }
                    }

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
                public bool generationOne = true;
                public AnimalPedigree sire;
                public AnimalPedigree dam;

                public void setPedigree(AnimalPedigree _sire, AnimalPedigree _dam)
                {
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
                public double sex, weaningWeight, inbreedingCoEfficient;
            }

            //The performance values without the environmental factors
            public class Genotype
            {
                public double fertility, birthweight, milk, preWeanGrowth, yearlingGrowth, feedEfficiency, dailyGain, finalWeight;
            }

            public class EnvironmentInfo
            {
                //Contains the environment info for the year as doubles
                public double earlyCalving, beforeWeaning, afterWeaning;
            }
    }
}
