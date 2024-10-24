using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] Transform player;
    [SerializeField] float enemySpeed = 2f;
    Rigidbody2D rigidbody;    
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(player != null) {
            Vector2 direction = (player.position - transform.position).normalized;
            rigidbody.MovePosition(rigidbody.position + direction * enemySpeed * Time.fixedDeltaTime);
        }    
    }
}
