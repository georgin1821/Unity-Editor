using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    [SerializeField] private MonsterData _data;

    public MonsterData Data => _data;
    private void Awake()
    {
        Debug.Log("Damage: " + _data.Damage);
        Debug.Log("Name: " + _data.Name);
    }

    private void OnDrawGizmos()
    {
        
    }
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, _data.RangeOfAwareness);

        Vector3 direction = Vector3.forward;
        Gizmos.color = Color.green;
        Gizmos.DrawRay(transform.position, direction * _data.RangeOfAwareness);
    }
}
