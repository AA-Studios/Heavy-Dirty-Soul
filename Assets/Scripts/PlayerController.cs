using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerController : MonoBehaviour
{
    private Rigidbody2D player;
    private float speed = 100.0f;
    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void UpdateMovement(float horizontal, float vertical)
    {
        player.velocity = new Vector2(horizontal, vertical + Physics2D.gravity.y) * Time.deltaTime * speed;
    }
}
