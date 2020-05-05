using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{ 
    public void Normalmode()
    {
        SceneManager.LoadScene("Main");
    }
    public void Nightmaremode()
    {
        SceneManager.LoadScene("Nightmare");
    }
    public void tryagain()
    {
        Debug.Log("thisisworking");
        SceneManager.LoadScene("Menu");
    }
    public void credits()
    {
        Debug.Log("credits");
        SceneManager.LoadScene("credits");
    }
}
