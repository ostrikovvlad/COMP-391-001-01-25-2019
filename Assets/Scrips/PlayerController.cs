using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float speed = 10.0f;
    public float minX;
    public float maxX;
    public float minY;
    public float maxY;

    private Rigidbody2D rBody;

    // Start is called before the first frame update
    void Start()
    {
        rBody = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        

        float horiz = Input.GetAxis("Horizontal");
        float vert = Input.GetAxis("Vertical");

        // Debug.Log("H: " + horiz + " , V: " + vert);
        Vector2 newVelocity = new Vector2(horiz, vert);

        rBody.velocity = newVelocity * speed;

        // Restrict the player from leaving the play area
        rBody.position = new Vector2(
            Mathf.Clamp(rBody.position.x, minX, maxX),
            Mathf.Clamp(rBody.position.y, minY, maxY));
        
    }
}
