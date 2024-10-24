using UnityEngine;
using UnityEngine.InputSystem;

public class NewBehaviourScript : MonoBehaviour
{
    Vector2 moveInput;
    Rigidbody2D rigidBody;
    [SerializeField] float moveSpeed = 5f;
    [SerializeField] float rotationSpeed = 5f;
    // Start is called before the first frame update
    void Start()
    {
       rigidBody = GetComponent<Rigidbody2D>(); 
    }

    void OnMove(InputValue value){
    
        moveInput = value.Get<Vector2>();
    }



    // Update is called once per frame
    void Update()
    {
        if (moveInput != Vector2.zero){
            rigidBody.velocity = moveInput * moveSpeed; 
            Quaternion targetRotation = Quaternion.LookRotation(transform.forward, moveInput);
            Quaternion rotate = Quaternion.RotateTowards(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);
        
            rigidBody.MoveRotation(rotate);
        }
    }
}
