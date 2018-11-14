using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class MovePlayer : NetworkBehaviour{

	public float speed;
	public float SautForce;
	private float X;
	private float Y;
	private float t;
	public Rigidbody2D rb;
	private bool isGround;
	public Animator anim;
	public GameObject gun;
	void Start () {
	}
	

	void Update () {
		if (!isLocalPlayer)
			return;
		t = Time.deltaTime;
		X = Input.GetAxis("Horizontal");
		if (Mathf.Abs(X) > 0.2f){
			anim.Play("walk_right");
		}
		else
			anim.Play("idle");
		if (X < 0.0f)
		{
			GetComponent<SpriteRenderer>().flipX = false;
			gun.GetComponent<SpriteRenderer>().flipY = true;
		}	
		else
		{
			GetComponent<SpriteRenderer>().flipX = true;
			gun.GetComponent<SpriteRenderer>().flipY = false;
		}
		rb.transform.Translate(transform.right * speed * t * X);
		if (Input.GetButtonDown("Fire1") && isGround)
			rb.AddForce(Vector2.up * SautForce, ForceMode2D.Impulse);
	}

	void OnCollisionExit2D(Collision2D other)
	{
		isGround = false;
	}
	void OnCollisionStay2D(Collision2D other)
	{
		var gr = false;
		foreach(ContactPoint2D item in other.contacts)
		{
			var a = Mathf.Atan2(item.normal.x, item.normal.y) * 180.0f / Mathf.PI;
			if (a < 90.0f && a > -90.0f)
			{
				gr = true;
				Debug.DrawRay(item.point, item.normal * 4, Color.blue);
			}
			else
			{
				Debug.DrawRay(item.point, item.normal * 4, Color.red);
					
			}
		}
		isGround = gr;
	}
}
