using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rot : MonoBehaviour
{
    [SerializeField] private float _vitesserotationY = 0.5f;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0f, _vitesserotationY, 0f);
    }
}
