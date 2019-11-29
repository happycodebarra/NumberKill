using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class Inimigo : MonoBehaviour
{
    public Transform player;
    public NavMeshAgent inimigo;

    public GameObject[] modelos;
    public bool letal = false;
    public void ativarModelo(int ID)
    {
        modelos[ID].SetActive(true);
    }

    private void Update()
    {
        inimigo.SetDestination(player.position);
    }
}
