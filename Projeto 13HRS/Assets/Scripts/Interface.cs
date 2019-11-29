using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Interface : MonoBehaviour
{
    public void iniciarGame()
    {
        SceneManager.LoadScene(1);
    }
}
