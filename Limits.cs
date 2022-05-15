namespace JordansGTAClone
{
    //Defines game limits, DO NOT modify these values !
    class Limits
    {
        //define MAX limits
        public const int MAX_WANTED_LEVEL = 5;
        public const int MAX_CREDITS = 9999;
        public const int MAX_PLAYER_HEALTH = 10;
        public const int MAX_ARMOUR_HEALTH = 10;
        public const int MAX_PLAY_CARDS_ROUNDS = 4;

        //define MIN limits
        public const int MIN_WANTED_LEVEL = 0;
        public const int MIN_CREDITS = 0;
        public const int MIN_PLAYER_HEALTH = 0;
        public const int MIN_ARMOUR_HEALTH = 0;
        //player can go to hospital if health <= 3
        public const int MIN_HOSPITAL_HEALTH = 3;

    }
}