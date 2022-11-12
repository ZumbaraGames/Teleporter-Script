using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporter : MonoBehaviour
{
	public GameObject Player;
	public GameObject ToRoomOne;
	public GameObject ToRoomTwo;

	public AudioSource TeleportSound;

    private void OnTriggerEnter(Collider collison)
    {
    	if(collison.gameObject.CompareTag("RoomOne"))
    	{
    		Player.transform.position = ToRoomOne.transform.position;
    		TeleportSound.Play();
    	}

    	if(collison.gameObject.CompareTag("RoomTwo"))
    	{
    		Player.transform.position = ToRoomTwo.transform.position;
    		TeleportSound.Play();
    	}
    }
}
