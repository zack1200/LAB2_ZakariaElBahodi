using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GestionJeu : MonoBehaviour
{
    private int _pointage;
    private void Awake()
    {
        int nbGestionJeu = FindObjectsOfType<GestionJeu>().Length;
        if (nbGestionJeu > 1)
        {
            Destroy(gameObject);
        }
    }
    private void Start()
    {
        _pointage = 0;
        Instruction();
    }

    private static void Instruction()
    {
        Debug.Log("course a obstacle V1");
        Debug.Log("atteindre la fin rapidement");
        Debug.Log("Eviter les obstacles");
    }
    //Methode 
    public void AugmenterPointage()
    {
        _pointage++;
        Debug.Log("Accrochages : " + _pointage);
    }
    public int Pointage()
    {
        return _pointage;
    }
    public void Gameover()
    {
        Debug.Log("GameOver !" + Time.time);
    }
}
