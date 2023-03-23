using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoneOuv : MonoBehaviour
{
    public Transform Porte;
    public float speed;
    public bool Ouverture = false;
    public bool Fermeture = false;
    public float currentValue = 0;
    public float maxOpenValue;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Ouverture) OuvrePorte();
        if (Fermeture) FermePorte();
    }



    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Ouverture = true;
            Fermeture = false;
        }
    }
    private void OnTriggerExit(Collider other)
    
    {
        if (other.gameObject.tag == "Player")
            if (Ouverture == false && Fermeture == true)
            {
                Ouverture = false;
                Fermeture = true;
                OuvrePorte();
            }
            else
            {
                FermePorte();
            }

    }





    private void OuvrePorte()
    {
        float movement = speed * Time.deltaTime;
        currentValue += movement;
        if (currentValue <= maxOpenValue)
        {
            Porte.position = new Vector3(
            Porte.position.x + movement, 0, Porte.position.z );
        }

        else
        {
            Ouverture = false;
        }
    }
       
   private void FermePorte()
    {
        float movement = speed * Time.deltaTime;
        currentValue -= movement;
        if (currentValue >= 0 )
        {
            Porte.position = new Vector3(
            Porte.position.x - movement, 0, Porte.position.z);
        }

        else
        {
            Fermeture = false;
        }
    }

    
}
