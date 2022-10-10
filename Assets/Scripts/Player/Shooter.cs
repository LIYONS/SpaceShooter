using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private float nextFireDelay;
    [SerializeField] private Transform fireTransform;

    private float timer;

    private void Start()
    {
        timer = nextFireDelay;
    }
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && Time.time>timer )
        {
            Fire();
            timer = Time.time + nextFireDelay;
        }
    }

    private void Fire()
    {
        Instantiate(bulletPrefab,fireTransform. transform.position, fireTransform. transform.rotation);
    }
}
