using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeScale : MonoBehaviour
{
    [SerializeField] private Vector3 _targetSize;
    [SerializeField] private float _speedChangeSize;

    private void Update()
    {           
        transform.localScale = Vector3.Lerp(transform.localScale, _targetSize, _speedChangeSize * Time.deltaTime);
    }       
}
