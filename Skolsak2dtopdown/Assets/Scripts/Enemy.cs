using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] float enemySpeed = 2f;
    Rigidbody2D rigidbody;    
    GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        player = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if(player != null) {
            Vector2 direction = (player.transform.position - transform.position).normalized;
            rigidbody.MovePosition(rigidbody.position + direction * enemySpeed * Time.fixedDeltaTime);
        }    
    }
}
