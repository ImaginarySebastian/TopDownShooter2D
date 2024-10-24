using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerShooting : MonoBehaviour
{
    [SerializeField] float playerBulletSpeed = 10f;
    [SerializeField] GameObject playerBullet;
    [SerializeField] GameObject playerGun; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnFire()
    {
        GameObject bullet = Instantiate(playerBullet, playerGun.transform.position, transform.rotation); 
        Rigidbody2D rigidbody = bullet.GetComponent<Rigidbody2D>();
        rigidbody.AddForce(transform.up * playerBulletSpeed, ForceMode2D.Impulse);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
