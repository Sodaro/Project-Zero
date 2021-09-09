using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RingRotation : MonoBehaviour
{
    void Update()
    {
        transform.rotation = Quaternion.Euler(0, 0, Mathf.Sin(Time.time) * 100);
    }
}
