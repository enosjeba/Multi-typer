using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordSpwaner : MonoBehaviour
{
    public GameObject wordPrefrab;
    public Transform wordCanvas;

    public WordDisplay SpawnWord ()
    {
        Vector3 randomPosition = new Vector3(Random.Range(-2.5f, 2.5f), 7f);

        GameObject wordObj = Instantiate(wordPrefrab, randomPosition, Quaternion.identity, wordCanvas);
        WordDisplay wordDisplay = wordObj.GetComponent<WordDisplay>();

        return wordDisplay;
    }
}
