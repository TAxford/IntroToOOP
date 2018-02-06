using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToOOP
{
    class SuperHero
    {
        private string name;
        private bool power;
        private bool isStrong = false;
        private bool hasWeapons = true;

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public bool Power
        {
            get { return this.power; }
            set { this.power = value; }
        }

        public bool IsStrong
        {
            get { return this.isStrong; }
            set { this.isStrong = false; }
        }

        public bool HasWeapons
        {
            get { return this.hasWeapons; }
            set { this.hasWeapons = true; }
        }

        public SuperHero()
        {

        }

        public SuperHero(string name, bool power)
        {
            this.name = name;
            this.power = power;
        }

        public SuperHero(bool isStrong, bool hasWeapons)
        {
            this.isStrong = false;
            this.hasWeapons = true;
        }

        public void bendMetal()
        {
            if (isStrong)
            {
                isStrong = false;
            }

            Console.WriteLine("My superhero can bend meal? " + isStrong + "Which leads to loseing health and energy");
        }

        public void sunLight()
        {
            if (power)
            {
                power = true;
            }
            Console.WriteLine("Sunlight is my superheros true power" + power);
        }
