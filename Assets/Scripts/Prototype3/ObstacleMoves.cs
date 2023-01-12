using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMoves : MonoBehaviour
{
    public float speed = 30f;
    private FarmerController playerController;
    private float leftBound = -15f;

    void Start()
    {
        //find that player
        playerController = GameObject.Find("Player").GetComponent<FarmerController>();
            
    }
    // Update is called once per frame
    void Update()
    {
        //if player didn't hit the obs, obs still spawn
        if (playerController.gameOver == false)
        {

            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }

        if (transform.position.x < leftBound && gameObject.CompareTag("Obstacle"))
        {
            Destroy(gameObject);
        }
    }
}
