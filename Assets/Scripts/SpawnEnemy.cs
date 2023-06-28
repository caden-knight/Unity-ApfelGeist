using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    [SerializeField]
    private GameObject hungryGhost;
    private Coroutine spawnEnemy;
    // Start is called before the first frame update
    void Start()
    {
        spawnEnemy = StartCoroutine(EnemySpawner());
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator EnemySpawner()
    {
        while (true)
        {
            yield return new WaitForSeconds(2);
            print("ayo");
            System.Random rand = new System.Random();
            Vector2 location = new Vector2(rand.Next(0, 10), 6);
            print(location);
            Instantiate(hungryGhost, location, Quaternion.identity);
        }
    }
}
