using UnityEngine;
using System.Collections;

public class lateralMove : MonoBehaviour {
    public float jumpForce;
    public float speed;
    private Rigidbody2D latMovement;
    private void Awake()
    {
        latMovement = GetComponent<Rigidbody2D>(); 
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {

        float move = Input.GetAxis("Horizontal");
        if (Mathf.Abs(move) > 0f)
        { 
            latMovement.velocity = new Vector2(latMovement.velocity.x + move * speed, latMovement.velocity.y);
        }

        
        

        if (Input.GetKeyDown(KeyCode.Space))
        {    
            latMovement.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
        }

    }
}
