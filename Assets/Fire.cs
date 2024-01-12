using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    [SerializeField] private GameObject bullet;
    [SerializeField] private Transform SpawnPoint;
    [SerializeField] private float bulletSpeed = 10f;

    public void FireBullet()
    
    {
       GameObject spawnBullet = Instantiate(bullet, SpawnPoint.position, SpawnPoint.rotation);
        spawnBullet.GetComponent<Rigidbody>().velocity = SpawnPoint.forward * bulletSpeed;
        Destroy(spawnBullet, 5f);

    }

}
 
