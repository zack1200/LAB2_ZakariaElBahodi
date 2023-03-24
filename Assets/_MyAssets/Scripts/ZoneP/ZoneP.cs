using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoneP : MonoBehaviour
{
    //faut activer la zoneon trigger 
    private bool _active = false;
    //[SerializeField]private GameObject piege = default;
    private Rigidbody _rb;
    [SerializeField] private float intensiteFo = 500;
    [SerializeField] private List<GameObject> _listePieges = new List<GameObject>();
    private List<Rigidbody> _listeRb = new List<Rigidbody>();


    private void Start()
    {
        foreach (var piege in _listePieges)
        {
            _listeRb.Add(piege.GetComponent<Rigidbody>());


        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && !_active)
        {
            foreach (var rb in _listeRb)
            {
                rb.useGravity = true;
                rb.AddForce(Vector3.down * intensiteFo);
            }
            Debug.Log("*****activer le piege ");
            _active = true;


        }

    }
}
