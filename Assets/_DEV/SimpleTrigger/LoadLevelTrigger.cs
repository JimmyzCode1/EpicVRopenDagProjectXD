using UnityEngine;
using UnityEngine.SceneManagement; 

public class LoadLevelTrigger : MonoBehaviour
{
    private void LoadLevel() 
    {
        Scene currentScene = SceneManager.GetActiveScene();
        int nextSceneIndex = currentScene.buildIndex + 1;

        if (nextSceneIndex < SceneManager.sceneCountInBuildSettings)
        {
            SceneManager.LoadScene(nextSceneIndex);
        }
    }

	private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<CharacterController>())
        {
          LoadLevel();
        }
    }

}
