using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombieteor : MonoBehaviour
{

    private AudioSource[] source;
    private AudioSource hit;
    private AudioSource eat;

    private string BULLET_TAG = "Bullet";
    private string SHIP_TAG = "Ship";

    void FixedUpdate()
    {
        DeleteZombie();
    }

    void Start()
    {
        source = GetComponents<AudioSource>();
        hit = source[0];
        eat = source[1];
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.CompareTag(BULLET_TAG))
        {

            hit.Play();
        }

        if (collision.gameObject.CompareTag(SHIP_TAG))
        {
            eat.Play();
        }
    }

    void DeleteZombie()
    {
        Vector3 pos = transform.position;
        if (pos.y < -4f)
            Destroy(gameObject);
    }







}
