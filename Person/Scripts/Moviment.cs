using System;
using UnityEngine;

public class Moviment : MonoBehaviour
{
    private Animator anim;
    [SerializeField] private float velocity;
    [SerializeField] private Rigidbody2D rb;
  
    void Start() {
        anim = GetComponent<Animator>();
    }   
    
    void Update()
    {
        Move();
    }

    private void Move(){
        Vector3 movimento = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0f);

        anim.SetFloat("Horizontal", movimento.x);
        anim.SetFloat("Vertical", movimento.y);
        anim.SetFloat("Speed", movimento.magnitude);

        //transform.Translate(movimento * Time.deltaTime * velocity);
        rb.linearVelocity = movimento * velocity;
    }

    private Vector2 Vector2(float x, float y)
    {
        throw new NotImplementedException();
    }
}
