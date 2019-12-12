using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Jogador : MonoBehaviour
{
    public int vida;
    public int pontos;

    public AudioSource caixadesom;
    public AudioClip somDoTiro;
    public AudioClip somQuandoOInimigoMorre;

    [SerializeField] Slider hpSlider;

    [SerializeField] Text scoreText;
    
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.transform.name);

        Inimigo inimigo = collision.gameObject.GetComponent<Inimigo>();

        if (inimigo != null && inimigo.letal==true)
        {
            vida -= 25;
        }

        else if (inimigo != null && inimigo.letal==false)
        {
            pontos += 100;
        }

        if (inimigo != null)
            Destroy(inimigo.gameObject);

        if (vida <= 0)
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
            tiro();
        
        hpSlider.value = vida;
        scoreText.text = pontos.ToString();
    }

    void tiro ()
    {
        RaycastHit hit;

        caixadesom.PlayOneShot(somDoTiro);

        if ( Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out hit , 1000))
        {

            if (hit.transform.gameObject.tag == "Inimigo")
            {
                Inimigo inimigo = hit.transform.gameObject.GetComponent<Inimigo>();
                
                if (inimigo.letal)
                    pontos += 100;
                else
                    pontos -= 100;

                Destroy(hit.transform.gameObject);
                caixadesom.PlayOneShot(somQuandoOInimigoMorre);
            }
        }
    }
}
