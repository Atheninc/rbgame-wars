using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour {

	public float speed;
	private float X;
	private float Y;
	private float t;
	private Rigidbody2D rb;
	void Start () {
		rb =GetComponent<Rigidbody2D>();
	}
	

	void Update () {
		t = Time.deltaTime;
		X = Input.GetAxis("Horizontal");
		rb.velocity = new Vector2(X * speed, 0.0f);

	}
}
