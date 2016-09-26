using UnityEngine;

public class Platformer2DUserControl : MonoBehaviour
{
    private PlatformerCharacter2D character;
    private bool jump;

    private void Awake()
    {
        character = GetComponent<PlatformerCharacter2D>();
    }

    private void Update()
    {
        if (!jump)
        // Read the jump input in Update so button presses aren't missed.
		jump = Input.GetKeyDown(KeyCode.Space); //CrossPlatformInputManager.GetButtonDown("Jump");
    }

    private void FixedUpdate()
    {
        // Read the inputs.
        float h = 0;
        if (Input.GetKey(KeyCode.D))
            h = 1;
        if (Input.GetKey(KeyCode.A))
            h = -1;
        //float h = Input.GetAxis("Horizontal"); //CrossPlatformInputManager.GetAxis("Horizontal");
        // Pass all parameters to the character control script.
        character.Move(h, jump);
        jump = false;
    }
}