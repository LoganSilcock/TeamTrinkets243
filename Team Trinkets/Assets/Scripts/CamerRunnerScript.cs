using UnityEngine;
using System.Collections;

public class CamerRunnerScript : MonoBehaviour
{
    public Transform player;

    private float screenUp = 0;

    // Update is called once per frame
    void Update()
    {
        if (player.position.y > 0)
        {
            screenUp = screenUp + 0.01f;
            //screenUp = player.position.y;
        }
        transform.position = new Vector3(0, screenUp, -10);
    }
}
