
public enum Type { Fire, Water, Grass, Electric, Fairy, Dragon, Flying, Rock, Steel }
public enum Gender { Male, Female }

public interface Creature
{
    float HP { get; set; }
    float EXP { get; set; }
    float Attack { get; set; }
    float Speed { get; set; }
    float Defence { get; set; }

    Type type { get; set; }
    Gender gender { get; set; }

    bool inEfective { get; set; }
    bool superEfective { get; set; }
    bool criticalHit { get; set; }
}