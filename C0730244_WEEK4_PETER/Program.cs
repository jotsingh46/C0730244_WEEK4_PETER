using System;

namespace C0730244_WEEK4_PETER
{
    class Program
    {
        static void Main(string[] args)
        {
            CountrySide Ontario = new CountrySide();
            Ontario.run();
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
            public Village Temp;

            public void run()
            {
                this.MapInitializer();
                this.LookForAstridile();
            }

            public void MapInitializer()
            {
                Maple = new Village();
                Maple.VillageName = "Maple";
                Maple.previousVillage = null;
                Maple.nextVillage = Toronto;
                Maple.isAstrildeHere = true;
                Toronto = new Village();
                Toronto.previousVillage = Maple;
                Toronto.VillageName = "Toronoto";
                Toronto.nextVillage = Ajax;
                Ajax = new Village();
                Ajax.VillageName = "Ajax";
                Ajax.previousVillage = Toronto;
                Ajax.nextVillage = null;
                //Ajax.isAstrildeHere = true;
            }

            public void LookForAstridile()
            {

                Head = Maple;
                if (Head.isAstrildeHere)
                {
                    Console.WriteLine("Yeah Astrilde is in" + Head.VillageName);
                    Console.ReadLine();
                }

                //while(true)
                //{

                // }

            }
        }
    }
}

