using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Script_phase_1 : MonoBehaviour {
    public Text startMenu;
    public Text highScore;
	public Text scoreCounter;
	float randomNumber;
	public Cannon Cannon1;
	public Cannon Cannon2;
	public Cannon Cannon3;
	public Cannon Cannon4;
	public bool aliveStatus = true;

    void TextTap()
    {
		Destroy(this.startMenu);
		Destroy(this.highScore);
		StartCoroutine("root");
		Debug.Log (randomNumber);
    }

	IEnumerator root()
	{
		while (aliveStatus = true) {
			Rndnum ();
			yield return new WaitForSeconds (2);
		}
	}

	void Rndnum()
	{
		randomNumber = Random.Range(1, 5);

		if (randomNumber == 1) {
			Cannon1.Fire();
		} 
		if (randomNumber == 2) {
			Cannon2.Fire();
		} 
		if (randomNumber == 3) {
			Cannon3.Fire();
		} 
		if (randomNumber == 4) {
			Cannon4.Fire();
		} 

	}

}