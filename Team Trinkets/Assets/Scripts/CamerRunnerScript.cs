using UnityEngine;
using System.Collections;

public class CamerRunnerScript : MonoBehaviour
{
    public Transform playerPos;
    public Transform cameraPos;

    private float screenUp = 0;

    // Update is called once per frame
    void Update()
    {
        if (playerPos.position.y > 0)
        {
            screenUp = screenUp + 0.01f;
            //screenUp = player.position.y;
        }
        if (cameraPos.position.y > 42)
            screenUp = 0;
            
        transform.position = new Vector3(0, screenUp, -10);
    }
}
