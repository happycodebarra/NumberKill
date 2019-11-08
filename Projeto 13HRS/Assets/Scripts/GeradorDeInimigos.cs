﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeradorDeInimigos : MonoBehaviour
{
    public Transform[] spawnpoint;

    public GameObject inimigo;


    // Start is called before the first frame update
    void Start()
    {
       InvokeRepeating("randomizarSpawn", 0, 2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void randomizarSpawn()
    {
        int sorteio = Random.Range(0,spawnpoint.Length);

        GameObject instance = Instantiate(inimigo, spawnpoint[sorteio].position, Quaternion.identity);
    }
}
