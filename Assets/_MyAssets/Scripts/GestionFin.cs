using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GestionFin : MonoBehaviour
{
    private GestionJeu _gestionJeu;
    private Player player;
    float time;
    float time2;
    float time3;
    float tottime;


    private void Start()
    {
        _gestionJeu = FindObjectOfType<GestionJeu>();
        player = FindObjectOfType<Player>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        int indexScene = SceneManager.GetActiveScene().buildIndex;
        if (indexScene == 0)
        {
            if (collision.gameObject.tag == "Player")
            {
            time =Time.time;
            Debug.Log("Le temps du lv1 est de : " + time + "secondes");
            }
               
        }
        if (indexScene == 1)
        {
            if (collision.gameObject.tag == "Player")
            {
            time2 = Time.time;
            Debug.Log("Le temps du lv2 est de : " + time2 + "secondes");
            }
                
        }
        if (indexScene == 2)
        {
            if (collision.gameObject.tag == "Player")
            {
                /* int erreurs = _gestionJeu.Pointage();
                 gameObject.GetComponent<MeshRenderer>().material.color = Color.white;
                 Debug.Log("Le temps total est de : " + Time.time + "secondes");
                 Debug.Log("vous avez accroche " + _gestionJeu.Pointage() + "obstacles");
                 float total = Time.time + erreurs;
                 Debug.Log("temps final : " + total);
                 player.FinPartie();*/
                time3 = Time.time;
                tottime = time+time2+time3;
                Debug.Log("temps lvl1 : " + time + "" + time2 + "" + time3 +"temps finale" + tottime);
                
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
