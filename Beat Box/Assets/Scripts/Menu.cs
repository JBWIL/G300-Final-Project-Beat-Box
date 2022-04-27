using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void StartGame ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void StartLevelOne() {
      SceneManager.LoadScene("Level 1");
    }

    public void StartLevelTwo() {
      SceneManager.LoadScene("Level 2");
    }

    public void StartLevelThree() {
      SceneManager.LoadScene("Level 3");
    }
}
