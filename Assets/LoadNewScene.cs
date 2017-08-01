using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadNewScene : MonoBehaviour
{
    public void OnClick()
    {
        if (SceneManager.GetActiveScene().name.Equals("Scene1"))
            SceneManager.LoadScene("Scene2");
        else
            SceneManager.LoadScene("Scene1");
    }

}
