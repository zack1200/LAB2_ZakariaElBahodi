using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GestionInstructions : MonoBehaviour
{
    [SerializeField] public GameObject Inst;
    /* [SerializeField] private GameObject _Instruction = default;
     bool _InstActive ;

     private void GestionInst()
     {
         if (Input.GetKeyDown(KeyCode.Escape) && !_InstActive)
         {
             _Instruction.SetActive(true);

             _InstActive = true;
         }
         else if (Input.GetKeyDown(KeyCode.Escape) && _InstActive)
         {
             EnleverInst();
         }
     }
     public void EnleverInst()
     {
         _Instruction.SetActive(false);

         _InstActive = false;
     }*/
    public void Instruction()
    {
        Inst.SetActive(true);
        
    }
    public void FinInstruction()
    {
        Inst.SetActive(false);
    }
}
