using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class NameMaker
    {
        private Random nameRNG;
        private string[] syllable = { "ba", "ko", "pop", "bob", "ill", "ul", "ma", "mo", "po", "la", "we", "ize", "em", "ing", "he", "do"};
        private string[] organicsSuffix = { " Roots", " Leaves", " Seeds", " Stalks", " Meat", " Eggs" };
        private string[] delicaciesPrefix = { "", "Fried ", "Steamed ","Boiled ", "Toasted ", "Melted ", "Charred " };
        private string[] delicaciesSuffix = { "", " Toes", " Seeds"," Brains"," Guts"," Fingers"," Leaves"};
        private string[] intoxSuffix = { "", " Buds", " Seeds"," Rock Powder", " Mushrooms", " Toads", " Petals"};

        public NameMaker()
        {
            nameRNG = new Random();
        }

        public String GenerateName(NameType type)
        {
            switch (type)
            {
                case NameType.LOCALGROUP:
                    return BuildName(nameRNG.Next(2, 5), false) + " Group";
                case NameType.SOLARSYSTEM:
                    return BuildName(nameRNG.Next(2, 5), true);
                case NameType.STELLARBODY:
                    return BuildName(nameRNG.Next(2, 5), nameRNG.Next(0,5).Equals(1));
                case NameType.ORGANICS:
                    return BuildName(nameRNG.Next(2, 5), false) + organicsSuffix[nameRNG.Next(organicsSuffix.Length)];
                case NameType.MINERALS:
                    return BuildName(nameRNG.Next(2, 5), false) + "ite";
                case NameType.RARE_ORE:
                    return BuildName(nameRNG.Next(2, 5), true);
                default:
                    return BuildName(nameRNG.Next(2, 5), false);
            }
        }
        public String GenerateName(NaturalProductType npType)
        {
            switch (npType)
            {
                case NaturalProductType.DELICACY:
                    return delicaciesPrefix[nameRNG.Next(delicaciesPrefix.Length)] + BuildName(nameRNG.Next(2, 5), false) + delicaciesSuffix[nameRNG.Next(delicaciesSuffix.Length)];
                case NaturalProductType.FAUNA:
                    return BuildName(nameRNG.Next(2, 5), false) + "ian " + BuildName(nameRNG.Next(2, 5), false);
                case NaturalProductType.FLORA:
                    return BuildName(nameRNG.Next(2, 5), false) + "ian " + BuildName(nameRNG.Next(2, 5), false);
                case NaturalProductType.INTOX:
                    return BuildName(nameRNG.Next(2, 5), false) + intoxSuffix[nameRNG.Next(intoxSuffix.Length)];
                case NaturalProductType.SLAVE:
                    return BuildName(nameRNG.Next(2, 5), false) + "ians";
                default:
                    return BuildName(nameRNG.Next(2, 5), false);
            }
        }

        private String BuildName(int syllableCount, bool hasNumeric)
        {
            string newName = "";
            for(int i = 0; i < syllableCount; i++)
            {
                newName += syllable[nameRNG.Next(syllable.Length)];
            }
            if (hasNumeric)
            {
                newName += "-" + nameRNG.Next(1, 100);
            }
            string firstLetter = newName.ElementAt(0).ToString();
            firstLetter = firstLetter.ToUpper();
            newName = newName.Remove(0, 1);
            newName = newName.Insert(0, firstLetter);
            return newName;
        }
    }
}
