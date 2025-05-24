using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class DialogueManager : MonoBehaviour
{
    public DialogueData dialogueData;
    public TextMeshProUGUI nameText;
    public TextMeshProUGUI dialogueText;

    public Image leftCharacterImage;
    public Image rightCharacterImage;
    public Material defaultMaterial;
    public Material grayscaleMaterial;

    public RectTransform leftCharacterRect;
    public RectTransform rightCharacterRect;

    public float raiseAmount = 20f;
    public float raiseDuration = 0.3f;

    private Vector3 leftOriginalPos;
    private Vector3 rightOriginalPos;

    private int currentLineIndex = 0;

    public GameObject optionsPanel;          // Panel donde aparecerán las opciones
    public GameObject optionButtonPrefab;    // Prefab para instanciar botones de opciones

    public AudioSource audioSource;          // Para reproducir sonidos por línea (opcional)

    private bool isTyping = false;

    public Animator FadeInMini;

    void Start()
    {
        defaultMaterial = leftCharacterImage.material;
        leftOriginalPos = leftCharacterRect.anchoredPosition;
        rightOriginalPos = rightCharacterRect.anchoredPosition;

        StartCoroutine(StartDialogue());
    }

    IEnumerator StartDialogue()
    {
        yield return null;
        ShowNextLine();
    }

    public void ShowNextLine()
    {
        if (currentLineIndex < dialogueData.dialogueLines.Length)
        {
            DialogueLine line = dialogueData.dialogueLines[currentLineIndex];
            ShowDialogueLine(line);
        }
        else
        {
            Debug.Log("Diálogo terminado");
            FadeInMini.SetTrigger("DialogoTerminado");
            // Aquí podrías añadir lógica para finalizar escena o avanzar a otra
            StartCoroutine(PasarEscena());
        }
    }
    IEnumerator PasarEscena()
    {
        yield return new WaitForSeconds(1);
        DialogueLine lastLine = dialogueData.dialogueLines[dialogueData.dialogueLines.Length - 1];
        if (!string.IsNullOrEmpty(lastLine.nextSceneName))
        {
            SceneManager.LoadScene(lastLine.nextSceneName);
        }
        else
        {
            // Si no hay escena asignada, solo imprime mensaje
            Debug.Log("No se asignó una nueva escena.");
        }
    }

    void ShowDialogueLine(DialogueLine line)
    {
        nameText.text = line.characterName;
        dialogueText.text = "";

        StopAllCoroutines();
        StartCoroutine(TypeLine(line.dialogueText));

        // Reproducir sonido (si se asignó)
        if (audioSource != null && line.voiceClip != null)
        {
            audioSource.Stop();
            audioSource.clip = line.voiceClip;
            audioSource.Play();
        }

        // Cambiar sprite y materiales
        if (line.characterPosition == CharacterPosition.Left)
        {
            leftCharacterImage.sprite = line.characterSprite;
            leftCharacterImage.material = defaultMaterial;
            rightCharacterImage.material = grayscaleMaterial;

            StartCoroutine(RaiseCharacter(leftCharacterRect, true));
            StartCoroutine(RaiseCharacter(rightCharacterRect, false));
        }
        else
        {
            rightCharacterImage.sprite = line.characterSprite;
            rightCharacterImage.material = defaultMaterial;
            leftCharacterImage.material = grayscaleMaterial;

            StartCoroutine(RaiseCharacter(rightCharacterRect, true));
            StartCoroutine(RaiseCharacter(leftCharacterRect, false));
        }
    }

    IEnumerator RaiseCharacter(RectTransform rect, bool raise)
    {
        Vector3 startPos = rect.anchoredPosition;
        Vector3 targetPos;

        if (rect == leftCharacterRect)
            targetPos = raise ? leftOriginalPos + Vector3.up * raiseAmount : leftOriginalPos;
        else
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

    IEnumerator TypeLine(string lineText)
    {
        isTyping = true;
        dialogueText.text = "";

        foreach (char letter in lineText.ToCharArray())
        {
            dialogueText.text += letter;
            yield return new WaitForSeconds(0.03f);
        }

        isTyping = false;

        DialogueLine currentLine = dialogueData.dialogueLines[currentLineIndex];

        if (currentLine.options != null && currentLine.options.Count > 0)
        {
            ShowOptions(currentLine.options);
        }
        else
        {
            currentLineIndex++; // Solo avanzamos automáticamente si no hay opciones
        }
    }

    void ShowOptions(List<DialogueOption> options)
    {
        if (optionsPanel == null || optionButtonPrefab == null)
        {
            Debug.LogError("OptionsPanel o OptionButtonPrefab no están asignados en el Inspector");
            return;
        }

        foreach (Transform child in optionsPanel.transform)
        {
            Destroy(child.gameObject);
        }

        foreach (var option in options)
        {
            GameObject buttonObj = Instantiate(optionButtonPrefab, optionsPanel.transform);
            Button button = buttonObj.GetComponent<Button>();
            TMP_Text buttonText = buttonObj.GetComponentInChildren<TMP_Text>();
            buttonText.text = option.optionText;

            button.onClick.AddListener(() => OnOptionSelected(option));
        }

        optionsPanel.SetActive(true);
    }

    void OnOptionSelected(DialogueOption option)
    {
        optionsPanel.SetActive(false);

        if (option.nextDialogue != null)
        {
            dialogueData = option.nextDialogue;
            currentLineIndex = 0;
            ShowNextLine();
        }
        else
        {
            currentLineIndex++;
            ShowNextLine();
        }
    }

    public void OnContinue()
    {
        if (optionsPanel.activeSelf || isTyping) return;
        ShowNextLine();
    }

    void Update()
    {
        if (optionsPanel.activeSelf) return;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            OnContinue();
        }
    }
}
