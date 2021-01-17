using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterManager : MonoBehaviour
{
    public GameObject[] characters;
    public List<GameObject> actorsList = new List<GameObject>();

    List<Actor> activeActors = new List<Actor>();

    [SerializeField]
    Vector3 leftActorPosition, rightActorPosition;

    // Start is called before the first frame update
    void Start()
    {
        //creating the actor instances
        for (int i = 0; i < characters.Length; i++)
        {
            GameObject newActor = Instantiate(characters[i]);
            newActor.SetActive(false);
            newActor.name = characters[i].name;
            actorsList.Add(newActor);
        }

    }

    public void PlaceActors(string LeftActorName, string RightActorName)
    {
        //activeActors.Clear();
        foreach (GameObject gO in actorsList)
        {
            if (gO.name == LeftActorName)
            {
                gO.SetActive(true);
                gO.GetComponent<Actor>().ID = 0;
                activeActors.Add(gO.GetComponent<Actor>());
                gO.transform.position = leftActorPosition;
            }

            else if (gO.name == RightActorName)
            {
                gO.SetActive(true);
                gO.GetComponent<Actor>().ID = 1;
                activeActors.Add(gO.GetComponent<Actor>());
                gO.transform.position = rightActorPosition;
            }


        }
    }

    //Emotion can only be neutral, angry, happy or sad
    public void ChangeActorEmotion(string emotion, int posID)
    {
        foreach (Actor actor in activeActors)
        {
            if (actor.gameObject.activeInHierarchy == true)
            {
                if (actor.ID == posID)
                {
                    actor.ChangeState(emotion);
                }
            }
        }
    }

}
