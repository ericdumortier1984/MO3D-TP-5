using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine;

public class EndPointLevel : MonoBehaviour
{
    public TMP_Text levelCompletedText;
    private bool levelCompleted = false;

	private void Start()
	{
		levelCompletedText.gameObject.SetActive(false);
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag("Player") && !levelCompleted) 
		{
			levelCompletedText.gameObject.SetActive(true);
			levelCompletedText.text = "LEVEL COMPLETED";
			levelCompleted = true;
		}
	}
}
