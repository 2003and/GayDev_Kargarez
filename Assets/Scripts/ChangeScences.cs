using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScences : MonoBehaviour
{
    public void MoveToScene(int sceneID){
        SceneManager.LoadScene(sceneID);
    }
    public void Quit() {
        Application.Quit();
    }
}
