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

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Obstacle"))
        {
            //collision.GetComponent<PlayerMovement>().CheckInteract();
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {

    }
}
