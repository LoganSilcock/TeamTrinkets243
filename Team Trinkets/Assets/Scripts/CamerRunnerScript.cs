using UnityEngine;
using System.Collections;

public class CamerRunnerScript : MonoBehaviour
{
    public Transform player;

    private float screenUp = 0;

    // Update is called once per frame
    void Update()
    {
        screenUp = player.position.y;
        transform.position = new Vector3(0, screenUp, -10);
        //screenUp = screenUp + 0.01f;
    }
}
