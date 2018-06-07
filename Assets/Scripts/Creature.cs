using UnityEngine;

public enum Type { Fire, Water, Grass, Electric, Fairy, Dragon, Flying, Rock, Steel, Normal, Ground, Fighting }
public enum Moves { }
public enum Gender { Male, Female }

[CreateAssetMenu]
public class Creature : ScriptableObject
{
    public int LVL;

    public float HP;
    public float EXP;
    public float Attack;
    public float Speed;
    public float Defence;

    public Type type;
    public Gender gender;

    public bool inEffective;
    public bool notVeryEffective;
    public bool superEffective;
    public bool criticalHit;
    public bool wild;
}