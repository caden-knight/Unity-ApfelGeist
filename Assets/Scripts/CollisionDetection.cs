using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetection : MonoBehaviour
{
    private int score = 0;
    private int lives = 3;
    [SerializeField]
    private GameObject self;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.collider.CompareTag("Ground")) return;

        if (other.collider.CompareTag("Player"))
        {
            if (lives > 0)
            {
                lives--;
                print(lives);
                // GameObject.Destroy(self);
            }
            else
            {
                print("game over");
            }
        }
    }
}
