using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    float speed = -0.06f;
    float timer;
    public float health = 3;
    public Transform fireP;
    public GameObject ball;

    void Start()
    {

    }

    void Update()
    {
        gameObject.transform.Translate(new Vector3(speed, 0, 0));
        timer += Time.deltaTime;
        if (timer >= 2f)
        {
            Fire();
            timer = 0;
        }
        if (health <= 0)
        {
            Destroy(gameObject);
        }


    }
    void Fire()
    {
        Instantiate(ball, fireP.position, Quaternion.identity);
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
