using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 20.0f;
    private float turnSpeed = 45.0f;
    private float horizontalInput;
    private float forwardInput;

    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        
       transform.Translate(Vector3.forward * (speed * Time.deltaTime * forwardInput));
       transform.Rotate(Vector3.up * (horizontalInput * turnSpeed * Time.deltaTime));
    }
}
