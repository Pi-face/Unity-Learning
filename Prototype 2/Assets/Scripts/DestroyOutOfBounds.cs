using UnityEngine;

public class Destroy : MonoBehaviour
{
    private float topBound = 30f;

    void Update()
    {
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }   
    }
}
