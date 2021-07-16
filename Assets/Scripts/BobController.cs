using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BobController : MonoBehaviour
{

    private Vector2 targetPos;
    public float y—hange;
    public float minPos;
    public float maxPos;
    public float speed;
    public int health;
    private bool isMoving = true;
    public GameObject particle;

    void Start()
    {
        
    }

    
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);
        if(transform.position.y == targetPos.y)
        {
            isMoving = true;
        }

        if (Input.GetKeyDown(KeyCode.UpArrow) && transform.position.y < maxPos && isMoving) 
        {
            isMoving = false;
            targetPos = new Vector2(transform.position.x, transform.position.y + y—hange);
        
        }

        else if (Input.GetKeyDown(KeyCode.DownArrow) && transform.position.y > minPos && isMoving)
        {
            isMoving = false;
            targetPos = new Vector2(transform.position.x, transform.position.y - y—hange);

        }

        if(health <= 0)
        {
            Instantiate(particle, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
