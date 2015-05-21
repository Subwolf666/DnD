using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base_Monsters {
    public enum Aura {
        None,
        Resist,

    }
    public enum Size {
        Tiny,
        Small,
        Medium,
        Large,
        Huge,
        Cargantuan,
    }
    public enum Origin {
        Aberrant,
        Elemental,
        Fey,
        Immortal,
        Natural,
        Shadow,
    }
    public enum Type {
        Animate,
        Beast,
        Humanoid,
        Magicalbeast,
    }
    public enum Keywords {
        None,
        Acid,
        Air,
        Angel,
        Aquatic,
        Blind,
        Charm,
        Cold,
        Conjuration,
        Construct,
        Demon,
        Devil,
        Disease,
        Dragon,
        Earth,
        Fear,
        Fire,
        Force,
        Gaze,
        Giant,
        Healing,
        Homunculus,
        Illusion,
        Lightning,
        LivingConstruct,
        Mount,
        Necrotic,
        Ooze,
        Poison,
        Polymorph,
        Plant,
        Psychic,
        Radiant,
        Reptile,
        Shapechanger,
        Sleep,
        Spider,
        Swarm,
        Teleportation,
        Thunder,
        Undead,
        Water,
        Zone,
    }
    public enum Senses {
        None,
        Darkvision,
        Perception,
        Tremorsense,
    }
    public enum MovementMode {
        Burrow,
        Climb,
        Fly,

    }
    public enum Role {
        Artillery,
        Brute,
        Lurker,
        Minion,
        Skirmisher,
        Soldier,

    }
    public enum AttackPowers {
        BullRush,
        Grab,
        MeleeBasicAttack,
        OppertunityAttack,
        RangedBasicAttack,
    }
    public enum AttackPowersType {
        Melee,
        Ranged,
        Close,
        Area,
    }
    public enum AttackPowersAction {
        Standard,
        Move,
        Minor,
        ImmediateInterrupt,
        ImmediateReaction,
        Free,
        Sustain,
    }
    public enum AttackPowersRecharge {
        AtWill,
        Encounter,
        Daily,
        Recharge,
        RechargesWhen,
    }
    public enum AttackPowersKeyword {

    }
    
    public enum SavingThrowEffect {
        None,
        AgainstFear,

    }
    public enum MonsterPolymorph {
        ChangeShape,

    }
    public enum MonsterIllusion {
        DeceptiveVeil,

    }
    public class Enums {
        public static readonly int MONSTER_ID_NONE = 0;
        public static readonly int MONSTER_ID_HALFLINGSLINGER = 1000;
        public static readonly int MONSTER_ID_KOBOLDSLINGER = 1001;
        public static readonly int MONSTER_ID_DIRERAT = 1002;
        public static readonly int MONSTER_ID_FIREBEETLE = 1003;
        public static readonly int MONSTER_ID_RIDINGHORSE = 1004;
        public static readonly int MONSTER_ID_GOBLINBLACKBLADE = 1005;
        public static readonly int MONSTER_ID_STIRGE = 1006;
        public static readonly int MONSTER_ID_DECREPITSKELETON = 1007;
        public static readonly int MONSTER_ID_GIANTRAT = 1008;
        public static readonly int MONSTER_ID_GOBLINCUTTER = 1009;
        public static readonly int MONSTER_ID_KOBOLDMINION = 1010;
        public static readonly int MONSTER_ID_GOBLINWARRIOR = 1011;
        public static readonly int MONSTER_ID_KOBOLDSKIRMISHER = 1012;
        public static readonly int MONSTER_ID_SPIRETOPDRAKE = 1013;
        public static readonly int MONSTER_ID_STORMCLAWSCORPION = 1014;
        //public static readonly int MONSTER_ID_ = 1000;
        //public static readonly int MONSTER_ID_ = 1000;
        //public static readonly int MONSTER_ID_ = 1000;
        //public static readonly int MONSTER_ID_ = 1000;
        //public static readonly int MONSTER_ID_ = 1000;
        //public static readonly int MONSTER_ID_ = 1000;
        //public static readonly int MONSTER_ID_ = 1000;
        //public static readonly int MONSTER_ID_ = 1000;
        //public static readonly int MONSTER_ID_ = 1000;
        //public static readonly int MONSTER_ID_ = 1000;
        //public static readonly int MONSTER_ID_ = 1000;
        //public static readonly int MONSTER_ID_ = 1000;
        //public static readonly int MONSTER_ID_ = 1000;
        //public static readonly int MONSTER_ID_ = 1000;

    }
}
// Aftereffect
// All-Around Vision
// Aura
// Blindsight
// Combat Advantage
// Darkvision
// Elite
// EarthWalk    // See Terrain Walk
// Forest Walk  // See Terrain Walk
// Gaseous Form
// Ice Walk     // See Terrain Walk
// Immune
// Insubstantial
// Low-Light Vision
// Minion
// Ongoing Damage
// Phasing
// Pull
// Push
// Regeneration
// Resist - Aura
// Slide
// Solo
// Sustain
// Swamp Walk   // See Terrain Walk
// Telepathy
// Threatening Reach
// Tremorsense
// Truesight
// Vulnerable
// 