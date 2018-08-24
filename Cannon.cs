using UnityEngine;
using System.Collections;

public class Cannon : MonoBehaviour {
	public AudioClip sound;
	public Rigidbody prefab;
	public Transform ejectPoint;
	public float shotForce = 1f;
	
	public void Fire () {
		Rigidbody Cannon_Ball = Instantiate (prefab, ejectPoint.position, ejectPoint.rotation) as Rigidbody;
		Cannon_Ball.AddForce (ejectPoint.forward * shotForce * 6);
		AudioSource.PlayClipAtPoint(sound, transform.position, 1);
		GetComponent<Animation> ().Play ();
	}

}
