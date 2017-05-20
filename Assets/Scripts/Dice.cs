using UnityEngine;
using UnityEngine.UI;

public class Dice : MonoBehaviour {

	public Text score;
	public Text highScore;

	void Start() {
		highScore.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
	}

	public void RollDice() {
		int num = Random.Range(1, 7);
		score.text = num.ToString();

		if (num > PlayerPrefs.GetInt("HighScore", 0)) {
			highScore.text = num.ToString();
			PlayerPrefs.SetInt("HighScore", num);
		}
	}

	public void Reset() {
		highScore.text = "0";
		PlayerPrefs.SetInt("HighScore", 0);
		// or PlayerPrefs.DeleteAll();
	}
}
