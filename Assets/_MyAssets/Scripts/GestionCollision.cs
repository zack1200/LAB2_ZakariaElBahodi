using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GestionCollision : MonoBehaviour
{
    private GestionJeu _getionJeu;
    private int touche = 0;
    private bool _toucher = false;
    private void Start()
    {
        _getionJeu = FindObjectOfType<GestionJeu>();

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (!_toucher)
            {
                Debug.Log("Toucher ********");
                touche++;
                gameObject.GetComponent<MeshRenderer>().material.color = Color.red;
                _getionJeu.AugmenterPointage();
                _toucher = true;

                


            }
        }




    }
}
