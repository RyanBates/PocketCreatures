public enum Type { Fire, Water, Grass, Electric, Fairy, Dragon, Flying, Rock, Steel, Normal, Ground, Fighting }
public enum Gender { Male, Female }

public interface ICreature
{
    float HP { get; set; }
    float EXP { get; set; }
    float Attack { get; set; }
    float Speed { get; set; }
    float Defence { get; set; }

    Type type { get; set; }
    Gender gender { get; set; }

    bool inEffective { get; set; }
    bool notVeryEffective { get; set; }
    bool superEffective { get; set; }
    bool criticalHit { get; set; }
    bool wild { get; set; }
}