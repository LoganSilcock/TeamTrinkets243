using UnityEngine;
using System.Collections;

public class CamerRunnerScript : MonoBehaviour
{
    public Transform player;
    public Transform player2;

    private float screenUp = 0;

    // Update is called once per frame
    void Update()
    {
        screenUp = player.position.y + (player2.position.y - player.position.y) / 2;
        transform.position = new Vector3(0, screenUp, -10);
        //screenUp = screenUp + 0.01f;
    }
}
