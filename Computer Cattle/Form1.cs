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
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        public Random rand;
    }

    public class Animal
    {
        //Each animal has 200 genes
        public Gene[] genetics;
        public Random rand;
        public AnimalPedigree pedigree;
        public int animalNumber;

        public void GenerateNewRandomAnimal ()
        {
            genetics = new Gene[200];
            genetics[0].setGene(rand.Next(1, 2), 2);
            for (int i = 1; i < 200; i++)
            {
                genetics[i].setGene(rand.Next(1, 6), rand.Next(1, 6));
            }
        }

        public void BreedNewAnimal(Animal _Sire, Animal _Dam)
        {
            //When you are ready to write the "Breed animal code"
        }

        public void CreatePhenotype ()
        {
            //Creates the phenotype of the animal
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

    //the combination of the genome and the environment
    public class Phenotype
    {
        double fertility, birthweight, milk, preWeanGrowth, yearlingGrowth, feedEfficiency, dailyGain, finalWeight;
    }

    public class EnvironmentInfo
    {
        //Contains the environment info for the year as doubles
        public double earlyCalving, beforeWeaning, afterWeaning;
    }
}
