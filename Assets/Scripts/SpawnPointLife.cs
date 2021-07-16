using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPointLife : MonoBehaviour
{
    public GameObject life;

    void Start()
    {
        Instantiate(life, transform.position, Quaternion.identity);


    }

    // Update is called once per frame
    void Update()
    {

    }



}