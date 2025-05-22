using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public enum CharacterPosition
{
    Left,
    Right
}

[System.Serializable]
public class DialogueLine
{
    public string characterName;
    [TextArea(2, 5)] public string dialogueText;
    public Sprite characterSprite;
    public CharacterPosition characterPosition;
    public AudioClip voiceClip;
    public List<DialogueOption> options; // Opcional: solo si hay decisiones
}

[System.Serializable]
public class DialogueOption
{
    public string optionText;
    public DialogueData nextDialogue; // Ahora debe ser otro GameObject con este componente
}

public class DialogueData : MonoBehaviour
{
    public DialogueLine[] dialogueLines;
}
