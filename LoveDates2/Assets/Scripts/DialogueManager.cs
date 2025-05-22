using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Collections;

public class DialogueManager : MonoBehaviour
{
    public DialogueData dialogueData;
   
    public TMP_Text nameText;
    public TMP_Text dialogueText;
    public float typingSpeed = 0.05f;

    public Image leftCharacterImage;
    public Image rightCharacterImage;

    public Material grayscaleMaterial;
    private Material defaultMaterial;


    private int currentLineIndex = 0;
    private bool isTyping = false;
    private string currentText = "";


    public RectTransform leftCharacterRect;
    public RectTransform rightCharacterRect;
    private Vector3 leftOriginalPos;
    private Vector3 rightOriginalPos;

    public float raiseAmount = 20f;      // Cuánto se eleva el personaje en píxeles
    public float raiseDuration = 0.3f;   // Duración de la animación de subida/bajada

    public AudioSource audioSource;

    void Start()
    {
        defaultMaterial = leftCharacterImage.material;
        leftOriginalPos = leftCharacterRect.anchoredPosition;
        rightOriginalPos = rightCharacterRect.anchoredPosition;

        StartCoroutine(StartDialogue());

    }

    IEnumerator StartDialogue()
    {
        yield return new WaitForSeconds(0.5f);
        ShowNextLine();
    }

    void ShowNextLine()
    {
        if (currentLineIndex < dialogueData.dialogueLines.Length)
        {
            DialogueLine line = dialogueData.dialogueLines[currentLineIndex];

            nameText.text = line.characterName;
            dialogueText.text = "";

            StopAllCoroutines();  // Detener cualquier animación anterior

            if (line.voiceClip != null)
            {
                audioSource.Stop();
                audioSource.clip = line.voiceClip;
                audioSource.Play();
            }

            if (line.characterPosition == CharacterPosition.Left)
            {
                leftCharacterImage.sprite = line.characterSprite;
                leftCharacterImage.material = defaultMaterial;
                rightCharacterImage.material = grayscaleMaterial;

                // Mueve el personaje izquierdo hacia arriba y el derecho vuelve a su posición
                StartCoroutine(RaiseCharacter(leftCharacterRect, true));
                StartCoroutine(RaiseCharacter(rightCharacterRect, false));
            }
            else
            {
                rightCharacterImage.sprite = line.characterSprite;
                rightCharacterImage.material = defaultMaterial;
                leftCharacterImage.material = grayscaleMaterial;

                // Mueve el personaje derecho hacia arriba y el izquierdo vuelve a su posición
                StartCoroutine(RaiseCharacter(rightCharacterRect, true));
                StartCoroutine(RaiseCharacter(leftCharacterRect, false));
            }

            StartCoroutine(TypeLine(line.dialogueText));
            currentLineIndex++;
        }
        else
        {
            Debug.Log("Diálogo terminado");
        }
    }


    IEnumerator TypeLine(string line)
    {
        isTyping = true;
        dialogueText.text = "";
        currentText = line;

        foreach (char c in line)
        {
            dialogueText.text += c;
            yield return new WaitForSeconds(typingSpeed);
        }

        isTyping = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (isTyping)
            {
                StopAllCoroutines();
                dialogueText.text = currentText;
                isTyping = false;
            }
            else
            {
                ShowNextLine();
            }
        }
    }

    IEnumerator RaiseCharacter(RectTransform rect, bool raise)
    {
        Vector3 startPos = rect.anchoredPosition;
        Vector3 targetPos;

        if (rect == leftCharacterRect)
            targetPos = raise ? leftOriginalPos + Vector3.up * raiseAmount : leftOriginalPos;
        else // rightCharacterRect
            targetPos = raise ? rightOriginalPos + Vector3.up * raiseAmount : rightOriginalPos;

        float elapsed = 0f;
        while (elapsed < raiseDuration)
        {
            rect.anchoredPosition = Vector3.Lerp(rect.anchoredPosition, targetPos, elapsed / raiseDuration);
            elapsed += Time.deltaTime;
            yield return null;
        }
        rect.anchoredPosition = targetPos;
    }
}
