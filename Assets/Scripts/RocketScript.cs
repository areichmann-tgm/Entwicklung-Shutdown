using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketScript : MonoBehaviour {
	
	Rigidbody2D rb;
	Vector3 position;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D>();
		
	}
	
	// Update is called once per frame
	void Update () {
		
			
		position = transform.position;
		position.y = Mathf.Clamp (position.y,125,410);
		transform.position = position;
		
	}
	
	public void MoveUp(){
		rb.velocity = new Vector2(0,450);
	}
	
	public void MoveDown(){
		rb.velocity = new Vector2(0,-450);
	}
	public void SetVelocityZero(){
		rb.velocity = new Vector2(0,0);
	}
	
	void OnCollisionEnter2D(Collision2D col){
		if(col.gameObject.tag == "Enemy"){
			Destroy(gameObject);
	}
	}
}