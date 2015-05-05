using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Base_Character;
using Base_Equipment;
using Misc;

namespace CreateCharacter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables
            ConsoleKeyInfo cki;
            //Console.TreatControlCAsInput = true;        // Prevent program from ending if CTL+C is pressed.
            CreateNewCharacter pupke = new CreateNewCharacter();
            BaseCharacterSheet newCharacter = new BaseCharacterSheet();
            var testWeapons = new Weapons().PopulateWeapons();
            var testArmor = new Armor().PopulateArmor();

            //Weapons newweapon = new Weapons();
            //newweapon.PopulateWeapons();
            
            //Armor newarmor = new Armor();
            //WeaponCategory[] testWeapons = new WeaponCategory[];
            //testWeapons = newarmor.PopulateArmor();
            // Introduction of the game
            // Menu:
            //      Create Party
            //          Choose existing characters for party / remove characters from party
            //          Create new character
            //          Delete character
            //          Load all characters
            //          Save all characters
            // 
            //      Start Adventure
            //
            //      Exit game
            //
            newCharacter = pupke.CreateANewCharacter();
            if (newCharacter != null) {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("Name: " + newCharacter.CharacterName);
                Console.WriteLine("Sex: " + newCharacter.CharacterSex);
                Console.WriteLine("Level: " + newCharacter.CharacterLevel);
                Console.WriteLine("Race: " + newCharacter.CharacterRace.RaceName);
                Console.WriteLine("Class: " + newCharacter.CharacterClass.ClassName);
                Console.WriteLine("Gold: " + newCharacter.CharacterGold);
                Console.WriteLine("Height: " + newCharacter.CharacterHeightAndWeight.HeightFeet + "\'" + newCharacter.CharacterHeightAndWeight.HeightInches + "\"");
                Console.WriteLine("Weight: " + newCharacter.CharacterHeightAndWeight.WeightPounds + " lbs");
                Console.WriteLine("==========================================");
                Console.WriteLine("Strength: " + newCharacter.CharacterAbilityScores.Strength.ToString() + " (" + newCharacter.CharacterAbilityModifiers.Strength.ToString() + ")");
                Console.WriteLine("Dexterity: " + newCharacter.CharacterAbilityScores.Dexterity.ToString() + " (" + newCharacter.CharacterAbilityModifiers.Dexterity.ToString() + ")");
                //Console.WriteLine("Race Description: \n" + newCharacter.baseCharacter.CharacterRace.RaceDescription);
                //Console.WriteLine("==========================================");
                //Console.WriteLine("Class Description: \n" + newCharacter.baseCharacter.CharacterClass.ClassDescription);
            } else {
                Console.WriteLine("No Character Created.");
            }

            Console.WriteLine();
            Console.WriteLine("Press Esc to quit.");
            do
            {
                cki = Console.ReadKey(true);
            } while (cki.Key != ConsoleKey.Escape);
        }
    }
}
