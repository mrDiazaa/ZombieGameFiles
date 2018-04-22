using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : MonoBehaviour {
	public ZombieManager manager;
	public string ID;
	public int size;


	public void Awake(){
		manager = GameObject.Find ("Manager").GetComponent<ZombieManager>();

	}
	public void onMouseDown () {
		Application.LoadLevel (1);
	}

	IEnumerator SpawnZombie(){
		yield return new WaitForSeconds (1);
		Instantiate (Resources.Load (ID + "Standing"), this.transform.position, this.transform.rotation);
	}

}
