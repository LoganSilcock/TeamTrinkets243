using UnityEngine;
using System.Collections;

public class TitleScript : MonoBehaviour
{
    public void StartGame()
    {
        Application.LoadLevel("GameScene");
    }
}
