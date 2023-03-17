using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GestionFin : MonoBehaviour
{
    private GestionJeu _gestionJeu;
    private Player player;
    private void Start()
    {
        _gestionJeu = FindObjectOfType<GestionJeu>();
        player = FindObjectOfType<Player>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        int indexScene = SceneManager.GetActiveScene().buildIndex;
        if (indexScene == 2)
        {
            if (collision.gameObject.tag == "Player")
            {
                int erreurs = _gestionJeu.Pointage();
                gameObject.GetComponent<MeshRenderer>().material.color = Color.white;
                Debug.Log("Le temps total est de : " + Time.time + "secondes");
                Debug.Log("vous avez accroche " + _gestionJeu.Pointage() + "obstacles");
                float total = Time.time + erreurs;
                Debug.Log("temps final : " + total);
                player.FinPartie();
            }
        }
        else
        {
            //charger la nouvelle scene 

            SceneManager.LoadScene(indexScene + 1);
        }

    }
}
