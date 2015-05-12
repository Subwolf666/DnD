using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Base_Stats;

namespace Base_Monsters {
    public class BaseMonsterSheet {

        public BaseMonsterSheet() { }

        public BaseMonsterSheet(int id, string monstername, int level, Role role, Size size, Origin origin, Type type, Keywords keyword, int xp, int initiative, Senses senses, int sensesvalue, Aura aura, int hitpoints, int currenthitpoints, int ac, int fortitude, int reflex, int will, int savingthrows, SavingThrowEffect savingthroweffect, int speed) {
            ID = id;
            MonsterName = monstername;
            Level = level;
            Role = role;
            Size = size;
            Origin = origin;
            Type = type;
            Keyword = keyword;
            XP = xp;
            Initiative = initiative;
            Senses = senses;
            SensesValue = sensesvalue;
            Aura = aura;
            HitPoints = hitpoints;
            CurrentHitPoints = currenthitpoints;
            AC = ac;
            Fortitude = fortitude;
            Reflex = reflex;
            Will = will;
            SavingThrows = savingthrows;
            SavingThrowEffect = savingthroweffect;
            Speed = speed;
        }
// Monster ID
        public int ID { get; set; }
// Monster Name        
        public string MonsterName { get; set; }
// Level and Role
        public int Level { get; set; }
        public Role Role { get; set; }
// Size, Origin, and Type
        public Size Size { get; set; }
        public Origin Origin { get; set; }
        public Type Type { get; set; }
        public Keywords Keyword { get; set; }
// Experience Points (XP)
        public int XP { get; set; }
// Initiative
        public int Initiative { get; set; }
// Senses
        public Senses Senses { get; set; }
        public int SensesValue { get; set; }
// Aura
        public Aura Aura { get; set; }
            // Keyword, aura, effect
// Hit Points (HP)
        public int HitPoints { get; set; }
        public int CurrentHitPoints {get; set; }
        public int Bloodied { get { return (int)(HitPoints / 2); } }
        public bool isBloodied { get { return CurrentHitPoints <= Bloodied ? true : false; } }
// Defenses
        public int AC { get; set; }
        public int Fortitude { get; set; }
        public int Reflex { get; set; }
        public int Will { get; set; }
// Immune/Resist/Vulnerable

// Saving Throws
        public int SavingThrows { get; set; }
        public SavingThrowEffect SavingThrowEffect { get; set;}
// Speed
        public int Speed { get; set; }
        public int AlternativeMovementModes { get; set; }
// Action Points
        public int ActionPoints { get; set; }
// Attack Powers
        public int AP_Type { get; set; }
        public int AP_Action { get; set; }
        public int AP_Recharge { get; set; }
        public int AP_Keywords { get; set; }
        public int AP_Reach { get; set; }
        public int AP_RangeAreaOrTargets { get; set; }
        public int AP_AttackBonus { get; set; }
        public int AP_TagetDefense { get; set; }
        public int AP_Effect { get; set; }
        public int AP_Miss { get; set; }
        public int AP_SecondaryAttackAfterEffect { get; set; }
// Alignment
        public int Alignment { get; set; }
// Skills
        public int Skills { get; set; }
// Ability Scores
        public Abilities MonsterAbilityScores { get; set; }
        public Abilities MonsterAbilityModifiers { get; set; }
                        //public int Strenght { get; set; }
                        //public int Dexterity { get; set; }
                        //public int Constitution { get; set; }
                        //public int Intelligence { get; set; }
                        //public int Wisdom { get; set; }
                        //public int Charisma { get; set; }
// Languages
        public int Languages { get; set; }
// Healing Surges
        //public int Size { get; set; }
        //public int Size { get; set; }
        //public int Size { get; set; }
        //public int Size { get; set; }
        //public int Size { get; set; }
        //public int Size { get; set; }
        //public int Size { get; set; }
        //public int Size { get; set; }
        //public int Size { get; set; }
        //public int Size { get; set; }
        //public int Size { get; set; }

    }
}
