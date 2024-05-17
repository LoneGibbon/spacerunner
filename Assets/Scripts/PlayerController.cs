using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D rb;
    private Vector2 dir;
    public float playerSpeed;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float dirY = Input.GetAxisRaw("Vertical");
        dir = new Vector2(0, dirY).normalized;
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(0, dir.y * playerSpeed);
    }
}
