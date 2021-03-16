using System;

namespace DnDgenerator
{
    class Program
    {

        static void Main(string[] args)
        {
        /*
        var rand = new Random();

        // CHARACTER
        string[] names =
        {"Bob", "Meanie", "Boudicca", "Caesar", "Napoleon", "Frankie",
        "Leopold", "Minnie", "Kaunotar", "Snow", "Gerrard", "Swifty",
        "Ghandi", "Genevieve", "Arthur", "Drooop", "Ruby", "Khraz"};
        // add an attribute to the personality, such as "suspiciously calm".
        string[] personalities = new string[]
        {"a timid", "an angry", "a calm", "a remorseful", "a loving", "an intelligent",
        "a gentle", "a rude", "an energetic", "a brave", "a creative", "a lazy"};
        string[] races = new string[]
        {"dragonborn", "dwarf", "elf", "gnome", "half-elf", "half-orc",
        "halfling", "human", "tiefling", "goblin", "firbolg", "tortle"};
        string[] classes = new string[]
        {"artificer", "barbarian", "bard", "cleric", "druid", "fighter",
        "monk", "paladin", "ranger", "rogue", "sorcerer", "warlock", "wizard"};
        string[] motivations = new string[]
        {"have to", "need to", "are forced to", "must", "want to", "try to", "swore an oath to",
        "must","should, but wont,", "desire to", "ought to", "promised to", "struggle to"};
        // add an attribute to the verb, such as "secretly kill".
        string[] verbs = new string[]
        {"kill", "save", "locate", "acquire", "avenge", "escape", "destroy",
        "dispose", "disenchant", "resurrect", "follow", "flee from", "challenge"};
        string[] adjective = new string[]
        {"a magical", "a cursed", "the uspeakable", "a beautiful", "a cruel", "an unknown", "a holy",
        "a living", "a flying", "a golden", "a buried", "a small",
        "their own", "a random", "a suspicious", "a blessed", "a deceased", "a mundane", "an evil"};

        string[] goalsPerson = new string[]
        {"queen", "deity", "fey creature", "horror", "warrior", "fiend", "familiar", "pet",
         "ghost", "living weapon", "friend", "sorcerer", "king", "loved one", "hero"};
        string[] goalsObject = new string[]
        {"artifact", "weapon", "heirloom", "treasure", "crown", "cauldron",
         "estate", "monolith", "book", "sword", "armor", "fruit", "thing"};
        string[] goalsConcept = new string[]
        {"patron", "evil", "nightmare", "deity", "vision", "horror", "family", "cause",
         "organization", "infestation", "corruption", "virtue", "forest", "race", "vice"};
        // add an specification to the goal, such as "...at all costs". (?)
        string[] specifications = new string[]
        {"before you die", "at all costs", "if everyone else is okay with it", "before it's too late",
        "by the end of the year", "in absolute secrecy", "and need help doing so", "at some point",
        "unless everyone disagrees with you", "at earliest convenience", "when it suits you",
        "everyday", "before your wedding", "and do it publicly", "or else everything will fall to ruin"};
        // "must kill a magical queen..." 

        //SKILLS
        string[] stats = new string[]
         {"strength", "dexterity", "constitution",
         "intelligence", "wisdom", "charisma"};
        string[] proficiencies = new string[]
         {"light armor", "medium armor", "heavy armor", "shields",
         "simple melee weapons", "simple ranged weapons", "martial melee weapons",
         "martial ranged weapons", "improvised weapons", "disguise kit", "forgery kit",
         "a gaming set of your choice", "one musical instrument of your choice",
         "navigator's tools", "poisoner's kit", "thieves' tools", "herbalism kit",
         "one artisan's tools of your choice"};
        string[] skills = new string[]
         {"acrobatics", "animal handling", "arcana", "athletics", "deception",
         "history", "insight", "intimidation", "investigation", "medicine",
         "nature", "perception", "performance", "persuasion", "religion",
         "sleight of hand", "stealth", "survival"};

        // ADVENTURE
        string[] starts = new string[]
        {"all meet", "are", "all converge", "all join forces", "all unite", 
         "run into each other", "happen to spot each other", "all wake up"};
        string[] places = new string[]
        {"in a prizon", "in a tavern", "at a crossroads", "in an elevated maze",
         "in a mansion", "at the docks", "in a temple", "in a forest", "in the messhall"};
        string[] ways = new string[]
        {"forcefully", "politely", "kindly", "suddenly", "casually", "secretly", "unexpectedly"};
        string[] means = new string[]
        {"summoned", "dragged in", "blackmailed to go", "invited", "inquired to go",
         "requested to go", "ordered to go", "implored to go", "begged to go", "demanded to go"};
        string[] types = new string[]
        {"the local", "a shady", "an unknown", "a mysterious", "the official", "a friendly",
         "an underground", "a wondering", "a random", "a beautiful", "a strange", "a new"};
        string[] initiators = new string[]
        {"queen", "evil", "merchant", "character", "hero", "hooded figure", "politician", "wizard",
         "organization", "guild", "benefactor", "friend", "voice in your head", "dream you all had",
         "group of thugs"};
        */// Old options, moved to the individual methods below.

        Starts:
            Console.Clear();
            Console.WriteLine("What would you like to do? The app will continuously ask for your input.\nInput your preferred output number and hit ENTER.\n");
            Console.WriteLine("1. Generate a DnD character.");
            Console.WriteLine("2. Generate abilities for a character.");
            Console.WriteLine("3. Generate a beginning scenario for your characters.\n");
            Console.WriteLine("Type \"clear\" to clear the console, or \"end\" to close program.\n");

        Choice:
            Console.Write("Your choice: ");
            string input = Convert.ToString(Console.ReadLine());

            switch (input)
            {
                case "1":
                    GenerateCharacter();
                    goto Choice;
                case "2":
                    GenerateStats();
                    goto Choice;
                case "3":
                    GenerateScenario();
                    goto Choice;
                case "clear":
                    goto Starts;
                case "end":
                    break;
                default:
                    Console.WriteLine("Sorry, " + " not valid input. Please try again.");
                    goto Choice;
            }

            Console.WriteLine("Thank you for using DnDgenerator.");
            
            /*
            Console.WriteLine("Hit Any Key to generate a DnD scenario.");
            Console.ReadKey();
            Again:

            int namesIndex = rand.Next(names.Length);
            int personalitiesIndex = rand.Next(personalities.Length);
            int racesIndex = rand.Next(races.Length);
            int classesIndex = rand.Next(classes.Length);
            int motivationsIndex = rand.Next(motivations.Length);
            int verbsIndex = rand.Next(verbs.Length);

            int goalsIndex;
            string goal = "";
            int any = rand.Next(0, 3);
            int flip = rand.Next(0,2);

            if (verbsIndex == 0 || verbsIndex == 1)                     // KILL, SAVE
            {goalsIndex = rand.Next(goalsPerson.Length);
                goal = goalsPerson[goalsIndex];
            }
            else if (verbsIndex == 4 || verbsIndex == 9 && flip == 0)   // AVENGE, RESURRECT
            {goalsIndex = rand.Next(goalsPerson.Length);
                goal = goalsPerson[goalsIndex];
            }
            else if (verbsIndex == 4 || verbsIndex == 9 && flip == 1)   // AVENGE, RESURRECT
            {goalsIndex = rand.Next(goalsConcept.Length);
                goal = goalsConcept[goalsIndex];
            }
            else if (verbsIndex == 3 || verbsIndex == 7)                // ACQUIRE, DISPOSE
            {goalsIndex = rand.Next(goalsObject.Length);
                goal = goalsObject[goalsIndex];
            }
            else if (verbsIndex == 6 && flip == 0)                      // DESTROY
            {goalsIndex = rand.Next(goalsObject.Length);
                goal = goalsObject[goalsIndex];
            }
            else if (verbsIndex == 6 && flip == 1)                      // DESTROY
            {goalsIndex = rand.Next(goalsConcept.Length);
                goal = goalsConcept[goalsIndex];
            }
            else 
                switch (any)                                            // LOCATE, ESCAPE
                {   case 0:                                             // DISENCHANT, FOLLOW
                        goalsIndex = rand.Next(goalsPerson.Length);     // FLEE FROM, CHALLENGE
                        goal = goalsPerson[goalsIndex];
                        break;
                    case 1:
                        goalsIndex = rand.Next(goalsObject.Length);
                        goal = goalsObject[goalsIndex];
                        break;
                    case 2:
                        goalsIndex = rand.Next(goalsConcept.Length);
                        goal = goalsConcept[goalsIndex];
                        break;}


            int adjectiveIndex = rand.Next(adjective.Length);
            //int goalsIndex = rand.Next(goals.Length);
            int specificationsIndex = rand.Next(specifications.Length);

            int stats1Index = rand.Next(stats.Length);
            int stats2Index = rand.Next(stats.Length);
        statcheck:
            if (stats1Index == stats2Index)
            {
                stats2Index = rand.Next(stats.Length);
                goto statcheck;
            }
            int proficiencies1Index = rand.Next(proficiencies.Length);
            int proficiencies2Index = rand.Next(proficiencies.Length);
        profcheck:
            if (proficiencies1Index == proficiencies2Index)
            {
                proficiencies2Index = rand.Next(proficiencies.Length);
                goto profcheck;
            }
            int skills1Index = rand.Next(skills.Length);
            int skills2Index = rand.Next(skills.Length);
        skillcheck:
            if (skills1Index == skills2Index)
            {
                skills2Index = rand.Next(skills.Length);
                goto skillcheck;
            }

            int startsIndex = rand.Next(starts.Length);
            int placesIndex = rand.Next(places.Length);
            int waysIndex = rand.Next(ways.Length);
            int meansIndex = rand.Next(means.Length);
            int typesIndex = rand.Next(types.Length);
            int initiatorsIndex = rand.Next(initiators.Length);


            Console.WriteLine("You are {0}, {1} {2} {3}, and you {4} {5} {6} {7} {8}.",
                names[namesIndex],
                personalities[personalitiesIndex],
                races[racesIndex],
                classes[classesIndex],
                motivations[motivationsIndex],
                verbs[verbsIndex],
                adjective[adjectiveIndex],
                goal,
                specifications[specificationsIndex]);
            // You are {Aaro}, {a timid} {half-elf} {barbarian}, who {wants to} {destroy} {all evil}.

            Console.ReadKey();

            Console.WriteLine("You have a high {0} score but a low {1} score.\nYou have proficiency with {2}" +
                " and {3},\nand you are proficient in the {4} and {5} skills.",
                stats[stats1Index],
                stats[stats2Index],
                proficiencies[proficiencies1Index],
                proficiencies[proficiencies2Index],
                skills[skills1Index],
                skills[skills2Index]);
            // You have a high {intelligence} and a low {dexterity}, you have proficiency
            // with {battleaxes} and {light armor}, as well as in the {insight} and {perception} skills.

            Console.ReadKey();

            Console.WriteLine("You {0} {1} because you were {2} {3} there by {4} {5}.",
                starts[startsIndex],
                places[placesIndex],
                ways[waysIndex],
                means[meansIndex],
                types[typesIndex],
                initiators[initiatorsIndex]);
            // You {meet} {in a tavern}, and were {summoned} by {an underground} {organization}.

            Console.ReadKey();
            goto Again;
            */// Old executions, moved to the Choice switch above.
        }

        static void GenerateCharacter()
        {
            var rand = new Random();

            // CHARACTER
            string[] names =
            {"Bob", "Meanie", "Boudicca", "Caesar", "Napoleon", "Frankie",
            "Leopold", "Minnie", "Kaunotar", "Snow", "Gerrard", "Swifty",
            "Ghandi", "Genevieve", "Arthur", "Drooop", "Ruby", "Khraz"};
            // add an attribute to the personality, such as "suspiciously calm".
            string[] personalities = new string[]
            {"a timid", "an angry", "a calm", "a remorseful", "a loving", "an intelligent",
            "a gentle", "a rude", "an energetic", "a brave", "a creative", "a lazy"};
            string[] races = new string[]
            {"dragonborn", "dwarf", "elf", "gnome", "half-elf", "half-orc",
            "halfling", "human", "tiefling", "goblin", "firbolg", "tortle"};
            string[] classes = new string[]
            {"artificer", "barbarian", "bard", "cleric", "druid", "fighter",
            "monk", "paladin", "ranger", "rogue", "sorcerer", "warlock", "wizard"};
            string[] motivations = new string[]
            {"have to", "need to", "are forced to", "must", "want to", "are trying to", "swore an oath to",
            "must", "should, but wont,", "desire to", "ought to", "promised to", "wish to"};
            // add an attribute to the verb, such as "secretly kill".
            string[] verbs = new string[]
            {"kill", "save", "locate", "acquire", "avenge", "escape from", "destroy",
            "dispose", "disenchant", "resurrect", "follow", "flee from", "challenge"};
            string[] adjective = new string[]
            {"a magical", "a cursed", "the uspeakable", "a beautiful", "a cruel", "an unknown", "a holy",
            "a sentient", "a flying", "a golden", "a buried", "a small",
            "your own", "a random", "a suspicious", "a blessed", "a deceased", "a mundane", "an evil"};

            string[] goalsPerson = new string[]
            {"queen", "deity", "fey creature", "horror", "warrior", "fiend", "familiar", "old mentor",
             "ghost", "living weapon", "friend", "sorcerer", "king", "loved one", "hero"};
            string[] goalsObject = new string[]
            {"artifact", "weapon", "heirloom", "treasure", "crown", "cauldron",
             "estate", "monolith", "book", "sword", "armor", "fruit", "thing"};
            string[] goalsConcept = new string[]
            {"patron", "evil", "nightmare", "deity", "vision", "horror", "family", "cause",
             "organization", "infestation", "corruption", "virtue", "forest", "race", "vice"};
            // add an specification to the goal, such as "...at all costs". (?)
            string[] specifications = new string[]
            {"before you die", "at all costs", "before it's too late",
            "by the end of the year", "in absolute secrecy", "and need help doing so", "at some point",
            "before someone else does",
            "everyday", "before your wedding", "or else everything will fall to ruin"};
            // "must kill a magical queen..." 

            int namesIndex = rand.Next(names.Length);
            int personalitiesIndex = rand.Next(personalities.Length);
            int racesIndex = rand.Next(races.Length);
            int classesIndex = rand.Next(classes.Length);
            int motivationsIndex = rand.Next(motivations.Length);
            int verbsIndex = rand.Next(verbs.Length);

            int goalsIndex;
            string goal = "";
            int any = rand.Next(0, 3);
            int flip = rand.Next(0, 2);

            if (verbsIndex == 0 || verbsIndex == 1)                     // KILL, SAVE
            {
                goalsIndex = rand.Next(goalsPerson.Length);
                goal = goalsPerson[goalsIndex];
            }
            else if (verbsIndex == 4 || verbsIndex == 9 && flip == 0)   // AVENGE, RESURRECT
            {
                goalsIndex = rand.Next(goalsPerson.Length);
                goal = goalsPerson[goalsIndex];
            }
            else if (verbsIndex == 4 || verbsIndex == 9 && flip == 1)   // AVENGE, RESURRECT
            {
                goalsIndex = rand.Next(goalsConcept.Length);
                goal = goalsConcept[goalsIndex];
            }
            else if (verbsIndex == 3 || verbsIndex == 7)                // ACQUIRE, DISPOSE
            {
                goalsIndex = rand.Next(goalsObject.Length);
                goal = goalsObject[goalsIndex];
            }
            else if (verbsIndex == 6 && flip == 0)                      // DESTROY
            {
                goalsIndex = rand.Next(goalsObject.Length);
                goal = goalsObject[goalsIndex];
            }
            else if (verbsIndex == 6 && flip == 1)                      // DESTROY
            {
                goalsIndex = rand.Next(goalsConcept.Length);
                goal = goalsConcept[goalsIndex];
            }
            else
                switch (any)                                            // LOCATE, ESCAPE
                {
                    case 0:                                             // DISENCHANT, FOLLOW
                        goalsIndex = rand.Next(goalsPerson.Length);     // FLEE FROM, CHALLENGE
                        goal = goalsPerson[goalsIndex];
                        break;
                    case 1:
                        goalsIndex = rand.Next(goalsObject.Length);
                        goal = goalsObject[goalsIndex];
                        break;
                    case 2:
                        goalsIndex = rand.Next(goalsConcept.Length);
                        goal = goalsConcept[goalsIndex];
                        break;
                }

            int adjectiveIndex = rand.Next(adjective.Length);
            //int goalsIndex = rand.Next(goals.Length);
            int specificationsIndex = rand.Next(specifications.Length);

            Console.WriteLine("You are {0}, {1} {2} {3}, and you {4} {5} {6} {7} {8}.",
                names[namesIndex],
                personalities[personalitiesIndex],
                races[racesIndex],
                classes[classesIndex],
                motivations[motivationsIndex],
                verbs[verbsIndex],
                adjective[adjectiveIndex],
                goal,
                specifications[specificationsIndex]);
            // You are {Aaro}, {a timid} {half-elf} {barbarian}, who {wants to} {destroy} {all evil}.

        }
        static void GenerateStats()
        {
            var rand = new Random();

            //SKILLS
            string[] stats = new string[]
             {"strength", "dexterity", "constitution",
             "intelligence", "wisdom", "charisma"};
            string[] proficiencies = new string[]
             {"light armor", "medium armor", "heavy armor", "shields",
             "simple melee weapons", "simple ranged weapons", "martial melee weapons",
             "martial ranged weapons", "improvised weapons", "disguise kit", "forgery kit",
             "a gaming set of your choice", "one musical instrument of your choice",
             "navigator's tools", "poisoner's kit", "thieves' tools", "herbalism kit",
             "one artisan's tools of your choice"};
            string[] skills = new string[]
             {"acrobatics", "animal handling", "arcana", "athletics", "deception",
             "history", "insight", "intimidation", "investigation", "medicine",
             "nature", "perception", "performance", "persuasion", "religion",
             "sleight of hand", "stealth", "survival"};

            int stats1Index = rand.Next(stats.Length);
            int stats2Index = rand.Next(stats.Length);
        statcheck:
            if (stats1Index == stats2Index)
            {
                stats2Index = rand.Next(stats.Length);
                goto statcheck;
            }
            int proficiencies1Index = rand.Next(proficiencies.Length);
            int proficiencies2Index = rand.Next(proficiencies.Length);
        profcheck:
            if (proficiencies1Index == proficiencies2Index)
            {
                proficiencies2Index = rand.Next(proficiencies.Length);
                goto profcheck;
            }
            int skills1Index = rand.Next(skills.Length);
            int skills2Index = rand.Next(skills.Length);
        skillcheck:
            if (skills1Index == skills2Index)
            {
                skills2Index = rand.Next(skills.Length);
                goto skillcheck;
            }

            Console.WriteLine("You have a high {0} score but a low {1} score.\nYou have proficiency with {2}" +
                " and {3},\nand you are proficient in the {4} and {5} skills.",
                stats[stats1Index],
                stats[stats2Index],
                proficiencies[proficiencies1Index],
                proficiencies[proficiencies2Index],
                skills[skills1Index],
                skills[skills2Index]);
            // You have a high {intelligence} and a low {dexterity}, you have proficiency
            // with {battleaxes} and {light armor}, as well as in the {insight} and {perception} skills.

        }
        static void GenerateScenario()
        {
            var rand = new Random();

            // ADVENTURE
            string[] starts = new string[]
            {"all meet", "are", "all converge", "all join forces", "all unite",
             "run into each other", "happen to spot each other", "all wake up"};
            string[] places = new string[]
            {"in a prizon", "in a tavern", "at a crossroads", "in an elevated maze",
             "in a mansion", "at the docks", "in a temple", "in a forest", "in the messhall"};
            string[] ways = new string[]
            {"forcefully", "politely", "kindly", "suddenly", "casually", "secretly", "unexpectedly"};
            string[] means = new string[]
            {"summoned", "dragged in", "blackmailed to go", "invited", "inquired to go",
             "requested to go", "ordered to go", "implored to go", "begged to go", "demanded to go"};
            string[] types = new string[]
            {"the local", "a shady", "an unknown", "a mysterious", "the official", "a friendly",
             "an underground", "a wondering", "a random", "a beautiful", "a strange", "a new"};
            string[] initiators = new string[]
            {"queen", "evil", "merchant", "character", "hero", "hooded figure", "politician", "wizard",
             "organization", "guild", "benefactor", "friend", "voice in your head", "dream you all had",
             "group of thugs"};

            int startsIndex = rand.Next(starts.Length);
            int placesIndex = rand.Next(places.Length);
            int waysIndex = rand.Next(ways.Length);
            int meansIndex = rand.Next(means.Length);
            int typesIndex = rand.Next(types.Length);
            int initiatorsIndex = rand.Next(initiators.Length);

            Console.WriteLine("You {0} {1} because you were {2} {3} there by {4} {5}.",
                starts[startsIndex],
                places[placesIndex],
                ways[waysIndex],
                means[meansIndex],
                types[typesIndex],
                initiators[initiatorsIndex]);
            // You {meet} {in a tavern}, and were {summoned} by {an underground} {organization}.
        }
    }
}
