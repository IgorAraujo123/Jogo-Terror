using UnityEngine;

public class Chaves : MonoBehaviour
{

    private Animator anima;
    [SerializeField]
    private float velocity;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        anima = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Animacao();
    }

    private void Animacao()
    {
        Vector3 movimento = new Vector3(Input.GetAxis("rotacao"), 0f);

        anima.SetFloat("rotacao", movimento.x);
        anima.SetFloat("Speed", movimento.magnitude);

        transform.Translate(movimento * Time.deltaTime * velocity);
    }
}
