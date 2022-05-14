using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiator : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform[] positions;
    public EndlessScroll[] enemies;
    public float timeToSpawn;
    public int difficult;
    private int randomDiff;
    private void Update()
    {
        if (timeToSpawn < 0)
        {
            randomDiff = Random.Range((difficult * 15) - 5, difficult * 15);
            EndlessScroll g = enemies[Random.Range(0, enemies.Length)];
            g.SetGameVelocity(new Vector3(randomDiff,0,0)); 
            Instantiate(g, positions[Random.Range(0, positions.Length)]);
            //Instantiate(enemies[Random.Range(0, enemies.Length)], positions[2]);
            timeToSpawn = 1.5f;
        }
        else 
        {
            timeToSpawn -= Time.deltaTime;
        }
    }
}
