using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Inimigo : MonoBehaviour

{
    public GameObject[] modelos;
    public bool letal = false;
    public void ativarModelo(int ID)
    {
        modelos[ID].SetActive(true);
    }
}
