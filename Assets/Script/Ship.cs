using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship : MonoBehaviour
{
    private float moveForce = 10f;
    private float movementX;
    private float maxX = 7.5f;
    private float minX = -7.5f;

    public Transform Bullet;
    private string ENEMY_TAG = "Zombieteor";


    // Update is called once per frame
    void Update()
    {
        MoveHorizontal();
        Shoot();
    }


    void MoveHorizontal()
    {
        movementX = Input.GetAxisRaw("Horizontal");

        Vector3 pos = transform.position;
        transform.position += new Vector3(movementX, 0f, 0f) * Time.deltaTime * moveForce;


        if (pos.x > maxX)
        {
            pos.x = maxX;
            transform.position = pos;
        }
        if (pos.x < minX)
        {
            pos.x = minX;
            transform.position = pos;
        }

    }

    

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag(ENEMY_TAG))
        {
            Destroy(gameObject);

        }
    }



    void Shoot()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            Instantiate(Bullet, transform.position, transform.rotation);
    }
}
