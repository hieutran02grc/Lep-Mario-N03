using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss01 : MonoBehaviour
{
    public Sprite spriteBossDie;

    private void OnCollisionEnter2D(Collision2D collision)
    {
         
        if(collision.gameObject.CompareTag("Player"))
        {
            Player player = collision.gameObject.GetComponent<Player>();
            if(collision.transform.DotTest(transform, Vector2.down))
            {
                BossDie();
            } else{
                player.Hit();
            }
        }
    }

    private void BossDie()
    {
        GetComponent<Collider2D>().enabled = false;
        GetComponent<EntityMovement>().enabled = false;
        GetComponent<SpriteRenderer>().sprite = spriteBossDie;
        Destroy(gameObject, 0.5f);
    }

    private void Hit()
    {
        GetComponent<AnimatedSprite>().enabled = false;
        GetComponent<DeathAnimation>().enabled = true;
        Destroy(gameObject, 3f);
    }

     
}
