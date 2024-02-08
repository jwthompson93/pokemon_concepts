namespace Pokemon.SupportingObjects.Struct
{
    public struct Stats
    {
        public int Hp { get; set; }
        public int Atk { get; set; }
        public int Def { get; set; }
        public int Spatk { get; set; }
        public int Spdef { get; set; }
        public int Spd { get; set; }

        public Stats(int hp, int atk, int def, int spatk, int spdef, int spd)
        {
            Hp = hp;
            Atk = atk;
            Def = def;
            Spatk = spatk;
            Spdef = spdef;
            Spd = spd;
        }

        public string PrintStats()
        {
            return
                $"HP\t{Hp}\t" +
                $"Attack\t{Atk}\t" +
                $"Defence\t{Def}\t" +
                $"Special Attack\t{Spatk}\t" +
                $"Special Defence\t{Spdef}\t" +
                $"Speed\t{Spd}\t";
        }
    }
}
