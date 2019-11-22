using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Inimigo : MonoBehaviour
{
    public GameObject[] modelos;

    public void ativarModelo(int ID)
    {
        modelos[ID].SetActive(true);
    }
}
