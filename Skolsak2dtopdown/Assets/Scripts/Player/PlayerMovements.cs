using UnityEngine;
using UnityEngine.InputSystem;

public class NewBehaviourScript : MonoBehaviour
{
    Vector2 moveInput;
    Vector2 screenBoundery;
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
        
            rigidBody.velocity = moveInput * moveSpeed; 
            Quaternion targetRotation = Quaternion.LookRotation(transform.forward, moveInput);
            Quaternion rotate = Quaternion.RotateTowards(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);
        
            rigidBody.MoveRotation(rotate);
       screenBoundery = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height));
       transform.position = new Vector2(Mathf.Clamp(transform.position.x, -screenBoundery.x, screenBoundery.x), Mathf.Clamp(transform.position.y, -screenBoundery.y, screenBoundery.y));
    }
}
