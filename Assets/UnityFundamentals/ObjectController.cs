using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectController : MonoBehaviour
{
    [SerializeField] Object _object;

    [SerializeField] GameObject _gameObject;

    [SerializeField] Light _light;

    private void Start()
    {
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            _light.intensity = 10;

        }
    }
}
