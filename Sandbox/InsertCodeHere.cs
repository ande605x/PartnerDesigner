using System;

namespace Sandbox
{
    class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line

            //Human h1 = new Human(true, "Brown", "Black", 1);
            //Human h2 = new Human(false, "White", "Blue", 4);
            //Human h3 = new Human(true, "Blond", "Green", 8);

            Human h1 = new Human(Human.MaleOrFemale.male,Human.EyeColor.Brown,Human.HairColor.Black,Human.HeightCategory.Very_short);
        

            Console.WriteLine(h1.GetDescription());
      


            // The LAST line of code should be ABOVE this line
        }
    }
}
