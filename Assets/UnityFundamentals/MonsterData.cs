using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "MonsterData", menuName = "UnitData/Monster")]
public class MonsterData : ScriptableObject
{
    [Header("General Stats")]
    [SerializeField] private string _name = "...";
    [SerializeField] private MonsterType _monsterType = MonsterType.None;
    [SerializeField] [Range(0, 100)] private float _changeToDropItem = 20;
    [SerializeField] [Tooltip("Radius size where monster will see the player")] private float _rangeOfAwareness = 5f;

    [Header("Combat Stats")]
    [SerializeField] private int _damage = 1;
    [SerializeField] private int _health = 1;
    [SerializeField] int _speed = 1;

    [Header("Dialogue")]
    [SerializeField]
    [Tooltip("Speaks dialogue when entering combat")]
    [TextArea()]
    private string _battleCry = "...";


    public string Name => _name;
    public MonsterType MonsterType => _monsterType;
    public float ChangeToDropItem => _changeToDropItem;
    public float RangeOfAwareness => _rangeOfAwareness;
    public int Damage => _damage;
    public int Health => _health;
    public int Speed => _speed;
    public string Battlecry => _battleCry;

}
