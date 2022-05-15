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

            default:
                //for debugging only
                WriteLine("INVALID COLOUR.");
                break;
        }

    }
}

