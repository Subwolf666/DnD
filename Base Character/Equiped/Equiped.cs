using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Base_Equipment;

namespace Base_Character {
    public class Equiped {

        public Base_Equipment.ArmorType EquipedArmor { get; set; }
        public Base_Equipment.ArmorType EquipedShield { get; set; }

        public Base_Equipment.WeaponsType EquipedWeaponLeftHand { get; set; }
        public Base_Equipment.WeaponsType EquipedWeaponRightHand { get; set; }

        public Equiped() { }

        public Equiped(Base_Equipment.ArmorType equipedArmor, Base_Equipment.ArmorType equipedShield, Base_Equipment.WeaponsType equipedWeaponLeftHand, Base_Equipment.WeaponsType equipedWeaponRightHand) {
            EquipedArmor = equipedArmor;
            EquipedShield = equipedShield;
            EquipedWeaponLeftHand = equipedWeaponLeftHand;
            EquipedWeaponRightHand = equipedWeaponRightHand;
        }

        public Equiped EquipWeaponsAndArmor(BaseCharacterClass Class) { // By Class

            // 
            BaseCharacterClass newClass = new BaseCharacterClass();
            var allarmor = new Armor().PopulateArmor();

            foreach (Base_Equipment.Enums.ArmorTypes armort in Class.ClassFeaturesProficienciesArmor) {
                if (armort == Base_Equipment.Enums.ArmorTypes.ARMOR_ID_NONE) {
                    EquipedArmor = allarmor[(int)Base_Equipment.Enums.ArmorTypes.ARMOR_ID_NONE].ArmorTypes[(int)Base_Equipment.Enums.LightArmorTypes.LIGHTARMOR_ID_NONE];
                } else if (armort == Base_Equipment.Enums.ArmorTypes.ARMOR_ID_LIGHTARMOR) {
                    EquipedArmor = allarmor[(int)Base_Equipment.Enums.ArmorTypes.ARMOR_ID_LIGHTARMOR].ArmorTypes[(int)Base_Equipment.Enums.LightArmorTypes.LIGHTARMOR_ID_PADDED];
                }

            }
            if (Class.ClassFeaturesProficienciesArmor[0] == Base_Equipment.Enums.ArmorTypes.ARMOR_ID_NONE) { // No Armor
                Console.WriteLine("Hello");
                Console.ReadLine();
            }

            return null;
        }
    }
}
