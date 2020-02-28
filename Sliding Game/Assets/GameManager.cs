using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

	bool gameEnded=false;
	public GameObject completeLevelUI;
	public void EndGame()
	{
		if(gameEnded==false){
			gameEnded=true;
			Debug.Log("Game end");
			Invoke("restart",3f);
		}
		
	}

	void restart(){
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}

	public void completeLevel(){
		completeLevelUI.SetActive(true);
	}


}
