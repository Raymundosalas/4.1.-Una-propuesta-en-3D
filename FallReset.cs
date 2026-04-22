using UnityEngine;
using UnityEngine.SceneManagement;

public class FallReset : MonoBehaviour
{
    void Update()
    {
        if(transform.position.y < -10)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
