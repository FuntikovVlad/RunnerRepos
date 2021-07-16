using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeSPawn : MonoBehaviour
{
    public GameObject[] lives;

    private double TimeBtwSpawn;
    public double startTimeBtwSpawnLife;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (TimeBtwSpawn <= 0)
        {
            int rand = Random.Range(0, lives.Length);
            Instantiate(lives[rand], transform.position, Quaternion.identity);


            if (startTimeBtwSpawnLife >= 0.5)
            {
                startTimeBtwSpawnLife -= 0.05;
            }



            TimeBtwSpawn = startTimeBtwSpawnLife;
        }
        else
        {
            TimeBtwSpawn -= Time.deltaTime;
        }
    }
}