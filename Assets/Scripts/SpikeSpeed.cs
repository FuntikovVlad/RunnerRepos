using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeSpeed : MonoBehaviour
{
    public int damage = 1;
    public float speed;
    public GameObject SpikeParticle;
    void Start()
    {
        
    }

    
    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
       if(other.CompareTag("Player"))
        {
            other.GetComponent<BobController>().health -= damage;
            Instantiate(SpikeParticle, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
