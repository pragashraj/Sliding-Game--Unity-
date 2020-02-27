using UnityEngine;
using UnityEngine.UI;
public class Score : MonoBehaviour {

	public Transform playerTransform;
	public Text score;

	void Start () {
		score.text="0";
	}
	
	void Update () {
		score.text=(-playerTransform.position.x).ToString("0");
	}
}
