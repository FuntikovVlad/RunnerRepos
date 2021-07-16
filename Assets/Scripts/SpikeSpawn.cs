using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeSpawn : MonoBehaviour
{
    public GameObject[] spikes;
    
    private double TimeBtwSpawn;
    public double startTimeBtwSpawn;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(TimeBtwSpawn <= 0)
        {
            int rand = Random.Range(0, spikes.Length);
            Instantiate(spikes[rand], transform.position, Quaternion.identity);


            if (startTimeBtwSpawn >= 0.5)
            {
                startTimeBtwSpawn -= 0.05;
            }
            
            

            TimeBtwSpawn = startTimeBtwSpawn;
        }
        else
        {
            TimeBtwSpawn -= Time.deltaTime;
        }
    }
}
