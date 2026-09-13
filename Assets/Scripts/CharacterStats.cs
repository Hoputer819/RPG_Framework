using UnityEngine;

public class Character : MonoBehaviour
{
    //필드(체력,현재체력,마나,현재마나,방어력,마법방어력)
    [Header("기본 스탯")]
    [SerializeField] protected float hp;
    [SerializeField] protected float mp;

    [Header("방어력 스탯")]
    [SerializeField] protected float defense;
    [SerializeField] protected float magic_defense;

    protected float current_hp;
    protected float current_mp;

    //프로퍼티(체력,현재체력,마나,현재마나,방어력,마법방어력)
    public float Hp
    {
        get { return hp; }
    }
    public float Current_Hp
    {
        get { return current_hp; }
    }
    public float Mp
    {
        get { return mp; }
    }
    public float Defense
    {
        get { return defense; }
    }
    public float Magic_Defense
    {
        get { return magic_defense; }
    }

    protected virtual void Awake()
    {
        current_hp = hp;
        current_mp = mp;
    }
}
