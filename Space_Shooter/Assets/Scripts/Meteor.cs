using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meteor : MonoBehaviour
{
    float speed = -0.05f;
    public int health = 5;

    void Start()
    {
    }
    void Update()
    {
        gameObject.transform.Translate(new Vector3(speed, 0, 0));
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Fire")
        {
            health--;
        }
        else if (collision.gameObject.tag == "Limit" || collision.gameObject.tag == "Player")
        {
            health = 0;
        }

    }
}
