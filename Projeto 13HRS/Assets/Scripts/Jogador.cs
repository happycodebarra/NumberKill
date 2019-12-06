using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jogador : MonoBehaviour
{
    public int vida;
    public int pontos;
    
    private void OnCollisionEnter(Collision collision)
    {
        Inimigo inimigo = collision.gameObject.GetComponent<Inimigo>();

        if (inimigo != null && inimigo.letal==true)
        {
            vida -= 1;
        }

        else if (inimigo != null && inimigo.letal==false)
        {
            pontos += 1;
        }
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            tiro();
        }
    }

    void tiro ()
    {
        RaycastHit hit;
        if ( Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out hit , 1000))
        {
            Debug.Log(hit.transform.name);

            if (hit.transform.gameObject.tag == "Inimigo")
            {
                Destroy(hit.transform.gameObject);
            }
        }
    }
}
