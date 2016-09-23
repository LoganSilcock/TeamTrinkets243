using UnityEngine;

public class Platformer2DUserControl2 : MonoBehaviour
{
    private PlatformerCharacter2D2 character;
    private bool jump2;

    private void Awake()
    {
        character = GetComponent<PlatformerCharacter2D2>();
    }

    private void Update()
    {
        if (!jump2)
			// Read the jump input in Update so button presses aren't missed.
			jump2 = Input.GetKeyDown(KeyCode.Space); //CrossPlatformInputManager.GetButtonDown("Jump");
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
        character.Move(h, jump2);
        jump2 = false;
    }
}