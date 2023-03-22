using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GestionFin : MonoBehaviour
{
    private GestionJeu _gestionJeu;
    private Player player;
    float tottime;



    private void Start()
    {
        _gestionJeu = FindObjectOfType<GestionJeu>();
        player = FindObjectOfType<Player>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        int indexScene = SceneManager.GetActiveScene().buildIndex;
        if (collision.gameObject.tag == "Player")
        {
            if (indexScene == 2)
            {
                
                    /* int erreurs = _gestionJeu.Pointage();
                     gameObject.GetComponent<MeshRenderer>().material.color = Color.white;
                     Debug.Log("Le temps total est de : " + Time.time + "secondes");
                     Debug.Log("vous avez accroche " + _gestionJeu.Pointage() + "obstacles");
                     float total = Time.time + erreurs;
                     Debug.Log("temps final : " + total);
                     player.FinPartie();*/
                    _gestionJeu.tps3(Time.time);
                    tottime= Time.time;
                    Debug.Log("temps lvl1 : " + _gestionJeu.temps1() + " temps lvl2 :" + _gestionJeu.temps2() + " temps lvl3 :" + _gestionJeu.temps3() + "temps finale" + tottime);
                    Debug.Log("accrochages lvl1 : " + _gestionJeu.pt1() + " accrochages lvl2 :" + _gestionJeu.pt2() + " accrochages lvl3 :" + _gestionJeu.pt3() + "temps finale" + tottime);

                player.FinPartie();
                
            }
            else
            {
                //charger la nouvelle scene 
                if (indexScene == 0)
                {
                        _gestionJeu.tps(Time.time);
                       

                }
                if (indexScene == 1)
                {
                        _gestionJeu.tps2(Time.time);


                }
                SceneManager.LoadScene(indexScene + 1);
            }
        }

    }
}
