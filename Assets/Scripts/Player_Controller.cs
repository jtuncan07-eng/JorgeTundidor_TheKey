using UnityEngine;

public class Player_Controller : MonoBehaviour
{
    public float speed = 4f;
    private CharacterController CController;
    float horizontalMove;
    float verticalMove;
    Game_Manager manager;
    public void Start()
    {
        manager = GetComponent<Game_Manager>();
        CController = GetComponent<CharacterController>();
    }
    public void Update()
    {
        horizontalMove = Input.GetAxis("Horizontal");
        verticalMove = Input.GetAxis("Vertical");
        Vector3 direction = new Vector3(horizontalMove, 0, verticalMove);
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
