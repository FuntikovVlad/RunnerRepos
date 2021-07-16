using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoinr : MonoBehaviour
{
    public GameObject spike;
    void Start()
    {
        Instantiate(spike, transform.position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
