using System;

namespace C0730244_WEEK4_PETER
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
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

            class Countryside
            {
                public Village Maple;
                public Village Toronto;
                public Village Ajax;

                public void MapInitializer()
                {
                    Maple = new Village();
                    Maple.VillageName = "Maple";
                    Maple.previousVillage = null;
                    Maple.nextVillage = Toronto;
                    Toronto = new Village();
                    Toronto.VillageName = "Toronoto";
                    Toronto.previousVillage = Maple;
                    Toronto.nextVillage = Ajax;
                    Ajax = new Village();
                    Ajax.VillageName = "Ajax";
                    Ajax.previousVillage = Toronto;
                    Ajax.nextVillage = null;
                    Ajax.isAstrildeHere = true;
                }
                public void LookForAstridileHere()
                {

                }
            }
        }
    }
}
