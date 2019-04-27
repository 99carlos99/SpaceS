using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject playerX;
    public Player player;

    public Transform fireP;
    public GameObject ball;

    void Start()
    {
        player = playerX.GetComponent<Player>();
    }

    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            Fire();
        }
    }

    void Fire()
    {
        Instantiate(ball, fireP.position, Quaternion.identity);
    }
}
