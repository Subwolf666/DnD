using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base_Character {
    public static class StringFunctions {

        public static readonly ReadOnlyCollection<string> RaceGenderText = new ReadOnlyCollection<string>(
            new string[] {
                "Invalid",
                "Female",
                "Male",
            }
        );

        public static readonly ReadOnlyCollection<string> RaceTypeText = new ReadOnlyCollection<string>(
            new string[] {
                "Invalid",
                "Humans",
                "Hill Dwarves",
                "Mountain Dwarves",
                "High Elves",
                "Wood Elves",
                "Lightfoot Halflings",
                "Stout Halflings"
            }
        );

        public static readonly ReadOnlyCollection<string> ClassTypeText = new ReadOnlyCollection<string>(
            new string[] {
                "Invalid",
                "Cleric",
                "Fighter",
                "Rogue",
                "Wizard"
            }
        );

        public static readonly ReadOnlyCollection<string> AbilityNames = new ReadOnlyCollection<string>(
            new string[] {
                "Strength",
                "Dexterity",
                "Constitution",
                "Intelligence",
                "Wisdom",
                "Charisma",
            }
        );

        public static readonly ReadOnlyCollection<string> AbilityShortNames = new ReadOnlyCollection<string>(
            new string[] {
                "STR",
                "DEX",
                "CON",
                "INT",
                "WIS",
                "CHA",
            }
        );

        public static readonly ReadOnlyCollection<string> AbilityMeasure = new ReadOnlyCollection<string>(
            new string[] {
                "Natural athleticism, bodily power",
                "Physical agility, reflexes, balance, poise",
                "Health, stamina, vital force",
                "Mental acuity, information recall, analytical skill",
                "Awareness, intuition, insight",
                "Confidence, eloquence, leadership"
            }
        );

        public static readonly ReadOnlyCollection<string> AbilityImportance = new ReadOnlyCollection<string>(
            new string[] {
                "Fighter",
                "Rogue",
                "Everyone",
                "Wizard",
                "Cleric",
                "Leaders and diplomatic characters"
            }
        );

        // Character Race Descriptions
        public static readonly string RaceDescriptionTextHighElves = 
                "With their unearthly grace and fine features, elves appear hauntingly beautiful to humans and members of many other races. They are slightly shorter than humans on average, ranging from well under 5 feet " +
                "tall to just over 6 feet. They are more slender than humans, weighing only 100 to 145 pounds. Males and females are about the same height, and males are only marginally heavier than females " +
                "Elves’ coloration encompasses the normal human range and also includes skin in shades of copper, bronze, and almost bluish-white, hair of green or blue, and eyes like pools of liquid gold or silver. Elves have no " +
                "facial and little body hair. They favor elegant clothing in bright colors, and they enjoy simple yet lovely jewelry. As a high elf, you have a keen mind and a mastery of at least the basics of magic. In many of the worlds of" +
                "D&D, there are two kinds of high elves. One type (which includes the gray elves and valley elves of Greyhawk, the Silvanesti of Dragonlance, and the sun elves of the Forgotten Realms) is haughty and reclusive, believing " +
                "themselves to be superior to non-elves and even other elves. The other type (including the high elves of Greyhawk, the Qualinesti of Dragonlance, and the moon elves of the Forgotten Realms) are more common and " +
                "more friendly, and often encountered among humans and other races. The sun elves of Faerûn (also called gold elves or sunrise elves) have bronze skin and hair of copper, black, or golden blond." +
                "Their eyes are golden, silver, or black. Moon elves (also called silver elves or gray elves) are much paler, with alabaster skin sometimes tinged with blue. They often have hair of silver-white, black, " +
                "or blue, but various shades of blond, brown, and red are not uncommon. Their eyes are blue or green and flecked with gold.";

        public static readonly string RaceDescriptionTextHillDwarf =
                "Bold and hardy, dwarves are known as skilled warriors miners, and workers of stone and metal. Though they stand well under 5 feet tall, dwarves are so broad and compact that they can weigh as much as a human standing " +
                "nearly two feet taller. Their courage and endurance are also easily a match for any of the larger folk. Dwarven skin ranges from deep brown to a paler hue tinged with red, but the most common shades are " +
                "light brown or deep tan, like certain tones of earth. Their hair, worn long but in simple styles, is usually black, gray, or brown, though paler dwarves often have red hair. Male dwarves value their beards highly and " +
                "groom them carefully. As a hill dwarf, you have keen senses, deep intuition, and remarkable resilience. The gold dwarves of Faerûn in their mighty southern kingdom are hill dwarves, as are the exiled Neidar and the " +
                "debased Klar of Krynn in the Dragonlance setting.";

        public static readonly string RaceDescriptionTextHuman =
                "In the reckonings of most worlds, humans are the youngest of the common races, late to arrive on the world scene and short-lived in comparison to dwarves, elves, and dragons. Perhaps it is because of their " +
                "shorter lives that they strive to achieve as much as they can in the years they are given. Or maybe they feel they have something to prove to the elder races, and that’s why they build their mighty empires on the " +
                "foundation of conquest and trade. Whatever drives them, humans are the innovators, the achievers, and the pioneers of the worlds.";

        public static readonly string RaceDescriptionTextLightfootHalfling =
                "The diminutive halflings survive in a world full of larger creatures by avoiding notice or, barring that, avoiding offense. Standing about 3 feet tall, they appear relatively harmless and so have managed to survive " +
                "for centuries in the shadow of empires and on the edges of wars and political strife. They are inclined to be stout, weighing between 40 and 45 pounds. Halflings’ skin ranges from tan to pale with a ruddy " +
                "cast, and their hair is usually brown or sandy brown and wavy. They have brown or hazel eyes. Halfling men often sport long sideburns, but beards are rare among them and mustaches even more so. They like to wear " +
                "simple, comfortable, and practical clothes, favoring bright colors. Halfling practicality extends beyond their clothing. They’re concerned with basic needs and simple pleasures and have little use for ostentation. " +
                "Even the wealthiest of halflings keep their treasures locked in a cellar rather than on display for all to see. They have a knack for finding the most straightforward solution to a problem, and have little patience " +
                "for dithering. As a lightfoot halfling, you can easily hide from notice, even using other people as cover. You’re inclined to be affable and get along well with others. In the Forgotten Realms, lightfoot halflings " +
                "have spread the farthest and thus are the most common variety. Lightfoots are more prone to wanderlust than other halflings, and often dwell alongside other races or take up a nomadic life. In the world of Greyhawk, " + 
                "these halflings are called hairfeet or tallfellows.";

        public static readonly string RaceDescriptionTextMountainDwarf =
                "Bold and hardy, dwarves are known as skilled warriors, miners, and workers of stone and metal. Though they stand well under 5 feet tall, dwarves are so broad and compact that they can weigh as much as a human standing " +
                "nearly two feet taller. Their courage and endurance are also easily a match for any of the larger folk. Dwarven skin ranges from deep brown to a paler hue tinged with red, but the most common shades are " +
                "light brown or deep tan, like certain tones of earth. Their hair, worn long but in simple styles, is usually black, gray, or brown, though paler dwarves often have red hair. Male dwarves value their beards highly and " +
                "groom them carefully As a mountain dwarf, you’re strong and hardy, accustomed to a difficult life in rugged terrain. You’re probably on the tall side (for a dwarf), and tend toward lighter coloration. " +
                "The shield dwarves of northern Faerûn, as well as the ruling Hylar clan and the noble Daewar clan of Dragonlance, are mountain dwarves.";

        public static readonly string RaceDescriptionTextStoutHalfling =
                "The diminutive halflings survive in a world full of larger creatures by avoiding notice or, barring that, avoiding offense. Standing about 3 feet tall, they appear relatively harmless and so have managed to survive for centuries " +
                "in the shadow of empires and on the edges of wars and political strife. They are inclined to be stout, weighing between 40 and 45 pounds. Halflings’ skin ranges from tan to pale with a ruddy cast, and their hair is usually brown " +
                "or sandy brown and wavy. They have brown or hazel eyes. Halfling men often sport long sideburns, but beards are rare among them and mustaches even more so. They like to wear simple, comfortable, and practical clothes, favoring " +
                "bright colors. Halfling practicality extends beyond their clothing. They’re concerned with basic needs and simple pleasures and have little use for ostentation. Even the wealthiest of halflings keep their treasures locked in a " +
                "cellar rather than on display for all to see. They have a knack for finding the most straightforward solution to a problem, and have little patience for dithering. As a stout halfling, you’re hardier than average and have " +
                "some resistance to poison. Some say that stouts have dwarven blood. In the Forgotten Realms, these halflings are called stronghearts, and they’re most common in the south.";

        public static readonly string RaceDescriptionTextWoodElf =
                "With their unearthly grace and fine features, elves appear hauntingly beautiful to humans and members of many other races. They are slightly shorter than humans on average, ranging from well under 5 feet tall to just over 6 feet. " +
                "They are more slender than humans, weighing only 100 to 145 pounds. Males and females are about the same height, and males are only marginally heavier than females. Elves’ coloration encompasses the normal human " +
                "range and also includes skin in shades of copper, bronze, and almost bluish-white, hair of green or blue, and eyes like pools of liquid gold or silver. Elves have no facial and little body hair. They favor elegant clothing in " +
                "bright colors, and they enjoy simple yet lovely jewelry. As a wood elf, you have keen senses and intuition, and your fleet feet carry you quickly and stealthily through your native forests. This category includes the wild " +
                "elves (grugach) of Greyhawk and the Kagonesti of Dragonlance, as well as the races called wood elves in Greyhawk and the Forgotten Realms. In Faerûn, wood elves (also called wild elves, green elves, or forest elves) " +
                "are reclusive and distrusting of non-elves. Wood elves’ skin tends to be copperish in hue, sometimes with traces of green. Their hair tends toward browns and blacks, but it is occasionally blond or copper-colored. " +
                "Their eyes are green, brown, or hazel.";

        // Character Class Descriptions
        public static readonly string ClassDescriptionTextCleric =
                "Arms and eyes upraised toward the sun and a prayer on his lips, an elf begins to glow with an inner light that spills out to heal his battle-worn companions. Chanting a song of glory, a dwarf swings his axe " +
                "in wide swaths to cut through the ranks of orcs arrayed against him, shouting praise to the gods with every foe’s fall. Calling down a curse upon the forces of undeath, a human lifts her holy symbol as light pours from it to " +
                "drive back the zombies crowding in on her companions. Clerics are intermediaries between the mortal world and the distant planes of the gods. As varied as the gods they serve, clerics strive to embody the handiwork of " +
                "their deities. No ordinary priest, a cleric is imbued with divine magic.";

        public static readonly string ClassDescriptionTextFighter =
                "A human in clanging plate armor holds her shield before her as she runs toward the massed goblins. An elf behind her, clad in studded leather armor, peppers the goblins with arrows loosed from his exquisite bow. " +
                "The half-orc nearby shouts orders, helping the two combatants coordinate their assault to the best advantage. A dwarf in chain mail interposes his shield between the ogre’s club and his companion, knocking the deadly " +
                "blow aside. His companion, a half-elf in scale armor, swings two scimitars in a blinding whirl as she circles the ogre, looking for a blind spot in its defenses. A gladiator fights for sport in an arena, a master with " +
                "his trident and net, skilled at toppling foes and moving them around for the crowd’s delight—and his own tactical advantage. His opponent’s sword flares with blue light an instant before she sends lightning flashing " +
                "forth to smite him.";

        public static readonly string ClassDescriptionTextRogue =
                "Signaling for her companions to wait, a halfling creeps forward through the dungeon hall. She presses an ear to the door, then pulls out a set of tools and picks the lock in the blink of an eye. Then she disappears into " +
                "the shadows as her fighter friend moves forward to kick the door open. A human lurks in the shadows of an alley while his accomplice prepares for her part in the ambush. When their target—a notorious slaver—passes the alleyway, " +
                "the accomplice cries out, the slaver comes to investigate, and the assassin’s blade cuts his throat before he can make a sound. Suppressing a giggle, a gnome waggles her fingers and magically lifts the key ring from the guard’s belt. " +
                "In a moment, the keys are in her hand, the cell door is open, and she and her companions are free to make their escape. Rogues rely on skill, stealth, and their foes’ vulnerabilities to get the upper hand in any situation. " +
                "They have a knack for finding the solution to just about any problem, demonstrating a resourcefulness and versatility that is the cornerstone of any successful adventuring party";

        public static readonly string ClassDescriptionTextWizard =
                "Clad in the silver robes that denote her station, an elf closes her eyes to shut out the distractions of the battlefield and begins her quiet chant. Fingers weaving in front of her, she completes her spell and launches a " +
                "tiny bead of fire toward the enemy ranks, where it erupts into a conflagration that engulfs the soldiers. Checking and rechecking his work, a human scribes an intricate magic circle in chalk on the bare stone " +
                "floor, then sprinkles powdered iron along every line and graceful curve. When the circle is complete, he drones a long incantation. A hole opens in space inside the circle, bringing a whiff of brimstone from the otherworldly " +
                "plane beyond. Crouching on the floor in a dungeon intersection, a gnome tosses a handful of small bones inscribed with mystic symbols, muttering a few words of power over them. Closing his eyes to see the visions more clearly, " +
                "he nods slowly, then opens his eyes and points down the passage to his left. Wizards are supreme magic-users, defined and united as a class by the spells they cast. Drawing on the subtle weave of magic that permeates the " +
                "cosmos, wizards cast spells of explosive fire, arcing lightning, subtle deception, and brute-force mind control. Their magic conjures monsters from other planes of existence, glimpses the future, or turns slain foes into zombies. " +
                "Their mightiest spells change one substance into another, call meteors down from the sky, or open portals to other worlds.";

    }
}
        //public static readonly ReadOnlyCollection<string> abilityImportance = new ReadOnlyCollection<string>(
        //    new string[] {
        //    }
        //);
