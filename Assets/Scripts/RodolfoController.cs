using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RodolfoController : MonoBehaviour
{
    [SerializeField] public float moveSpeed;
    [SerializeField] public float jumpForce;

    private Rigidbody rb;
    private bool isGrounded;

	private void Start()
	{
		rb = GetComponent<Rigidbody>();
	}

	private void Update()
	{
		Move();
		Jump();
	}

	private void Move()
	{
		float moveRodolfo = Input.GetAxis("Horizontal");
		rb.velocity = new Vector2(moveRodolfo * moveSpeed, rb.velocity.y);
	}

	void Jump()
	{
		if (Input.GetButtonDown("Jump") && isGrounded)
		{
			rb.velocity = new Vector2(rb.velocity.x, jumpForce);
		}
	}

	private void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.CompareTag("Ground"))
		{
			isGrounded = true;
		}
	}

	private void OnCollisionExit(Collision collision)
	{
		if (collision.gameObject.CompareTag("Ground"))
		{
			isGrounded = false;
		}
	}
}
