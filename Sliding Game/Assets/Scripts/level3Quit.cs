using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class level3Quit : MonoBehaviour {
	
	public GameObject completeLevelUI;

	public void OnTriggerEnter(Collider collider){
		    completeLevelUI.SetActive(true);
			 StartCoroutine(finishing());
	}

	IEnumerator finishing(){
		yield return new WaitForSeconds(3);
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
	}
}
