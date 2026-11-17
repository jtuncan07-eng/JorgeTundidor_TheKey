using UnityEngine;

public class Player_Controller : MonoBehaviour
{
    public float speed = 10f;
    private CharacterController CController;
    float horizontalMove;
    float verticalMove;
    public float verticalSpeed = 1f    ;
    Game_Manager manager;
    public float gravity = -9.81f;
    public void Start()
    {
        manager = GetComponent<Game_Manager>();
        CController = GetComponent<CharacterController>();
    }
    public void Update()
    {
        horizontalMove = Input.GetAxis("Horizontal");
        verticalMove = Input.GetAxis("Vertical");
        if (CController.isGrounded == true)
        {
            verticalSpeed = 0;
            if (Input.GetKeyDown(KeyCode.Space))
            {
                verticalSpeed = 3f;
            }
        }
        verticalSpeed += gravity * Time.deltaTime;
        Vector3 direction = new Vector3(horizontalMove, verticalSpeed, verticalMove);
        CController.Move(direction * speed * Time.deltaTime);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "coin")
        {
            Debug.Log("colisiono :0");
            manager.coins++;
        }
    }
}
