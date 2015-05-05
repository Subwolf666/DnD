using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turn_Based_StateMachine {
    class CombatStateMachine {
        enum TurnTypes {
            SURPRISE,
            INITIATIVE,
            CHARACTERSTURN,
            BONUSACTIONS,
            OTHERACTIVITY,
            REACTIONS,



        }
        // COMBAT (chapter 9)

        //
        // The order of combat
        //
        // a ROUND is about 6 seconds in the game world.
        // During a round, each character in a battle takes a TURN
        
        // the order of turns is determined at the beginning of
        // a combat encounter, when everyone rolls initiative.

        //
        // SURPRISE
        //
        //  Stealthy monsters or character
        // DM compares the Dexterity (Stealth) checks of anyone hinding
        // with the passive Wisdom (Perception) score of each creature on the opposing side.
        // If you are suprised, you can't move or take an action on your first turn of the combat,
        // and you can't take a reaction until that turn ends.
        // A member of the group can be surprised even if the other members aren't.
        //

        // INITIATIVE
        //
        //  At the beginning of every combat, you (everyone in party) roll initiative by making a Dexterity check. 
        // Initiative determines the order of creatures’ turns in combat, as described in chapter 9.
        // In case of a Tie roll a 1D20
        // Make a List order of highest to lowest dex check roll.
        //

        // YOUR TURN
        //
        //  On your turn, you can:
        // - move a distance up to your speed and take one action. You decide whether to move first
        // - or take your action first. Your speed—sometimes called
        //   your walking speed—is noted on your character sheet.
        //   The most common actions you can take are described
        //   in the “Actions in Combat” section later in this chapter.
        //   Many class features and other abilities provide
        //   additional options for your action.
        //   The “Movement and Position” section later in this
        //   chapter gives the rules for your move.
        //   You can forgo moving, taking an action, or doing
        //   anything at all on your turn. If you can’t decide what to
        //   do on your turn, consider taking the Dodge or Ready
        //   action, as described in “Actions in Combat.”
        //




        // Making an Attack (page 73 DnD Basic Rules v0.2)
        //
        // Choose your target within your attack's range
        //
        // Determine modifiers
        //  Two most common modifiers
        //   Ability Modifier
        //    Melee weapons = Strength modifier
        //    Ranged weapons = Dexterity modifer
        //    Spellcasting see chapter 10
        //   Proficiency Bonus
        //
        // Resolve the attack
        //  attack
        //   attack roll = attack hit or miss. Roll 1D20 and add appropriate modifiers.
        //   if the total of the roll plus modifiers equals or exceeds the target's Armor Class, the attack hits.
        //   D20 roll (without modifiers) = 1 is a miss, roll = 20 attack is critical hit.
        //
        //  Ranged attacks
        //  Melee attacks
        // 
    }
}
//Combat Step by Step
//1.Determine surprise. The DM determines whether anyone
//involved in the combat encounter is surprised.
//2.Establish positions. The DM decides where all the
//characters and monsters are located. Given the
//adventurers’ marching order or their stated positions in
//the room or other location, the DM figures out where the
//adversaries are—how far away and in what direction.
//3.Roll initiative. Everyone involved in the combat encounter
//rolls initiative, determining the order of combatants’ turns.
//4.Take turns. Each participant in the battle takes a turn in
//initiative order.
//5.Begin the next round. When everyone involved in the
//combat has had a turn, the round ends. Repeat step 4 until
//the fighting stops.