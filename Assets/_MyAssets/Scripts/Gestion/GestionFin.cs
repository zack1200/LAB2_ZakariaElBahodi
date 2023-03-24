using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GestionFin : MonoBehaviour
{
    

 

    private bool _finPartie = false;  
    private GestionJeu _gestionJeu; 
    private Player _player;  
    private void Start()
    {
        _gestionJeu = FindObjectOfType<GestionJeu>();  
        _player = FindObjectOfType<Player>();  
    }

   
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player" && !_finPartie)  
        {
            gameObject.GetComponent<MeshRenderer>().material.color = Color.green;  
            _finPartie = true; 
            int noScene = SceneManager.GetActiveScene().buildIndex; 

                
            if (noScene == (SceneManager.sceneCountInBuildSettings - 1))  
            {
                int accrochages = _gestionJeu.GetPointage(); 
                float tempsTotalniv1 = _gestionJeu.GetTempsNiv(0) + _gestionJeu.GetAccrochagesNiv(0);  
                float _tempsNiveau2 = Time.time - _gestionJeu.GetTempsNiv(0); 
                float _accrochagesNiveau2 = _gestionJeu.GetPointage() - _gestionJeu.GetAccrochagesNiv(0); 
                float tempsTotalniv2 = _tempsNiveau2 + _accrochagesNiveau2; 
                
                float _tempsNiveau3 = Time.time - _gestionJeu.GetTempsNiv(0) - _gestionJeu.GetTempsNiv(1); 
                float _accrochagesNiveau3 = _gestionJeu.GetPointage() - _gestionJeu.GetAccrochagesNiv(0) - _gestionJeu.GetAccrochagesNiv(1); 
                float tempsTotalniv3 = _tempsNiveau3 + _accrochagesNiveau3; 

                
                Debug.Log("Partie finie !!!!!!!");
                Debug.Log("Le temps pour le niveau 1 est de : " + _gestionJeu.GetTempsNiv(0).ToString("f2") + " secondes");
                Debug.Log("Vous avez accroché au niveau 1 : " + _gestionJeu.GetAccrochagesNiv(0) + " obstacles");
                Debug.Log("Temps total niveau 1 : " + tempsTotalniv1.ToString("f2") + " secondes");
                
                Debug.Log("Le temps pour le niveau 2 est de : " + _gestionJeu.GetTempsNiv(1).ToString("f2") + " secondes");
                Debug.Log("Vous avez accroché au niveau 2 : " + _gestionJeu.GetAccrochagesNiv(1) + " obstacles");
                Debug.Log("Temps total niveau 2 : " + tempsTotalniv2.ToString("f2") + " secondes");

                Debug.Log("Le temps pour le niveau 3 est de : " + tempsTotalniv3.ToString("f2") + " secondes");
                Debug.Log("Vous avez accroché au niveau 3 : " + 4+ " obstacles");
                Debug.Log("Temps total niveau 3 : " + tempsTotalniv3.ToString("f2") + " secondes");

                Debug.Log("Le temps total de la partie : " + (tempsTotalniv1 + tempsTotalniv2 +tempsTotalniv3).ToString("f2") + " secondes"+"\n hohoh");

                _player.FinPartie();  
            }
            else
            {
                
                _gestionJeu.SetNiveau1(noScene,_gestionJeu.GetPointage(), Time.time) ;
                _gestionJeu.SetNiveau2(noScene,_gestionJeu.GetPointage(), Time.time);
                _gestionJeu.SetNiveau3(noScene,_gestionJeu.GetPointage(), Time.time); 


                
                SceneManager.LoadScene(noScene + 1);
            }
        }
    }
}
