using System;

namespace C0730244_WEEK4_PETER
{
    class Program
    {
        static void Main(string[] args)
        {
            CountrySide Ontario = new CountrySide();
            Ontario.run();
            //LearningExample L = new LearningExample();
            //L.run();
        }
    }

    class LearningExample
    {
        public void run()
        {

            Village Toronto;
            Village a;
            Village b;
            Toronto = new Village();
            a = Toronto;

            Toronto = new Village();
            b = Toronto;

            if (a == b) { Console.WriteLine("Same"); }
            else { Console.WriteLine("different obj refs"); } ;
        }
    }
    class Village
    {
        public static int numberOfVillages = 0;
        public Village nextVillage;
        public Village previousVillage;
        public string VillageName;
        public bool isAstrildeHere = false;

        public Village()
        {
            Village.numberOfVillages++;
        }

        class CountrySide
        {
            public Village Maple;
            public Village Toronto;
            public Village Ajax;
            public Village Head;
            public Village Tail;
            public Village Current;

            public void run()
            {
                this.MapInitializer();
                this.LookForAstridile();
                Console.WriteLine("Hugi Found Astrilde in" + Current.VillageName);
            }

            public void MapInitializer()
            {
                Ajax = new Village();
                Toronto = new Village();
                Maple = new Village();

                Maple.VillageName = "Maple";
                Maple.previousVillage = null;
                Maple.nextVillage = Toronto;
                Maple.isAstrildeHere = true;

                Toronto.previousVillage = Maple;
                Toronto.VillageName = "Toronoto";
                Toronto.nextVillage = Ajax;
                
                Ajax.VillageName = "Ajax";
                Ajax.previousVillage = Toronto;
                Ajax.nextVillage = null;
                //Ajax.isAstrildeHere = true;
            }

            public void LookForAstridile()
            {
                Current = Maple;
                while (Current.nextVillage !=null)
                {
                    if (Current.isAstrildeHere)
                    {
                        Console.WriteLine("Found Astridle");
                        Console.ReadLine();
                        return;
                    }
                    else
                    {
                        Current = Current.nextVillage;
                    }
                }

                //while(true)
                //{

                // }

            }
        }
    }
}

