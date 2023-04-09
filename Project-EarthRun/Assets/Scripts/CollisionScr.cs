using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionScr : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other) // to see when the player enters the collider
    {
        if(other.gameObject.tag == "Tree") //on the object you want to pick up set the tag to be anything, in this case "object"
        {
            //canpickup = true;  //set the pick up bool to true
            // ObjectIwantToDestroy = other.gameObject; //set the gameobject you collided with to one you can reference
            // //Destroy(ObjectIwantToDestroy);
            // ObjectIwantToDestroy.SetActive(false);
            // trashCollected += 1;
            // collectSound.SetActive(false);
            // collectSound.SetActive(true);
            // //textmeshPro = GameObject.Find ("TrashCollected").GetComponent<TextMeshPro>();
            // textmeshPro.text = trashCollected.ToString();
            GameObject.Find("TrashbinGreen").GetComponent<PlayerMovement>().enabled = false;
            //Debug.Log("HIT");
        }
    }
}
