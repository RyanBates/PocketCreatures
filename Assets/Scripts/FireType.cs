using UnityEngine;

public class FireType : MonoBehaviour, Creature
{
    private float m_HP;
    private float m_EXP;
    private float m_Attck;
    private float m_Speed;
    private float m_Defence;

    private Type m_type;
    private Gender m_gender;

    private bool m_inEfective;
    private bool m_superEfective;
    private bool m_criticalHit;

    public float HP { get { return m_HP; } set { m_HP = value; } }
    public float EXP { get { return m_EXP; } set { m_EXP = value; } }
    public float Attack { get { return m_Attck; } set { m_Attck = value; } }
    public float Speed { get { return m_Speed; } set { m_Speed = value; } }
    public float Defence { get { return m_Defence; } set { m_Defence = value; } }

    public Type type { get { return m_type; } set { m_type = value; } }
    public Gender gender { get { return m_gender; } set { m_gender = value; } }

    public bool inEfective { get { return m_inEfective; } set { m_inEfective = value; } }
    public bool superEfective { get { return m_superEfective; } set { m_superEfective = value; } }
    public bool criticalHit { get { return m_criticalHit; } set { m_criticalHit = value; } }

    private void Start()
    {
        m_type = Type.Fire;
        
        m_inEfective = false;
        m_superEfective = false;
        m_criticalHit = false;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
            DecideGender();
    }

    void DecideGender()
    {
        var getGender = new Gender();
        getGender = (Gender)Random.Range(0, 1);
        

        if (getGender == Gender.Male)
        {
            var cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
            var color = new Color(0, 0, 255);
            cube.GetComponent<Renderer>().material.color = color;
            Instantiate<GameObject>(cube, new Vector3(0,1.5f,0), gameObject.transform.rotation, gameObject.transform);
        }
        
        if (getGender == Gender.Female)
        {
            var cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
            var color = new Color(255, 192, 203);
            cube.GetComponent<Renderer>().material.color = color;
            Instantiate<GameObject>(cube, new Vector3(0, 1.5f, 0), gameObject.transform.rotation, gameObject.transform);
        }
    }

    private void Battle()
    {
        
    }
}
