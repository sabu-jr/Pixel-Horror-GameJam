using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class Scene2DialogueController : MonoBehaviour
{
    [System.Serializable]
    public class Dialogue
    {
        public string speakerName;        // Name of the speaker
        public Sprite speakerPortrait;    // Portrait of the speaker
        public string sentence;           // Single sentence spoken by the speaker
    }

    public Image portraitImage;           // Reference to the UI Image for the portrait
    public TMP_Text headerText;           // Reference to the TMP Text for the speaker's name
    public TMP_Text footerText;           // Reference to the TMP Text for the dialogue
    public GameObject dialogueUI;         // Reference to the entire dialogue UI GameObject

    public Dialogue[] dialogues;          // Array of dialogues
    private int dialogueIndex = 0;        // Current dialogue index

    [SerializeField] private GameObject npc1;
    [SerializeField] private GameObject npc2;

    void Start()
    {
        npc1.SetActive(false);
        npc2.SetActive(false);
        // Start with the first dialogue
        DisplayDialogue();
    }

    void Update()
    {
        // Move to the next sentence/dialogue when Enter is pressed
        if (Input.GetKeyDown(KeyCode.Return))
        {
            NextSentence();
        }
    }

    void DisplayDialogue()
    {
        // Ensure UI is active
        dialogueUI.SetActive(true);

        // Check if the dialogue index is within range
        if (dialogueIndex < dialogues.Length)
        {
            Dialogue currentDialogue = dialogues[dialogueIndex];

            // Update the portrait and the speaker's name
            portraitImage.sprite = currentDialogue.speakerPortrait;
            headerText.text = currentDialogue.speakerName;

                // Display the current sentence
                footerText.text = currentDialogue.sentence;

            if (currentDialogue.speakerPortrait == null)
            {
                portraitImage.enabled = false;
            }
            else
            {
                portraitImage.enabled = true;
            }
        }
    }

    void NextSentence()
    {
        // Move to the next dialogue if available
        dialogueIndex++;

        // If there are more dialogues, display the next one
        if (dialogueIndex < dialogues.Length)
        {
            DisplayDialogue();
        }
        else
        {
            // End of all dialogues
            EndDialogue();
        }
    }

    void EndDialogue()
    {
        // Deactivate the dialogue UI
        npc1.SetActive(true);
        npc2.SetActive(true);
        dialogueUI.SetActive(false);
        Debug.Log("End of dialogue");
    }
}
