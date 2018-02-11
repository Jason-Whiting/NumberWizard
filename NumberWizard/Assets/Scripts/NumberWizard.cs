using UnityEngine;
using System.Collections;

public class NumberWizard : MonoBehaviour {

	int max;
	int min;
	int guess;
	int count;
	
	// Use this for initialization
	void Start () {
		StartGame();
	}
	
	void StartGame() {
		
		max = 10000;
		min = 1;
		guess = Random.Range(min, max);
		
		// An alternate way of guessing would be to always have the
		// computer guess the median number within the given range.
		// guess = (max + min) / 2;
		
		print("======= Welcome to NumberWizard =======");
		print("Pick a number between " + min + " and " + max + ".");
		print("Is your number higher or lower than " + guess + "?");
		print("Press 'Up' for higher, 'Down' for lower, and 'Enter' for equal.");
		
		max = max + 1;
		count = 1;
		
	}
	
	// Update is called once per frame
	void Update () {
	
		if (Input.GetKeyDown(KeyCode.UpArrow)) {
			min = guess;
			NextGuess();
		} else if (Input.GetKeyDown(KeyCode.DownArrow)) {
			max = guess;
			NextGuess();
		} else if (Input.GetKeyDown(KeyCode.Return)) {
			print("I win! It took me " + count + " guess(es)!");
		}
		
	}
	
	void NextGuess() {
		
		// guess = (max + min) / 2
		guess = Random.Range(min + 1, max - 1);
		count = count + 1;
		print("Is your number higher or lower than " + guess + "?");
		print("Press 'Up' for higher, 'Down' for lower, and 'Enter' for equal.");
		
	}
	
}
