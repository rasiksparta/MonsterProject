using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Monster monsterA = new Monster("m1", 3, new Eye(), new Hair(), new SpecialAbility());
            monsterA.Jump();
            monsterA.Scare();
            Console.Read();
        }
    }

    class Monster
    {
        private string id; // the id
        private int scaryLevel; // the scare level
        private Hair hair; // hair type
        private Eye eye; // eye type
        private SpecialAbility specialAbility; // the special ability of the monster

        /**
         * Constructor 
         * @param id, the id of the monster
         * @param scaryLevel, the scare level of the monster 
         * @param eye, type of the eye of the monster
         * @param hair, type of the hair of the monster
         * @param specialAbility, the special ability the monster possesses
         */
        public Monster(string id, int scaryLevel,Eye eye, Hair hair, SpecialAbility specialAbility)
        {
            this.id = id;
            this.scaryLevel = scaryLevel;
            this.eye = eye;
            this.hair = hair;
            this.specialAbility = specialAbility;
        }

        /**
         * Makes the monster jump
         */
        public void Jump()
        {
            Console.WriteLine("The monster with id: {0} jumps", id);
        }

        /**
         * Makes the monster scare a target
         */
        public void Scare()
        {
            Console.WriteLine("The monster with id: {0} scares", id);
        }

    }

    class MonsterCohort
    {
       
        public MonsterCohort()
        {

        }

    }
    
    class Eye
    {

    }

    class Hair
    {

    }

    class SpecialAbility
    {

    }
}
