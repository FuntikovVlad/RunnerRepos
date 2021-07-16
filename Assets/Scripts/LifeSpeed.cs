using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeSpeed : MonoBehaviour
{
    public int life = 1;
    public float speed;
  
    void Start()
    {

    }


    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            other.GetComponent<BobController>().health += life;
           
            Destroy(gameObject);
        }
    }
}