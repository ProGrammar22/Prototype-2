using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBoundsOld : MonoBehaviour
{
    private float topBound = 30;
    private float lowerBound = -10;
    private float sideBound = 30;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // If an object goes past the player's view in game, remove that object
        if (transform.position.z > topBound || transform.position.x > sideBound || transform.position.x < -sideBound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < lowerBound)
        {
            Destroy(gameObject);
        }
    }
}
