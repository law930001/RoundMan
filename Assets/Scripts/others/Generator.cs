using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour
{
    public Rigidbody2D circle;
    public Transform generator;

    void Start()
    {
        // after start begin seconds, every seconds // 1.5, 1.5
        InvokeRepeating("Spawn", 1.5F, 1.25F);
    }

    void Spawn()
    {
        if (game_control._gameLock == false)
        {
            Rigidbody2D circleInstance;
            circleInstance = Instantiate(circle, generator.position, generator.rotation) as Rigidbody2D;
            circleInstance.AddForce(new Vector2(Random.Range(-1F,1F), -1) * 150);
        }
    }
}