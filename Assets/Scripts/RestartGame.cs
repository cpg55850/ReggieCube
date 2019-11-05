using UnityEngine.SceneManagement;
using UnityEngine;

public class RestartGame : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("r") || Input.GetButtonDown("AButton"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

    }
}
