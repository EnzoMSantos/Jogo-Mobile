using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animations : MonoBehaviour
{
    [SerializeField]
    private Rigidbody2D rig;

    [SerializeField]
    private SpriteRenderer spriteRenderer;

    [SerializeField]
    private Animator animator;

    // Update is called once per frame
    void LateUpdate()
    {
        
        Vector2 velocidade =  this.rig.velocity;

        if((velocidade.x != 0) || (velocidade.y != 0)) 
        {
            this.animator.SetBool("walking", true);
        }
        else
        {
            this.animator.SetBool("walking", false);
        }

        if(velocidade.x > 0) 
        { //esquerda
            this.spriteRenderer.flipX = false;
        }
        else if (velocidade.x < 0)  //direita
        {
            this.spriteRenderer.flipX = true;
        }
    }
}
    
  
