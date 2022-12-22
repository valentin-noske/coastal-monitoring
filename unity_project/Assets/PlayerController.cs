using UnityEngine;
 
public class PlayerController : MonoBehaviour
{
    CharacterController characterController;
 
    private void Start()
    {
        
        characterController = GetComponent<CharacterController>();
    }
 
    void Update()
    {
        // player movement - forward, backward, left, right
        float MovementSpeed = 10;
        float horizontal = Input.GetAxis("Horizontal") * MovementSpeed;
        float vertical = Input.GetAxis("Vertical") * MovementSpeed;
        characterController.Move((Vector3.right * horizontal + Vector3.forward * vertical) * Time.deltaTime);
    }
}