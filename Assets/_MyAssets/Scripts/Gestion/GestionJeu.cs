using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GestionJeu : MonoBehaviour
{
   
    private int _pointage = 0;  
     
    private float[] _tempsNiveau =new float[3];
    private float[] _accrochageNiveau =new float [3] ;  
   
    
   

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
        InstructionsDepart();  
    }

    
    private static void InstructionsDepart()
    {
        Debug.Log("*** Course à obstacles");
        Debug.Log("Le but du jeu est d'atteindre la zone d'arrivée le plus rapidement possible");
        Debug.Log("Chaque contact avec un obstable entraînera une pénalité");
        Debug.Log("");
    }

    

    public void AugmenterPointage()
    {
        _pointage++;
    }

  
    public int GetPointage()
    {
        return _pointage;
    }

   
    public float GetTempsNiv(int index)
    {
        return _tempsNiveau[index];
    }

   
    public float GetAccrochagesNiv(int index)
    {
        return _accrochageNiveau[index];
    }
   

   
    public void SetNiveau1(int index,int accrochages, float tempsNiv1)
    {
        _accrochageNiveau[index] = accrochages;
        _tempsNiveau[index] = tempsNiv1;
    }
    public void SetNiveau2(int index, int accrochages, float tempsNiv2)
    {
        _accrochageNiveau[index] = accrochages;
        _tempsNiveau[index] = tempsNiv2;
    }
    public void SetNiveau3(int index, int accrochages, float tempsNiv3)
    {
        _accrochageNiveau[index] = accrochages;
        _tempsNiveau[index] = tempsNiv3;
    }

}
