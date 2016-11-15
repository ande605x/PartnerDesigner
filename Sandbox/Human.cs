using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sandbox
{
   

    class Human
    {
        public enum MaleOrFemale { male, female }
        public enum EyeColor { Brown, Blue, Green }
        public enum HairColor { Brown, Black, White, Blue, Blond, Green, Red }
        public enum HeightCategory { Very_short, _Short, Medium_height, Tall, Very_tall }

        private MaleOrFemale maleOrFemale;
        private EyeColor eyeColor;
        private HairColor hairColor;
        private HeightCategory heightCategory;

        public Human(MaleOrFemale maleOrFemale, EyeColor eyeColor, HairColor hairColor, HeightCategory heightCategory)
        {
            this.maleOrFemale = maleOrFemale;
            this.eyeColor = eyeColor;
            this.hairColor = hairColor;
            this.heightCategory = heightCategory;
        }

        public String GetDescription()
        {
            String description = "You got a " + maleOrFemale;
            description = description + ", with " + eyeColor + " eyes";
            description = description + ", " + hairColor + " hair";
            description = description + ", who is " + GetHeightDescription();

            return description;
        }

        public String GetHeightDescription()
        {
            switch (heightCategory)
            {
                case HeightCategory.Very_short:
                    return "Very short";
                case HeightCategory._Short:
                    return "Short";
                case HeightCategory.Medium_height:
                    return "Medium height";
                case HeightCategory.Tall:
                    return "Tall";
                case HeightCategory.Very_tall:
                    return "Very tall";
                default:
                    return "Unknown height";
            }
        }
    }
}
