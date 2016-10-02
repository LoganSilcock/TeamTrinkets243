using UnityEngine;
using System.Collections;

public class WinnerScript : MonoBehaviour
{

    void OnTriggerEnter(GameObject other)
    {
        if (other.tag == "Player")
        {
            Application.LoadLevel("GameScene2");
        }
    }
}
