using UnityEngine;

[CreateAssetMenu]
public class FireType : ScriptableObject, ICreature
{
    /// <summary>
    /// these are creating the variables for this type
    /// </summary>
    public float m_HP;
    public float m_EXP;
    public float m_Attck;
    public float m_Speed;
    public float m_Defence;

    public Type m_type;
    public Gender m_gender;

    public bool m_inEffective;
    public bool m_notVeryEffective;
    public bool m_superEffective;
    public bool m_criticalHit;
    public bool m_wild;


    /// <summary>
    /// this is so the creature gets the variables
    /// </summary>
    public float HP { get { return m_HP; } set { m_HP = value; } }
    public float EXP { get { return m_EXP; } set { m_EXP = value; } }
    public float Attack { get { return m_Attck; } set { m_Attck = value; } }
    public float Speed { get { return m_Speed; } set { m_Speed = value; } }
    public float Defence { get { return m_Defence; } set { m_Defence = value; } }

    public Type type { get { return m_type; } set { m_type = value; } }
    public Gender gender { get { return m_gender; } set { m_gender = value; } }

    public bool inEffective { get { return m_inEffective; } set { m_inEffective = value; } }
    public bool notVeryEffective { get { return m_notVeryEffective} set { m_notVeryEffective = value; } }
    public bool superEffective { get { return m_superEffective; } set { m_superEffective = value; } }
    public bool criticalHit { get { return m_criticalHit; } set { m_criticalHit = value; } }
    public bool wild { get { return m_wild; } set { m_wild = value; } }

    void Start()
    {
        m_type = Type.Fire;
    }
}