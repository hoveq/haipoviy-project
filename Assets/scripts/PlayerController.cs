using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 2;
    private Rigidbody2D rb;
    int energy = 0;
    // Start is called before the first frame update
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void Update()
    {
        float HorizontalInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(Input.GetAxis("Horizontal") * speed, rb.velocity.y);

        //поворот спрайта персонажа

        //прыжок
        if (Input.GetKey(KeyCode.Space))
            rb.velocity = new Vector2(rb.velocity.x, speed);
    }
    //подбор "энергии"

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("energy")) 
        {
            Destroy(other.gameObject);
            energy++;
            print(energy);
        }
    }
}
