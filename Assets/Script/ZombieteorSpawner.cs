using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieteorSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject spawnZombieteor;



    void Start()
    {
        StartCoroutine(SpawnZombieteors());
    }



    IEnumerator SpawnZombieteors()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(0, 3));

            float spawnY = gameObject.transform.position.y;
            float spawnX = Random.Range
                (-7.5f,7.5f);

            Vector2 spawnPosition = new Vector2(spawnX, spawnY);
            Instantiate(spawnZombieteor, spawnPosition, Quaternion.identity);

 
        }

        /*        while (true)
        {
            yield return new WaitForSeconds(Random.Range(1, 4));

            Vector3 spawnPosition = new Vector3(spawnPointX, spawnPointY, 0);
            Instantiate(spawnZombieteor, spawnPosition, Quaternion.identity);

        }*/
    }



}
