using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Respawner : MonoBehaviour
{
    float timer;
    public GameObject enemyPreb;

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= 5f)
        {
            float ranPos = Random.Range(-6f, 6f);
            Vector3 pos = new Vector3(9, ranPos, 0);
            timer = 0;
            Instantiate(enemyPreb, pos, Quaternion.identity);
        }
    }
}
