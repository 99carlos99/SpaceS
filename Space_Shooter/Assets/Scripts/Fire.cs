using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    public float speed;

    void Start()
    {

    }
    void Update()
    {
        gameObject.transform.Translate(new Vector3(speed, 0, 0));
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }
}
