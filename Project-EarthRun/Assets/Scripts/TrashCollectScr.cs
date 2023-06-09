using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TrashCollectScr : MonoBehaviour
{
    public int trashCollected;
    public GameObject collectSound;
    public Text Txt;
    // public TextMeshPro textmeshPro;
    public TextMeshProUGUI textmeshPro;

    GameObject ObjectIwantToDestroy;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        

        // Txt = GameObject.Find ("TrashCollected").GetComponent<TextMeshPro> ();
        // Txt.text = TrashCollected.ToString();
    }

    private void OnTriggerEnter(Collider other) // to see when the player enters the collider
    {
        if(other.gameObject.tag == "Trash") //on the object you want to pick up set the tag to be anything, in this case "object"
        {
            //canpickup = true;  //set the pick up bool to true
            ObjectIwantToDestroy = other.gameObject; //set the gameobject you collided with to one you can reference
            //Destroy(ObjectIwantToDestroy);
            ObjectIwantToDestroy.SetActive(false);
            trashCollected += 1;
            collectSound.SetActive(false);
            collectSound.SetActive(true);
            //textmeshPro = GameObject.Find ("TrashCollected").GetComponent<TextMeshPro>();
            textmeshPro.text = trashCollected.ToString();
        }
    }
}
