using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class position : MonoBehaviour
{
    [SerializeField]
    Transform transTarget;
    
    void Update()
    {
        transform.position = transTarget.position;
    }
}
