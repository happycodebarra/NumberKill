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

    void tiro ()
    {
        RaycastHit hit;
        if ( Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out hit ,100))
        {
            if (hit.transform.gameObject.tag == "Inimigo")
            {
                Destroy(hit.transform.gameObject);
            }
        }
    }
}
