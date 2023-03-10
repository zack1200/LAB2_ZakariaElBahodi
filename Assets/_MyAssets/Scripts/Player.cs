using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //attributs
    [SerializeField] private float _vitesse = 100;
    private Rigidbody _rb;
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

    private void MouvementsJoueur()
    {
        
        float positionX = Input.GetAxis("Horizontal");
        float positionZ = Input.GetAxis("Vertical");
        Vector3 direction = new Vector3(positionX, 0f, positionZ);
        
        //transform.Translate(direction * Time.deltaTime * _vitesse); teleportation 
        //pousser
        _rb.velocity = direction * Time.fixedDeltaTime * _vitesse;
    }

    public void FinPartie()
    {
        this.gameObject.SetActive(false);
    }
}
