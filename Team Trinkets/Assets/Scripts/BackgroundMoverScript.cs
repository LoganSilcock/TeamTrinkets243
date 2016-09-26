using UnityEngine;
using System.Collections;

public class BackgroundMoverScript : MonoBehaviour
{
    public GameObject block;
    public float speedMov = 1;

    private float posX;


    // Use this for initialization
    void Start()
    {
        posX = block.transform.position.x;
    }
	
    // Update is called once per frame
    void FixedUpdate()
    {
        block.transform.position = new Vector3(posX, transform.position.y, transform.position.z);

        posX = posX - speedMov;
    }
}
