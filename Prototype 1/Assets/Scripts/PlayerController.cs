using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 20;

    void Update()
    {
       // we'll move the vehicle forward. 
       transform.Translate(Vector3.forward * (speed * Time.deltaTime));

    }
}
