using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour {

	private Rigidbody2D rbody;

	public float horizontalForce = 10f;
	public float verticalForce = 10f;
	public float jumpForceLeft = 3f;
	public float maxJumpForce = 2f;

	public float distToGround = 1f;
	public LayerMask ground;

	void Start () 
	{
		rbody = GetComponent<Rigidbody2D> ();
	}

	void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.gameObject.layer == 9)
		{
			SceneManager.LoadScene (2);
		}
	}

	void Update () 
	{
		CheckGrounded ();
	}

	void MoveLeft()
	{
		print ("movin left");
		rbody.AddForce (Vector2.left * horizontalForce * Time.deltaTime);
	}

	void MoveRight()
	{
		print ("movin right");
		rbody.AddForce (Vector2.right * horizontalForce * Time.deltaTime);

	}

	void MoveUp()
	{
		print ("Jumping");
		if (jumpForceLeft > 0)
		{
			jumpForceLeft -= verticalForce;
			rbody.AddForce (Vector2.up * verticalForce * Time.deltaTime, ForceMode2D.Impulse);
		}
	}

	bool CheckGrounded()
	{
		bool grounded = Physics2D.OverlapArea(new Vector2(transform.position.x - .3f, transform.position.y + .1f), new Vector2(transform.position.x + .3f, transform.position.y - distToGround), ground); 

		if (grounded)
		{
			jumpForceLeft = maxJumpForce;
		}

		print (grounded);
		return grounded;
	}

	void MoveDown()
	{

	}
}
