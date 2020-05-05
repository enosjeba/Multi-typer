using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collide : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Got Hit");
    }
}
