using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movemment : MonoBehaviour
{
    [SerializeField]
    private Rigidbody2D rig;

    [SerializeField]
    private float velMovimento;

   
    void Start()
    {
        
    }

    
    void Update()
    {
       Move(); 
    }


    public void Move() {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        Vector2 direcao = new Vector2(horizontal, vertical);
        direcao = direcao.normalized;
        this.rig.velocity = direcao * this.velMovimento;
    }
}
