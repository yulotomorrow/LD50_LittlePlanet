﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DialogueControl : MonoBehaviour
{
	[SerializeField] private Text nametag;
	[SerializeField] private Text dialog;
	[SerializeField] private GameObject iconField;
	[SerializeField] private Canvas dialogCanvas;

	[SerializeField] private Sprite[] icons;
	private string[] names = {"Aya", "Pico"};


	[SerializeField] private GameObject sphere;
	[SerializeField] private Sprite brokenSphere;

	private List<DialogInfo> dialogueList = new List<DialogInfo>();

	void Start()
	{
		dialogueList.Add(new DialogInfo("This time our adventure is a big success! We built a ecosystem on this small planet!", 1, 1, 0));
		dialogueList.Add(new DialogInfo("I really like this place. Look at all the trees and plants!", 0, 0, 0));
		dialogueList.Add(new DialogInfo("Well, our research is coming to an end here. We need to collect all the data and go.", 1, 1, 0));
		dialogueList.Add(new DialogInfo("I'm almost not willing to leave...", 0, 0, 0));
		dialogueList.Add(new DialogInfo("Let's go back to the research station and prepare for the data transmission.", 1, 1, 0));
		dialogueList.Add(new DialogInfo("It will take some time.", 1, 1, 1));
		dialogueList.Add(new DialogInfo("Okay, I'm here. Ready to send Project Little Planet ecosystem research data...", 0, 0, 2));
		dialogueList.Add(new DialogInfo("???!", 0, 0, 3));
		dialogueList.Add(new DialogInfo("Dangers! according to the starlog, this planet is affected by gravity of nearby planets", 1, 1, 0));
		dialogueList.Add(new DialogInfo("and it's heading towards a large asteroid group!", 1, 1, 0));
		dialogueList.Add(new DialogInfo("Any chance I can save the planet?", 0, 0, 0));
		dialogueList.Add(new DialogInfo("Accroding to the density and size of the asteroid group, calculating...", 1, 1, 0));
		dialogueList.Add(new DialogInfo("The chance is... Zero.", 1, 1, 0));
		dialogueList.Add(new DialogInfo("So our research is all in vain...", 0, 0, 0));
		dialogueList.Add(new DialogInfo("But maybe we can delay the complete destruction of the planet and get some time for our data transmission."
			, 1, 1, 0));
		dialogueList.Add(new DialogInfo("Once it's done, I can come with my upgraded Bubble and pick you up.", 1, 1, 0));
		dialogueList.Add(new DialogInfo("But how?!", 0, 0, 0));
		dialogueList.Add(new DialogInfo("See that *secret weapon* in your -backyard-?", 1, 1, 4));
		dialogueList.Add(new DialogInfo("Go there and time to reveal its true form!!", 1, 1, 5));
		dialogueList.Add(new DialogInfo("A CANNON?!?!", 0, 0, 0));
		dialogueList.Add(new DialogInfo("You can use it to stop the asteroids. Temporarily, but hopefully enough time for collecting the data.",
			1, 1, 0));
		dialogueList.Add(new DialogInfo("But I can't see any cannonballs for it...", 0, 0, 0));
		dialogueList.Add(new DialogInfo("Go back to your hut and get the things in the sealed box, probably it's not longer sealed now.", 1, 1, 6));
		dialogueList.Add(new DialogInfo("A pair of goggles with radar, and...", 0, 0, 0));
		dialogueList.Add(new DialogInfo("Handheld cannonball manufacture tool!", 0, 0, 6));
		dialogueList.Add(new DialogInfo("But why is it DUCK shaped???", 0, 0, 0));
		dialogueList.Add(new DialogInfo("Initially this tool is for making pond decoration, so it's like that.", 1, 1, 0));
		dialogueList.Add(new DialogInfo("Hopefully duck-shaped cannonball is also able to use.", 1, 1, 0));
		dialogueList.Add(new DialogInfo("Hurry, more asteroids are coming. Let's start transmitting data and defend the planet!", 1, 1, 0));
		dialogueList.Add(new DialogInfo("We will lose some data if the planet is damaged before the data finished transmittion, " +
			"so protect it at all cost!", 1, 1, 0));
		dialogueList.Add(new DialogInfo("Be careful don't hurt yourself, of course.", 1, 1, 0));
		dialogueList.Add(new DialogInfo("Why it's always me doing the dangerous part...", 0, 0, 0));
	}
		

	private int cooldown = 5;
	private int stage = 0;
	public bool canControl = false;
	public bool canDialogue = true;
	void Update()
	{
		if (canDialogue)
		{
			if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.KeypadEnter) || Input.GetMouseButtonDown(0))
			{
				++stage;
				if (stage >= dialogueList.Count)
					SceneManager.LoadScene("AstroidScene", LoadSceneMode.Single);
				else
				{
					nametag.text = names[dialogueList[stage].indexNPC];
					dialog.text = dialogueList[stage].dialogText;
					iconField.GetComponent<SpriteRenderer>().sprite = icons[dialogueList[stage].indexIcon];
				}

			}
		}
		if (stage < dialogueList.Count)
		{
			if (dialogueList[stage].isScripted > 0)
			{
				int val = dialogueList[stage].isScripted;
				switch (val)
				{
					// Move to hut
					case 1:
						canControl = true;
						canDialogue = false;
						if (true)
						{
							++stage;
							canControl = false;
							canDialogue = true;
							break;
						}
					// asteroid script animation
					case 2:
						canDialogue = false;


						++stage;
						canDialogue = true;
						break;
					//not using
					case 3:
						break;
					case 4:
						break;
					// reveal cannon
					case 5:
						canControl = true;
						canDialogue = false;

						++stage;
						canControl = false;
						canDialogue = true;
						break;
					// get item
					case 6:
						canControl = true;
						canDialogue = false;

						++stage;
						canControl = false;
						canDialogue = true;
						break;
					default:
						break;
				}
			}
		}
	}
}