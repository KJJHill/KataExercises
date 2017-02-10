using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariableNaming
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
            1. 4 birds are sitting on a branch. 1 flies away. How many birds are left on
            the branch? 
            */
            int birdsOnABranch = 4;
            int birdsThatFlewAway = 1;
            int birdsLeftOnBranch = birdsOnABranch - birdsThatFlewAway;

            /* 
            2. There are 6 birds and 3 nests. How many more birds are there than
            nests? 
            */
            int birds = 6;
            int nests = 3;
            int howManyNestsAreNeeded = birds - nests;

            /* 
            3. 3 raccoons are playing in the woods. 2 go home to eat dinner. How
            many raccoons are left in the woods? 
            */
            int raccoonsPlaying = 3;
            int raccoonsWentHome = 2;
            int raccoonsLeftInWoods = raccoonsPlaying - raccoonsWentHome;

            /* 
            4. There are 5 flowers and 3 bees. How many less bees than flowers? 
            */
            int numberOfFlowers = 5;
            int numberOfBees = 3;
            int lessBees = numberOfFlowers - numberOfBees;

            /* 
            5. 1 lonely pigeon was eating breadcrumbs. Another pigeon came to eat
            breadcrumbs, too. How many pigeons are eating breadcrumbs now? 
            */
            int beginningPigeons = 1;
            int additionalPigonFriends = 1;
            int totalPigeons = beginningPigeons + additionalPigonFriends;

            /* 
            6. 3 owls were sitting on the fence. 2 more owls joined them. How many
            owls are on the fence now? 
            */
            int owlsOnAFence = 3;
            int owlsThatJoined = 2;
            int totalOwls = owlsOnAFence + owlsThatJoined;

            /* 
            7. 2 beavers were working on their home. 1 went for a swim. How many
            beavers are still working on their home? 
            */
            int beaversWorking = 2;
            int beaversSwimming = 1;
            int beaversLeft = beaversWorking - beaversSwimming;

            /* 
            8. 2 toucans are sitting on a tree limb. 1 more toucan joins them. How
            many toucans in all? 
            */
            int toucansOnTreeLimb = 2;
            int toucansJoining = 1;
            int totalToucans = toucansOnTreeLimb + toucansJoining;

            /* 
            9. There are 4 squirrels in a tree with 2 nuts. How many more squirrels
            are there than nuts? 
            */
            int squirrels = 4;
            int nuts = 2;
            int squirrelsThatNeedNuts = squirrels - nuts;

            /* 
            10. Mrs. Hilt found a quarter, 1 dime, and 2 nickels. How much money did
            she find? 
            */
            decimal quarter = 0.25M;
            decimal dime = 0.10M;
            decimal nickel = 0.05M;
            decimal total = quarter + dime + 2 * nickel;
            //Console.WriteLine("Mrs. Hilt's total is is: $" + total);

            /* 
            11. Mrs. Hilt's favorite first grade classes are baking muffins. Mrs. Brier's
            class bakes 18 muffins, Mrs. MacAdams's class bakes 20 muffins, and
            Mrs. Flannery's class bakes 17 muffins. How many muffins does first
            grade bake in all? 
            */
            int briersMuffins = 18;
            int macAdamsMuffins = 20;
            int flannerysMuffins = 17;
            int totalMuffins = briersMuffins + macAdamsMuffins + flannerysMuffins;

            /*
            12. Mrs. Hilt bought a yoyo for 24 cents and a whistle for 14 cents. How
            much did she spend in all for the two toys?
            */
            decimal yoyo = 0.24M;
            decimal whistle = 0.14M;
            decimal totalToyPricePaid = yoyo + whistle;

            /*
            13. Mrs. Hilt made 5 Rice Krispie Treats. She used 8 large marshmallows
            and 10 mini marshmallows.How many marshmallows did she use
            altogether?
            */
            int largeMarshmallows = 8;
            int miniMarshmallows = 10;
            int totalMarshmallows = largeMarshmallows + miniMarshmallows;

            /*
            14. At Mrs. Hilt's house, there was 29 inches of snow, and Brecknock
            Elementary School received 17 inches of snow. How much more snow
            did Mrs. Hilt's house have?
            */
            int hiltsSnow = 29;
            int elementarySnow = 17;
            int additionalSnow = hiltsSnow - elementarySnow;

            /*
            15. Mrs. Hilt has $10. She spends $3 on a toy truck and $2 on a pencil
            case. How much money does she have left?
            */
            int cashAmount = 10;
            int toyTruckPrice = 3;
            int pencilPrice = 2;
            cashAmount = cashAmount - toyTruckPrice - pencilPrice;

            /*
            16. Josh had 16 marbles in his collection. He lost 7 marbles. How many
            marbles does he have now?
            */
            int marblesInCollection = 16;
            int marblesLost = 7;
            int totalMarblesInCollection = marblesInCollection - marblesLost;

            /*
            17. Megan has 19 seashells. How many more seashells does she need to
            find to have 25 seashells in her collection?
            */
            int initialSeashells = 19;
            int seashellsWanted = 25;
            int seashellsNeeded = seashellsWanted - initialSeashells;


            /*
            18. Brad has 17 balloons. 8 balloons are red and the rest are green. How
            many green balloons does Brad have?
            */
            int bradsBalloons = 17;
            int redBalloons = 8;
            int greenBalloons = bradsBalloons - redBalloons;

            /*
            19. There are 38 books on the shelf. Marta put 10 more books on the shelf.
            How many books are on the shelf now?
            */
            int initialBooksOnShelf = 38;
            int booksAddedToShelf = 10;
            int booksOnShelf = initialBooksOnShelf + booksAddedToShelf;

            /*
            20. A bee has 6 legs. How many legs do 8 bees have?
            */
            int beeLegs = 6;
            int totalBees = 8;
            int aTotalOfBeeLegs = beeLegs * totalBees;

            /*
            21. Mrs. Hilt bought an ice cream cone for 99 cents. How much would 2 ice
            cream cones cost?
            */
            decimal iceCreamCost = 0.99M;
            int iceCreamsBought = 2;
            decimal iceCreamTotalCost = iceCreamCost * iceCreamsBought;

            /*
            22. Mrs. Hilt wants to make a border around her garden. She needs 125
            rocks to complete the border. She has 64 rocks. How many more rocks
            does she need to complete the border?
            */
            int gardenBorder = 125;
            int borderRocksPurchased = 64;
            int borderRocksNeeded = gardenBorder - borderRocksPurchased;

            /*
            23. Mrs. Hilt had 38 marbles. She lost 15 of them. How many marbles does
            she have left?
            */
            int begMarbles = 38;
            int lostMarbles = 15;
            int remainingMarbles = begMarbles - lostMarbles;

            /*
            24. Mrs. Hilt and her sister drove to a concert 78 miles away. They drove 32
            miles and then stopped for gas. How many miles did they have left to drive?
            */
            int tripMiles = 78;
            int milesDriven = 32;
            int milesLeft = tripMiles - milesDriven;

            /*
            25. Mrs. Hilt spent 1 hour and 30 minutes shoveling snow on Saturday
            morning and 45 minutes shoveling snow on Saturday afternoon. How
            much total time did she spend shoveling snow?
            */
            int minsShovelingOnSaturday = 90;
            int minsShovelingOnSunday = 45;
            int hoursShoveling = (minsShovelingOnSaturday + minsShovelingOnSunday) / 60;
            int minsLeftOver = (minsShovelingOnSaturday + minsShovelingOnSunday) - (hoursShoveling* 60);


            /*    
            26. Mrs. Hilt bought 6 hot dogs. Each hot dog cost 50 cents. How much
            money did she pay for all of the hot dogs?
            */
            int hotDogsBought = 6;
            decimal costOfHotDog = 0.50M;
            decimal costPaid = hotDogsBought * costOfHotDog;

            /*
            27. Mrs. Hilt has 50 cents. A pencil costs 7 cents. How many pencils can
            she buy with the money she has?
            */
            decimal hiltsMoney = 0.50M;
            decimal pencilCost = 0.07M;
            int totalPencilsBought = (int)(hiltsMoney / pencilCost);
           // Console.WriteLine(totalPencilsBought);

            /*    
            28. Mrs. Hilt saw 33 butterflies. Some of the butterflies were red and others
            were orange. If 20 of the butterflies were orange, how many of them
            were red?
            */
            int butterfliesSeen = 38;
            int orangeButterflies = 20;
            int redButterflies = butterfliesSeen - orangeButterflies;

            /*    
            29. Kate gave the clerk $1.00. Her candy cost 54 cents. How much change
            should Kate get back?
            */
            decimal kateMoney = 1.00M;
            decimal candyCost = 0.54M;
            decimal moneyLeft = kateMoney - candyCost;
            //Console.WriteLine(moneyLeft);

            /*
            30. Mark has 13 trees in his backyard. If he plants 12 more, how many trees
            will he have?
            */
            int initialTrees = 13;
            int plantedTrees = 12;
            int treesInBackyard = initialTrees + plantedTrees;

            /*    
            31. Joy will see her grandma in two days. How many hours until she sees
            her?
            */
            int daysTillGrandma = 2;
            int hoursInADay = 24;
            int hoursTillGrandma = daysTillGrandma * hoursInADay;

            /*
            32. Kim has 4 cousins. She wants to give each one 5 pieces of gum. How
            much gum will she need?
            */
            int cousins = 4;
            int piecesOfGum = 5;
            int totalGum = cousins * piecesOfGum;

            /*
            33. Dan has $3.00. He bought a candy bar for $1.00. How much money is
            left?
            */
            decimal dansMoney = 3M;
            decimal candyBar = 1M;
            decimal remaining = dansMoney - candyBar;


            /*
            34. 5 boats are in the lake. Each boat has 3 people. How many people are
            on boats in the lake?
            */

            int boats = 5;
            int peopleInBoats = 3;
            int totalPeople = boats * peopleInBoats;

            /*
            35. Ellen had 380 legos, but she lost 57 of them. How many legos does she
            have now?
            */
            int legos = 380;
            int legosLost = 57;
            int remainingLegos = legos - legosLost;

            /*
            36. Arthur baked 35 muffins. How many more muffins does Arthur have to
            bake to have 83 muffins?
            */
            int muffins = 35;
            int totalMuffinsWanted = 83;
            int muffinsNeeded = totalMuffinsWanted - muffins;

            /*
            37. Willy has 1400 crayons. Lucy has 290 crayons. How many more
            crayons does Willy have then Lucy?
            */
            int willyCrayons = 1400;
            int lucyCrayons = 290;
            int extraCrayons = willyCrayons - lucyCrayons;

            /*
            38. There are 10 stickers on a page. If you have 22 pages of stickers, how
            many stickers do you have?
            */
            int stickersOnAPage = 10;
            int pages = 22;
            int totalStickers = stickersOnAPage * pages;

            /*
            39. There are 96 cupcakes for 8 children to share. How much will each
            person get if they share the cupcakes equally?
            */
            int cupcakes = 96;
            int children = 8;
            int cupcakesPerChild = cupcakes / children;

            /*
            40. She made 47 gingerbread cookies which she will distribute equally in
            tiny glass jars. If each jar is to contain six cookies each, how many
            cookies will not be placed in a jar?
            */
            int gingerbreadCookies = 47;
            int cookiesLeftOut = gingerbreadCookies % 6;

            /*
            41. She also prepared 59 croissants which she plans to give to her 8
            neighbors. If each neighbor received and equal number of croissants,
            how many will be left with Marian?
            */

            int croissants = 59;
            int neighbors = 8;
            int leftOver = croissants % neighbors;

            /*
            42. Marian also baked oatmeal cookies for her classmates. If she can
            place 12 cookies on a tray at a time, how many trays will she need to
            prepare 276 oatmeal cookies at a time?
            */
            int oatmealCookies = 276;
            int traysNeeded = (oatmealCookies / 12) + 1;


            /*
            43. Marian’s friends were coming over that afternoon so she made 480
            bite-sized pretzels. If one serving is equal to 12 pretzels, how many
            servings of bite-sized pretzels was Marian able to prepare?
            */

            int pretzels = 480;
            int servingSize = 12;
            int totalServings = pretzels / servingSize;

            /*
            44. Lastly, she baked 53 lemon cupcakes for the children living in the city
            orphanage. If two lemon cupcakes were left at home, how many
            boxes with 3 lemon cupcakes each were given away?
            */
            int lemonCupcakes = 53;
            int cupcakesLeftAtHome = 2;
            int cupcakesTotal = lemonCupcakes - cupcakesLeftAtHome;
            int boxesOfCupcakes = cupcakesTotal / 3;

            /*
            45. Susie's mom prepared 74 carrot sticks for breakfast. If the carrots
            were served equally to 12 people, how many carrot sticks were left
            uneaten?
            */
            int preparedCarrots = 74;
            int peopleEatingCarrots = 12;
            int leftUneaten = preparedCarrots % peopleEatingCarrots;


            /*
            46. Susie and her sister gathered all 98 of their teddy bears and placed
            them on the shelves in their bedroom. If every shelf can carry a
            maximum of 7 teddy bears, how many shelves will be filled?
            */

            int teddyBears = 98;
            int shelfMaximum = 7;
            int totalFullShelves = teddyBears / shelfMaximum;


            /*
            47. Susie’s mother collected all family pictures and wanted to place all of
            them in an album. If an album can contain 20 pictures, how many
            albums will she need if there are 480 pictures?
            */

            int totalPictures = 480;
            int picturesInBook = 20;
            int totalBooks = totalPictures / picturesInBook;

            /*
            48. Joe, Susie’s brother, collected all 94 trading cards scattered in his
            room and placed them in boxes. If a full box can hold a maximum of 8
            cards, how many boxes were filled and how many cards are there in
            the unfilled box?
            */
            int tradingCards = 94;
            int cardsInABox = 8;
            int boxesNeeded = tradingCards / cardsInABox;
            int cardsLeftOver = tradingCards % cardsInABox;

            /*
            49. Susie’s father repaired the bookshelves in the reading room. If he has
            210 books to be distributed equally on the 10 shelves he repaired,
            how many books will each shelf contain?
            */

            int books = 210;
            int shelves = 10;
            int booksOnSelf = books / shelves;

            /*
            50. Cristina baked 17 croissants. If she planned to serve this equally to
            her seven guests, how many will each have?
            */
            int croissant = 17;
            int guests = 7;
            int croissantPerGuest = croissant / guests;

           

        }
    }
}
