using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class final_collision : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "finish_line") {
            Debug.Log("GAME OVER");
            SceneManager.LoadScene("Endgame");
            Debug.Log("GAME HAD ENDED");
            
        }
    }
}
