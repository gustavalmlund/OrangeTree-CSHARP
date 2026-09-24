using System;
using System.Collections.Generic;
using System.Text;

namespace OrangeTreeSim
{
    public class OrangeTree
    {
        private int age;
        private int height;
        private bool treeAlive;
        private int numOranges;
        private int orangesEaten;

        public int Age
        {
            get { return age; }
            set 
            { 
                if (value >= 0)
                    age = value; 
            }
        }
       
        public int Height
        {
            get { return height; }
            set { height = value; }
        }

        public bool TreeAlive
        {
            get { return treeAlive; }
            set { treeAlive = value; }
        }

        public int NumOranges
        {
            get { return numOranges; }
        }

        public int OrangesEaten
        {
            get { return orangesEaten; }
        }

        public void EatOrange(int count)
        {
            if (count <= numOranges)
            {
                orangesEaten += count;
                numOranges -= count;
            }
            else
            {
                orangesEaten += numOranges;
                numOranges = 0;
            }
            
        }

        public void OneYearPasses()
        {
            orangesEaten = 0;
            age++;
            if (age < 80)
            {
                height += 2;
                treeAlive = true;
            }
            else
            {
                treeAlive = false;
            }

            if (!treeAlive)
            {
                numOranges = 0;
            }

            if (age > 1 && age < 80)
            {
                int appelsiner = 5;
                int resultGrowth = (age - 1) * appelsiner;
                numOranges = resultGrowth;
            }
        }
    }
}
