using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bullet : MonoBehaviour
{
    ScoreManager count;

    public float speed = 1f;
    private float moveForce = 1f;
    private string ZOMBIE_TAG = "Zombieteor";


    // Start is called before the first frame update
    void Start()
    {
        count = FindObjectOfType<ScoreManager>();
    }



    // Update is called once per frame
    void Update()
    {
        UpdateMovement();
        RemoveBullet();
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
 
        if (collision.gameObject.CompareTag(ZOMBIE_TAG))
        {
            /*Destroy(collision.gameObject);*/
            /*Destroy(gameObject);*/
            count.Score+=1;
        }
    }



    void UpdateMovement()
    {
        transform.Translate(new Vector3(0f, speed, 0f) * Time.deltaTime * moveForce);

    }


    void RemoveBullet()
    {
        Vector3 pos = transform.position;
        if (pos.y > 5f)
            Destroy(gameObject);
    }
}
