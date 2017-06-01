using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class AsteroidSpawnScript : MonoBehaviour {
	
	public int score = 0;
	public GameObject asteroid;
	public float maxPos = 415f;
	public float minPos = 130f;
	public float delayTimer = 1.12f;
	float timer;
	
	

	// Use this for initialization
	void Start () {
		scoreText = gameObject.GetComponent<Text>(); 
		timer = delayTimer;
		 
	}
	
	// Update is called once per frame
	void Update () {
		
		timer -= Time.deltaTime;
		
		
		if(timer <= 0){
		Vector3  asteroidPos = new Vector3(transform.position.x,Random.Range(minPos,maxPos),transform.position.z);
		Instantiate (asteroid,asteroidPos,transform.rotation);
		timer = delayTimer;
		score += 3;
		
		}
		
	}
	
}
