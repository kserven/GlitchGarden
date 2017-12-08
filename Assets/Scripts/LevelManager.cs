using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

    public float autoLoadNextLevelAfter;

    private void Start()
    {
        Invoke("LoadNextLevel", autoLoadNextLevelAfter);
    }

    public void LoadLevel(string name){
		Debug.Log ("New Level load: " + name);
		SceneManager.LoadScene(name);
	}

    public void LoadNextLevel()
    {
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.buildIndex + 1);
    }

    public void QuitRequest(){
		Debug.Log ("Quit requested");
		Application.Quit ();
	}

}
