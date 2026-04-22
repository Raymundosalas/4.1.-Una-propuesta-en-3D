using UnityEngine;

public class CollisionDetect : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Colisionaste con: " + collision.gameObject.name);
    }
}
