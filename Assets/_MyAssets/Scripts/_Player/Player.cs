using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //attributs
    [SerializeField] private float _vitesse = 700f;
    [SerializeField] private float _vitessederotation = 100;
    private Rigidbody _rb;
    bool _active = false;
    // methode privee
    private void Start()
    {
        //position depart Player
        
        _rb = GetComponent<Rigidbody>();
    }
    private void FixedUpdate()
    {
        MouvementsJoueur();
    }


    private void Update()
    {
        MouvementsJoueur();
    }
    //public bool Getactive()
    //{
    //    return _active;
    //}

    private void MouvementsJoueur()
    {
        //if(_active == false)
        //{
        //    if (Input.GetAxis("Horizontal") > 0)
        //    {
        //        _active = true;
        //    }
        //}   
        float positionX = Input.GetAxis("Horizontal");
        float positionZ = Input.GetAxis("Vertical");
        Vector3 direction = new Vector3(positionX, 0f, positionZ);
        
        //transform.Translate(direction * Time.deltaTime * _vitesse); teleportation 
        //pousser
        _rb.velocity = direction * Time.fixedDeltaTime * _vitesse;

        if (direction.normalized != Vector3.zero)
        {
            Quaternion regardevers = Quaternion.LookRotation(direction.normalized, Vector3.up);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, regardevers, _vitessederotation * Time.fixedDeltaTime);
        }
    }

    public void FinPartie()
    {
        gameObject.SetActive(false);
    }
}
