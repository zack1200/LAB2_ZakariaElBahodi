using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private TMP_Text _txtAccrochages = default;
    [SerializeField] private TMP_Text _txtTemps = default;
    [SerializeField] private GameObject _menuPause = default;
    [SerializeField] private GameObject _Inst = default;
    private bool _enPause;
    private GestionJeu _gestionJeu;


    void Start()
    {
        _gestionJeu = FindObjectOfType<GestionJeu>();
        _txtAccrochages.text = "Accrochages : " + _gestionJeu.GetPointage();
        Time.timeScale = 1;
        _enPause = false;
    }


    private void Update()
    {
        float temps = Time.time - _gestionJeu.GetTempsDepart();
        _txtTemps.text = "Temps : " + temps.ToString("f2");
        GestionPause();
    }

    private void GestionPause()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && !_enPause)
        {
            _menuPause.SetActive(true);
            Time.timeScale = 0;
            _enPause = true;
        }
        else if (Input.GetKeyDown(KeyCode.Escape) && _enPause)
        {
            EnleverPause();
        }
    }

    public void ChangerPointage(int p_pointage)
    {
        _txtAccrochages.text = "Accrochages : " + p_pointage.ToString();
    }

    public void EnleverPause()
    {
        _menuPause.SetActive(false);
        Time.timeScale = 1;
        _enPause = false;
    }
    public void Inst()
    {
        _Inst.SetActive(true);

    }
    public void Back()
    {
        _Inst.SetActive(false);
    }
}
