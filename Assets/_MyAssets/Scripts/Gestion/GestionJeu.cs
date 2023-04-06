using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GestionJeu : MonoBehaviour
{
   
    private int _pointage = 0;  
     
    private float[] _tempsNiveau =new float[3];
    private float[] _accrochageNiveau =new float [3] ;
    [SerializeField] private TMP_Text _txtAccrochages = default;
    [SerializeField] private TMP_Text _txtTps = default;
    [SerializeField] private GameObject _menupause = default;
    private bool _enpause = false;




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

    private void Update()
    {
        _txtTps.text = "Temps :" + Time.time.ToString("f2");
        if (Input.GetKeyDown(KeyCode.Escape) && !_enpause)
        {
            _menupause.SetActive(true);
            Time.timeScale = 0;
            _enpause
                = true;
        }
        else if (Input.GetKeyDown(KeyCode.Escape) && _enpause)
        {
            _menupause.SetActive(false);
            Time.timeScale = 1.0f;
            _enpause
                = false;
        }
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
