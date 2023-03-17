using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rot2 : MonoBehaviour
{
    [SerializeField] private float _vitesserotationZ = 0.5f;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0f, 0f, _vitesserotationZ);
    }
}
