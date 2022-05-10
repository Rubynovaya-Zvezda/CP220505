using System;
using UnityEngine;
using UnityEngine.Serialization;

public class Player : MonoBehaviour {
    Rigidbody2D body { get; set; }
    
    // RaycastHit2D ray { get; set; }
    //[SerializeField] float hoverForce;
    //[SerializeField] float damping; 
    //[SerializeField] float hoverHeight;
    //[SerializeField] Collider2D referenceCollider;
    [SerializeField] float speed;
    [SerializeField] float agility;
    [SerializeField] float jumpForce;

    void Start() {
        Initialise();
    }

    void FixedUpdate() {
        UpdatePhysics();
    }

    void Update() {
        Jump();
    }
    
    void Initialise() {
        body = GetComponent<Rigidbody2D>();
        //ray = Physics2D.Raycast(transform.position, Vector2.down);
        UpdatePhysics();
    }

    void UpdatePhysics() {
        Move();
        // damping = transform.position.y/hoverHeight;
        //ray = Physics2D.Raycast(transform.position, Vector2.down, hoverHeight);
        //Hover();
    }

    void Move() {
        var wasd = Input.GetAxis("Horizontal");
        body.AddForce(new Vector2(wasd * speed * agility, 0), ForceMode2D.Force);
    }

    void Jump() {
        if (!Input.GetKeyDown(KeyCode.Space)) return;
        body.AddForce(new Vector2(Vector2.up.x + body.velocity.x, Vector2.up.y * jumpForce * 100), ForceMode2D.Impulse);
    }
    
    /*
    bool Airborn() {
        return ray.collider == referenceCollider;
    }
    */
    
    /*
    void Hover() {
        if (Airborn()) return;
        body.AddForce(Vector2.up * (hoverForce*damping*Time.fixedDeltaTime), ForceMode2D.Force);
    }
    */
}