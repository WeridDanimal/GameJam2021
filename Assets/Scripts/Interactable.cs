using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Using
//      "How To Interact With Objects [Unity Tutorial]" - Comp-3 Interactive
// abstract -> every interactable object has this class

[RequireComponent(typeof(BoxCollider2D))]    // requires inheretance to have some form of boxcollider

public abstract class Interactable : MonoBehaviour
{
    public abstract void Interact();
    //new code by Daniel
    public TextMesh text1;
    public TextMesh text2;
    public TextMesh text3;
    public TextMesh text4;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //checks if it console outputs trigger when player is touching object
        //Debug.Log("Trigger!");
        if(collision.CompareTag("Obstacle"))
        {
            //collision.GetComponent<PlayerMovement>().CheckInteract();
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        text1.text = ("Exit");
    }
}
