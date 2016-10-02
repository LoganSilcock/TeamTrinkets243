using UnityEngine;
using System.Collections;

public class CamerRunnerScript : MonoBehaviour
{
    public Transform playerPos;
    public Transform cameraPos;

    private float screenUp = 0;
    private float screenUpMulti = 1.0f;

    // Update is called once per frame
    void Update()
    {
        if (playerPos.position.y > 0)
        {
            screenUpMulti = screenUpMulti + 0.005f;
            screenUp = screenUp + (0.01f * screenUpMulti);
            //screenUp = player.position.y;
        }
        if (cameraPos.position.y >= 42)
            screenUp = 42;
            
        transform.position = new Vector3(0, screenUp, -10);
    }
}
