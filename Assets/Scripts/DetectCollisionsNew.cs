using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisionsNew : MonoBehaviour
{
    private GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        //Check if the other tag was the Player, if it was remove a life
        if (other.CompareTag("Player"))
        {
            gameManager.AddLives(-1);
        }
        //Check if the other tag was an Animal, if so add points to the score
        else if (other.CompareTag("Animal"))
        {
            other.GetComponent<AnimalHunger>().FeedAnimal(1);
            // Instead of destroying the projectile when it collides with an animal
            //Destroy(other.gameObject); 

            // Just deactivate the food and destroy the animal
            gameObject.SetActive(false);
        }
    }
}
