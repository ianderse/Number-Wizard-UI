using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class NumberWizard : MonoBehaviour {

	public Text guessText;
	
	int max = 1000;
	int min = 1;
	int guess;
	
	// Use this for initialization
	void Start () {
		StartGame ();
	}
	
	void StartGame () {
		max += 1;
		NextGuess();
	}
	
	void NextGuess () {
		guess = Random.Range (min,max);
		guessText.text = guess.ToString();
	}
	
	public void GuessHigher() {
		min = guess;
		NextGuess();
	}
	
	public void GuessLower() {
		max = guess;
		NextGuess();
	}	
	
	public void GuessCorrect() {
		StartGame();
	}
}
