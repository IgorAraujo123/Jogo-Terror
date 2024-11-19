using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using TMPro;
using Unity.Collections;
using Unity.VisualScripting;
using UnityEditor;
using UnityEditor.Search;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class Moviment : MonoBehaviour
{
    [SerializeField]
    private Animator anim;
    [SerializeField]
    private float velocity;
  

    // Update is called once per frame
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
