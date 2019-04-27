using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int health = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey("left"))
        {
            transform.position += Vector3.left*Time.deltaTime* 10; 
        }

        if (Input.GetKey("right"))
        {
            transform.position += Vector3.right * Time.deltaTime * 10;
        }

        if (Input.GetKey("up"))
        {
            transform.position += Vector3.up * Time.deltaTime * 10;
        }

        if (Input.GetKey("down"))
        {
            transform.position += Vector3.down * Time.deltaTime * 10;
        }

        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Meteor")
        {
            health--;
        }
    }

}
