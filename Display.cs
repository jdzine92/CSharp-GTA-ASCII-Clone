using System;
using static System.Console;

class Display
{
    //DISPLAY ASCII TITLE - @ to escape \
    public static void Title()
    {
        WriteLine("       __               __           _          _______________       ________                ");
        WriteLine("      / /___  _________/ /___ _____ ( )_____   / ____/_  __/   |     / ____/ /___  ____  ___  ");
        WriteLine(@" __  / / __ \/ ___/ __  / __ `/ __ \|// ___/  / / __  / / / /| |    / /   / / __ \/ __ \/ _ \ ");
        WriteLine("/ /_/ / /_/ / /  / /_/ / /_/ / / / / (__  )  / /_/ / / / / ___ |   / /___/ / /_/ / / / /  __/ ");
        WriteLine(@"\____/\____/_/   \__,_/\__,_/_/ /_/ /____/   \____/ /_/ /_/  |_|   \____/_/\____/_/ /_/\___/ ");
        TextColour("narratorWriteLine", "==============================================================================================");
        //loading startup bar
        for (int i = 0; i < 93; i++)
        {
            Thread.Sleep(20);
            TextColour("cyanWrite", "/");
        }
        TextColour("cyanWriteLine", "/ \n");
    }

    //DISPLAY ASCII MAPS
    public static void Map(string CurrentLocation)
    {
        switch (CurrentLocation)
        {
            case "HOSPITAL":
                Write("Loading Map:  ");
                Display.Loading(120);
                TextColour("cyanWriteLine", "/// YOU ARE HERE ▲");
                TextColour("map", "┌────────────────────────────────────┐");
                TextColour("map", "│~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ ***│");
                TextColour("map", "│ ~~~~~    ┌────────┐   PALM   ******│");
                TextColour("map", "│  ~~ QUAY │  ^^^^  │  BEACH   ******│");
                TextColour("map", "│  ~ SIDE  └┐  ^^ ┌─┴──┬────┬─*******│");
                TextColour("map", "│  ~   │    │     │ ▲+ │    │  ******│");
                TextColour("map", "│  ~~  └────┴┐    │HOSP│    └── *****│");
                TextColour("map", "│   ~~~      ├────┤    │    COTTLETON│");
                TextColour("map", "│     ~~     │    ├────┼─┬─   **WOODS│");
                TextColour("map", "│  ┌───────┐ ├┬───┤DOWN└─┤    *******│");
                TextColour("map", "│  │    ~~ └─┴┤   │TOWN  │    ┌───┬┐*│");
                TextColour("map", "│  │     ~~   │   │      ├┬───┤   ├┘ │");
                TextColour("map", "│  │     ~~   │   ├──┬───┴┤   │   │  │");
                TextColour("map", "│GLENDALE ~~  └───┴──┤    ├─┬─┴───┘  │");
                TextColour("map", "│ PRISON  ~~  SCARLET└────┴─┘ASHDALE │");
                TextColour("map", "│         ~~   POINT                 │");
                TextColour("map", "└────────────────────────────────────┘\n");
                Thread.Sleep(4000);
                break;
            case "DOWNTOWN":
                Write("Loading Map:  ");
                Display.Loading(120);
                TextColour("cyanWriteLine", "/// YOU ARE HERE ▲");
                TextColour("map", "┌────────────────────────────────────┐");
                TextColour("map", "│~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ ***│");
                TextColour("map", "│ ~~~~~    ┌────────┐   PALM   ******│");
                TextColour("map", "│  ~~ QUAY │  ^^^^  │  BEACH   ******│");
                TextColour("map", "│  ~ SIDE  └┐  ^^ ┌─┴──┬────┬─*******│");
                TextColour("map", "│  ~   │    │     │  + │    │  ******│");
                TextColour("map", "│  ~~  └────┴┐    │HOSP│    └── *****│");
                TextColour("map", "│   ~~~      ├────┤    │    COTTLETON│");
                TextColour("map", "│     ~~     │    ├────┼─┬─   **WOODS│");
                TextColour("map", "│  ┌───────┐ ├┬───┤DOWN└─┤    *******│");
                TextColour("map", "│  │    ~~ └─┴┤   │TOWN  │    ┌───┬┐*│");
                TextColour("map", "│  │     ~~   │   │    ▲ ├┬───┤   ├┘ │");
                TextColour("map", "│  │     ~~   │   ├──┬───┴┤   │   │  │");
                TextColour("map", "│GLENDALE ~~  └───┴──┤    ├─┬─┴───┘  │");
                TextColour("map", "│ PRISON  ~~  SCARLET└────┴─┘ASHDALE │");
                TextColour("map", "│         ~~   POINT                 │");
                TextColour("map", "└────────────────────────────────────┘\n");
                Thread.Sleep(4000);
                break;
            case "QUAY SIDE":
                Write("Loading Map:  ");
                Display.Loading(120);
                TextColour("cyanWriteLine", "/// YOU ARE HERE ▲");
                TextColour("map", "┌────────────────────────────────────┐");
                TextColour("map", "│~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ ***│");
                TextColour("map", "│ ~~~~~    ┌────────┐   PALM   ******│");
                TextColour("map", "│  ~~ QUAY │  ^^^^  │  BEACH   ******│");
                TextColour("map", "│  ~ SIDE  └┐  ^^ ┌─┴──┬────┬─*******│");
                TextColour("map", "│  ~   │ ▲  │     │  + │    │  ******│");
                TextColour("map", "│  ~~  └────┴┐    │HOSP│    └── *****│");
                TextColour("map", "│   ~~~      ├────┤    │    COTTLETON│");
                TextColour("map", "│     ~~     │    ├────┼─┬─   **WOODS│");
                TextColour("map", "│  ┌───────┐ ├┬───┤DOWN└─┤    *******│");
                TextColour("map", "│  │    ~~ └─┴┤   │TOWN  │    ┌───┬┐*│");
                TextColour("map", "│  │     ~~   │   │      ├┬───┤   ├┘ │");
                TextColour("map", "│  │     ~~   │   ├──┬───┴┤   │   │  │");
                TextColour("map", "│GLENDALE ~~  └───┴──┤    ├─┬─┴───┘  │");
                TextColour("map", "│ PRISON  ~~  SCARLET└────┴─┘ASHDALE │");
                TextColour("map", "│         ~~   POINT                 │");
                TextColour("map", "└────────────────────────────────────┘\n");
                Thread.Sleep(4000);
                break;
            case "GLENDALE PRISON":
                Write("Loading Map:  ");
                Display.Loading(120);
                TextColour("cyanWriteLine", "/// YOU ARE HERE ▲");
                TextColour("map", "┌────────────────────────────────────┐");
                TextColour("map", "│~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ ***│");
                TextColour("map", "│ ~~~~~    ┌────────┐   PALM   ******│");
                TextColour("map", "│  ~~ QUAY │  ^^^^  │  BEACH   ******│");
                TextColour("map", "│  ~ SIDE  └┐  ^^ ┌─┴──┬────┬─*******│");
                TextColour("map", "│  ~   │    │     │  + │    │  ******│");
                TextColour("map", "│  ~~  └────┴┐    │HOSP│    └── *****│");
                TextColour("map", "│   ~~~      ├────┤    │    COTTLETON│");
                TextColour("map", "│     ~~     │    ├────┼─┬─   **WOODS│");
                TextColour("map", "│  ┌───────┐ ├┬───┤DOWN└─┤    *******│");
                TextColour("map", "│  │    ~~ └─┴┤   │TOWN  │    ┌───┬┐*│");
                TextColour("map", "│  │     ~~   │   │      ├┬───┤   ├┘ │");
                TextColour("map", "│  │ ▲   ~~   │   ├──┬───┴┤   │   │  │");
                TextColour("map", "│GLENDALE ~~  └───┴──┤    ├─┬─┴───┘  │");
                TextColour("map", "│ PRISON  ~~  SCARLET└────┴─┘ASHDALE │");
                TextColour("map", "│         ~~   POINT                 │");
                TextColour("map", "└────────────────────────────────────┘\n");
                Thread.Sleep(4000);
                break;
            case "SCARLET POINT":
                Write("Loading Map:  ");
                Display.Loading(120);
                TextColour("cyanWriteLine", "/// YOU ARE HERE ▲");
                TextColour("map", "┌────────────────────────────────────┐");
                TextColour("map", "│~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ ***│");
                TextColour("map", "│ ~~~~~    ┌────────┐   PALM   ******│");
                TextColour("map", "│  ~~ QUAY │  ^^^^  │  BEACH   ******│");
                TextColour("map", "│  ~ SIDE  └┐  ^^ ┌─┴──┬────┬─*******│");
                TextColour("map", "│  ~   │    │     │  + │    │  ******│");
                TextColour("map", "│  ~~  └────┴┐    │HOSP│    └── *****│");
                TextColour("map", "│   ~~~      ├────┤    │    COTTLETON│");
                TextColour("map", "│     ~~     │    ├────┼─┬─   **WOODS│");
                TextColour("map", "│  ┌───────┐ ├┬───┤DOWN└─┤    *******│");
                TextColour("map", "│  │    ~~ └─┴┤   │TOWN  │    ┌───┬┐*│");
                TextColour("map", "│  │     ~~   │   │      ├┬───┤   ├┘ │");
                TextColour("map", "│  │     ~~   │   ├──┬───┴┤   │   │  │");
                TextColour("map", "│GLENDALE ~~  └──▲┴──┤    ├─┬─┴───┘  │");
                TextColour("map", "│ PRISON  ~~  SCARLET└────┴─┘ASHDALE │");
                TextColour("map", "│         ~~   POINT                 │");
                TextColour("map", "└────────────────────────────────────┘\n");
                Thread.Sleep(4000);
                break;
            case "ASHDALE":
                Write("Loading Map:  ");
                Display.Loading(120);
                TextColour("cyanWriteLine", "/// YOU ARE HERE ▲");
                TextColour("map", "┌────────────────────────────────────┐");
                TextColour("map", "│~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ ***│");
                TextColour("map", "│ ~~~~~    ┌────────┐   PALM   ******│");
                TextColour("map", "│  ~~ QUAY │  ^^^^  │  BEACH   ******│");
                TextColour("map", "│  ~ SIDE  └┐  ^^ ┌─┴──┬────┬─*******│");
                TextColour("map", "│  ~   │    │     │  + │    │  ******│");
                TextColour("map", "│  ~~  └────┴┐    │HOSP│    └── *****│");
                TextColour("map", "│   ~~~      ├────┤    │    COTTLETON│");
                TextColour("map", "│     ~~     │    ├────┼─┬─   **WOODS│");
                TextColour("map", "│  ┌───────┐ ├┬───┤DOWN└─┤    *******│");
                TextColour("map", "│  │    ~~ └─┴┤   │TOWN  │    ┌───┬┐*│");
                TextColour("map", "│  │     ~~   │   │      ├┬───┤   ├┘ │");
                TextColour("map", "│  │     ~~   │   ├──┬───┴┤   │   │  │");
                TextColour("map", "│GLENDALE ~~  └───┴──┤    ├─┬─┴───┘▲ │");
                TextColour("map", "│ PRISON  ~~  SCARLET└────┴─┘ASHDALE │");
                TextColour("map", "│         ~~   POINT                 │");
                TextColour("map", "└────────────────────────────────────┘\n");
                Thread.Sleep(4000);
                break;
            case "COTTLETON WOODS":
                Write("Loading Map:  ");
                Display.Loading(120);
                TextColour("cyanWriteLine", "/// YOU ARE HERE ▲");
                TextColour("map", "┌────────────────────────────────────┐");
                TextColour("map", "│~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ ***│");
                TextColour("map", "│ ~~~~~    ┌────────┐   PALM   ******│");
                TextColour("map", "│  ~~ QUAY │  ^^^^  │  BEACH   ******│");
                TextColour("map", "│  ~ SIDE  └┐  ^^ ┌─┴──┬────┬─*******│");
                TextColour("map", "│  ~   │    │     │  + │    │ ▲ *****│");
                TextColour("map", "│  ~~  └────┴┐    │HOSP│    └── *****│");
                TextColour("map", "│   ~~~      ├────┤    │    COTTLETON│");
                TextColour("map", "│     ~~     │    ├────┼─┬─   **WOODS│");
                TextColour("map", "│  ┌───────┐ ├┬───┤DOWN└─┤    *******│");
                TextColour("map", "│  │    ~~ └─┴┤   │TOWN  │    ┌───┬┐*│");
                TextColour("map", "│  │     ~~   │   │      ├┬───┤   ├┘ │");
                TextColour("map", "│  │     ~~   │   ├──┬───┴┤   │   │  │");
                TextColour("map", "│GLENDALE ~~  └───┴──┤    ├─┬─┴───┘  │");
                TextColour("map", "│ PRISON  ~~  SCARLET└────┴─┘ASHDALE │");
                TextColour("map", "│         ~~   POINT                 │");
                TextColour("map", "└────────────────────────────────────┘\n");
                Thread.Sleep(4000);
                break;
            case "PALM BEACH":
                Write("Loading Map:  ");
                Display.Loading(120);
                TextColour("cyanWriteLine", "/// YOU ARE HERE ▲");
                TextColour("map", "┌────────────────────────────────────┐");
                TextColour("map", "│~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ ***│");
                TextColour("map", "│ ~~~~~    ┌────────┐   PALM   ******│");
                TextColour("map", "│  ~~ QUAY │  ^^^^  │ ▲ BEACH  ******│");
                TextColour("map", "│  ~ SIDE  └┐  ^^ ┌─┴──┬────┬─*******│");
                TextColour("map", "│  ~   │    │     │  + │    │  ******│");
                TextColour("map", "│  ~~  └────┴┐    │HOSP│    └── *****│");
                TextColour("map", "│   ~~~      ├────┤    │    COTTLETON│");
                TextColour("map", "│     ~~     │    ├────┼─┬─   **WOODS│");
                TextColour("map", "│  ┌───────┐ ├┬───┤DOWN└─┤    *******│");
                TextColour("map", "│  │    ~~ └─┴┤   │TOWN  │    ┌───┬┐*│");
                TextColour("map", "│  │     ~~   │   │      ├┬───┤   ├┘ │");
                TextColour("map", "│  │     ~~   │   ├──┬───┴┤   │   │  │");
                TextColour("map", "│GLENDALE ~~  └───┴──┤    ├─┬─┴───┘  │");
                TextColour("map", "│ PRISON  ~~  SCARLET└────┴─┘ASHDALE │");
                TextColour("map", "│         ~~   POINT                 │");
                TextColour("map", "└────────────────────────────────────┘\n");
                Thread.Sleep(4000);
                break;
        }
    }

    public static void DisplayCard(int num)
    {
        switch (num)
        {
            case 1:
            TextColour("cards", " _____ ");
            TextColour("cards", "|A .  |");
            TextColour("cards", @"| / \ |");
            TextColour("cards", @"| \ / |");
            TextColour("cards", "|  .  |");
            TextColour("cards", "|____A|\n");
            Thread.Sleep(1000);
            break;
        case 2:
            TextColour("cards", " _____ ");
            TextColour("cards", "|2 .  |");
            TextColour("cards", @"| / \ |");
            TextColour("cards", @"| \ / |");
            TextColour("cards", "|  .  |");
            TextColour("cards", "|____2|\n");
            Thread.Sleep(1000);
            break;
        case 3:
            TextColour("cards", " _____ ");
            TextColour("cards", "|3 .  |");
            TextColour("cards", @"| / \ |");
            TextColour("cards", @"| \ / |");
            TextColour("cards", "|  .  |");
            TextColour("cards", "|____3|\n");
            Thread.Sleep(1000);
            break;
        case 4:
            TextColour("cards", " _____ ");
            TextColour("cards", "|4 .  |");
            TextColour("cards", @"| / \ |");
            TextColour("cards", @"| \ / |");
            TextColour("cards", "|  .  |");
            TextColour("cards", "|____4|\n");
            Thread.Sleep(1000);
            break;
        case 5:
            TextColour("cards", " _____ ");
            TextColour("cards", "|5 .  |");
            TextColour("cards", @"| / \ |");
            TextColour("cards", @"| \ / |");
            TextColour("cards", "|  .  |");
            TextColour("cards", "|____5|\n");
            Thread.Sleep(1000);
            break;
        case 6:
            TextColour("cards", " _____ ");
            TextColour("cards", "|6 .  |");
            TextColour("cards", @"| / \ |");
            TextColour("cards", @"| \ / |");
            TextColour("cards", "|  .  |");
            TextColour("cards", "|____6|\n");
            Thread.Sleep(1000);
            break;
        case 7:
            TextColour("cards", " _____ ");
            TextColour("cards", "|7 .  |");
            TextColour("cards", @"| / \ |");
            TextColour("cards", @"| \ / |");
            TextColour("cards", "|  .  |");
            TextColour("cards", "|____7|\n");
            Thread.Sleep(1000);
            break;
        case 8:
            TextColour("cards", " _____ ");
            TextColour("cards", "|8 .  |");
            TextColour("cards", @"| / \ |");
            TextColour("cards", @"| \ / |");
            TextColour("cards", "|  .  |");
            TextColour("cards", "|____8|\n");
            Thread.Sleep(1000);
            break;
        case 9:
            TextColour("cards", " _____ ");
            TextColour("cards", "|9 .  |");
            TextColour("cards", @"| / \ |");
            TextColour("cards", @"| \ / |");
            TextColour("cards", "|  .  |");
            TextColour("cards", "|____9|\n");
            Thread.Sleep(1000);
            break;
        case 10:
            TextColour("cards", " _____ ");
            TextColour("cards", "|10 . |");
            TextColour("cards", @"| / \ |");
            TextColour("cards", @"| \ / |");
            TextColour("cards", "|  .  |");
            TextColour("cards", "|___10|\n");
            Thread.Sleep(1000);
            break;
        case 11:
            TextColour("cards", " _____ ");
            TextColour("cards", "|J .  |");
            TextColour("cards", @"| / \ |");
            TextColour("cards", @"| \ / |");
            TextColour("cards", "|  .  |");
            TextColour("cards", "|____J|\n");
            Thread.Sleep(1000);
            break;
        case 12:
            TextColour("cards", " _____ ");
            TextColour("cards", "|Q .  |");
            TextColour("cards", @"| / \ |");
            TextColour("cards", @"| \ / |");
            TextColour("cards", "|  .  |");
            TextColour("cards", "|____Q|\n");
            Thread.Sleep(1000);
            break;
        case 13:
            TextColour("cards", " _____ ");
            TextColour("cards", "|K .  |");
            TextColour("cards", @"| / \ |");
            TextColour("cards", @"| \ / |");
            TextColour("cards", "|  .  |");
            TextColour("cards", "|____K|\n");
            Thread.Sleep(1000);
            break;
        default:
                //for debugging only
                WriteLine("INVALID CARD.");
                break;
        }
    }

    //DISPLAY LOADING TIMER
    //500 CAB, 400 MISSION, 250 SHORT/STATS/INVENTORY
    public static void Loading(int ms)
    {
        for (int i = 0; i < 21; i++)
        {
            Thread.Sleep(ms);
            TextColour("cyanWrite", "||");
        }
        TextColour("cyanWriteLine", "|| \n");
        Thread.Sleep(500);
    }

    //MODIFY TEXT COLOURS
    /* OPTIONS BELOW:
    Black
    DarkBlue
    DarkGreen
    DarkCyan
    DarkRed
    DarkMagenta
    DarkYellow
    Gray
    DarkGray
    Blue
    Green
    Cyan
    Red
    Magenta
    Yellow
    White
    */

    public static void TextColour(string colour, string text)
    {
        switch (colour)
        {
            case "cyanWriteLine":
                ForegroundColor = ConsoleColor.Cyan;
                WriteLine(text);
                ResetColor();
                break;

            case "cyanWrite":
                ForegroundColor = ConsoleColor.Cyan;
                Write(text);
                ResetColor();
                break;

            case "yellow >>":
                ForegroundColor = ConsoleColor.DarkYellow;
                Write(text);
                ResetColor();
                break;

            case "stats":
                ForegroundColor = ConsoleColor.DarkYellow;
                WriteLine(text);
                ResetColor();
                break;

            case "narratorWriteLine":
                ForegroundColor = ConsoleColor.DarkGreen;
                WriteLine(text);
                ResetColor();
                break;

            case "narratorWrite":
                ForegroundColor = ConsoleColor.DarkGreen;
                Write(text);
                ResetColor();
                break;

            case "tony":
                ForegroundColor = ConsoleColor.DarkRed;
                WriteLine(text);
                ResetColor();
                break;

            case "map":
                ForegroundColor = ConsoleColor.Cyan;
                WriteLine(text);
                ResetColor();
                break;

            case "cab":
                ForegroundColor = ConsoleColor.DarkMagenta;
                WriteLine(text);
                ResetColor();
                break;

            case "cards":
                ForegroundColor = ConsoleColor.DarkBlue;
                WriteLine(text);
                ResetColor();
                break;

            case "cards-stats":
                ForegroundColor = ConsoleColor.DarkMagenta;
                WriteLine(text);
                ResetColor();
                break;

            default:
                //for debugging only
                WriteLine("INVALID COLOUR.");
                break;
        }

    }
}

