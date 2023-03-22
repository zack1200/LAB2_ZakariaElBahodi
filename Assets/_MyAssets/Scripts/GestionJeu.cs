using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GestionJeu : MonoBehaviour
{
    private int _pointage;
    float time;
    float time2;
    float time3;
    int point1;
    int point2;
    int point3;
    int totpts;
    

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
    public void tps(float tps)
    {
        time= tps;
        
    }
    public void tps2(float tps)
    {
        time2 = tps-time;

    }
    public void tps3(float tps)
    {
        time3 = tps - time -time2;

    }
    public void pts1( )
    {
        point1 = _pointage;

    }
    public void pts2()
    {
        point2 = _pointage - point1;

    }
    public void pts3()
    {
        point3 = _pointage - point1-point2;

    }

    public float temps1() 
    {
        return time;
    }
    public float temps2()
    {
        return time2;
    }
    public float temps3()
    {
        return time3;
    }
    public float pt1()
    {
        return point1;
    }
    public float pt2()
    {
        return point2;
    }
    public float pt3()
    {
        return point3;
    }
}
