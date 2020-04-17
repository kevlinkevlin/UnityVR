using UnityEngine;
using UnityEngine.SceneManagement;
public class RestartGame : MonoBehaviour
{
    public void ResetGame()
    {
        GMScript.Monster_Num = 0;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
