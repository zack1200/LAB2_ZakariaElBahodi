using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GestionJeu : MonoBehaviour
{

    private int _pointage = 0;  
    private float _tempsFinal = 0;
    private float _tempsDepart = 0;





    private void Awake()
    {
        
        int nbGestionJeu = FindObjectsOfType<GestionJeu>().Length;
        if (nbGestionJeu > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }

    private void Start()
    {
         _tempsDepart = Time.time;
    }


    private void Update()
    {
      //  if( FindObjectOfType<Player>().Getactive() == true )
     //   {
           
     //   }
        if (SceneManager.GetActiveScene().buildIndex == 4 || SceneManager.GetActiveScene().buildIndex == 0)
        {
            Destroy(gameObject);
        }
    }

    // ***** Méthodes publiques ******

    /*
     * Méthode publique qui permet d'augmenter le pointage de 1
     */
    public void AugmenterPointage()
    {
        _pointage++;
        UIManager uiManager = FindObjectOfType<UIManager>();
        uiManager.ChangerPointage(_pointage);
    }

    // Accesseur qui retourne la valeur de l'attribut pointage
    public int GetPointage()
    {
        return _pointage;
    }

    public float GetTempsDepart()
    {
        return _tempsDepart;
    }


    public void SetTempsFinal(float p_tempFinal)
    {
        _tempsFinal = p_tempFinal - _tempsDepart;
    }

    public float GetTempsFinal()
    {
        return _tempsFinal;
    }







}
