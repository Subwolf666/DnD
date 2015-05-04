using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base_Character {
    public enum SexTypes {
        FEMALE,
        MALE
    }

    public class CharacterDetailsFunctions {
        public static bool ValidateCharacterName(string name) {
            if (string.IsNullOrEmpty(name) || name.Length > 15) {
                return false;
            }
            foreach (char item in name) {
                if (!char.IsLetter(item)) {
                    return false;
                }
            }
            return true;
        }
    }
}
