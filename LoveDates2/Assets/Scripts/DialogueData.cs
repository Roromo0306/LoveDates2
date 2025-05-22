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
    public string characterName;             // Nombre del personaje que habla
    [TextArea(2, 5)] public string dialogueText;  // Texto del diálogo
    public Sprite characterSprite;           // Sprite que representa al personaje en esta línea
    public CharacterPosition characterPosition;   // Posición del personaje (izquierda o derecha)
    public AudioClip voiceClip;
}

[CreateAssetMenu(fileName = "DialogueData", menuName = "VisualNovel/Dialogue Data")]
public class DialogueData : MonoBehaviour
{
    public DialogueLine[] dialogueLines;     // Lista de líneas de diálogo
}
