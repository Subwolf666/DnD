using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base_Character {
    public class BaseCharacterRaceLightfootHalfling : BaseCharacterRace {
        public BaseCharacterRaceLightfootHalfling() {

            RaceType = RaceTypes.LIGHTFOOTHALFLINGS;
            RaceName = CharacterStrings.RaceTypeNames[(int)RaceType];
            RaceDescription = "The diminutive halflings survive in a world full of larger\n" +
                                "creatures by avoiding notice or, barring that, avoiding\n" +
                                "offense. Standing about 3 feet tall, they appear relatively\n" +
                                "harmless and so have managed to survive for centuries\n" +
                                "in the shadow of empires and on the edges of wars and\n" +
                                "political strife. They are inclined to be stout, weighing\n" +
                                "between 40 and 45 pounds.\n" +
                                "Halflings’ skin ranges from tan to pale with a ruddy\n" +
                                "cast, and their hair is usually brown or sandy brown\n" +
                                "and wavy. They have brown or hazel eyes. Halfling men\n" +
                                "often sport long sideburns, but beards are rare among\n" +
                                "them and mustaches even more so. They like to wear\n" +
                                "simple, comfortable, and practical clothes, favoring\n" +
                                "bright colors.\n" +
                                "Halfling practicality extends beyond their clothing.\n" +
                                "They’re concerned with basic needs and simple\n" +
                                "pleasures and have little use for ostentation. Even the\n" +
                                "wealthiest of halflings keep their treasures locked in a\n" +
                                "cellar rather than on display for all to see. They have\n" +
                                "a knack for finding the most straightforward solution\n" +
                                "to a problem, and have little patience for dithering.\n" +
                                "\n" +
                                "As a lightfoot halfling, you can easily hide from notice,\n" +
                                "even using other people as cover. You’re inclined to be\n" +
                                "affable and get along well with others. In the Forgotten\n" +
                                "Realms, lightfoot halflings have spread the farthest and\n" +
                                "thus are the most common variety.\n" +
                                "Lightfoots are more prone to wanderlust than other\n" +
                                "halflings, and often dwell alongside other races or take\n" +
                                "up a nomadic life. In the world of Greyhawk, these\n" +
                                "halflings are called hairfeet or tallfellows.";
            RaceSubrace = 2;
            // Racial Traits
            RaceTraitsAbilityScoreIncrease = new RaceAbilityScoreIncreaseLightfootHalfling();
            RaceTraitsAge = 18.0f;
            RaceTraitsAlignment = 2;    // Lawfull
            RaceTraitsSize = RaceSizes.SMALL;
            RaceTraitsSpeed = 25;       // feet
            RaceTraitsLanguages = 1;
            // Naturally Stealthy. You can attempt to hide even
            // when you are obscured only by a creature that is at least
            // one size larger than you.
        }
    }
}
