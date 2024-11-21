using UnityEngine;

public class Moviment : MonoBehaviour
{
    private Animator anim;
    [SerializeField]
    private float velocity;
  
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

        transform.Translate(movimento * Time.deltaTime * velocity);
    }
    
}
