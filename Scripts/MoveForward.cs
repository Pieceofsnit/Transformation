using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    [SerializeField] private float _speedMove;

    private void Update()
    {       
        transform.Translate(Vector3.forward * _speedMove * Time.deltaTime);
    }       
}
