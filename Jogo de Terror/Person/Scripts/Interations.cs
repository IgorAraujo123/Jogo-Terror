using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Interations : MonoBehaviour
{
    [Header("Game Objects que vai interagir com personagem principal")]
    [SerializeField] private List<GameObject> objetosInteracoes = new List<GameObject>();

    [SerializeField] private List<string> itens = new List<string>();  

    [Header("Canvas que vai aparecer para pegar item")]
    [SerializeField] private Canvas canvas;

    [Header("Trocar texto e sprite caso não possuir um item, \n tempoEsperaInvoke vai ser o tempo que vai ficar o novo texto \n e imagem")]
    [SerializeField] private Sprite newSprite;
    [SerializeField] private Sprite originalSprite;
    [SerializeField] private string originalTxt;
    [SerializeField] private string newTxt;
    [SerializeField] private float tempoEsperaInvoke;

    [Header("Texto e sprite que vai sofrer alteração")]
    [SerializeField] private Image image;
    [SerializeField] private TextMeshProUGUI textMeshPro;

    void Start()
    {
        canvas.enabled = false; // Garante que o Canvas começa desativado
    }

    void Update()
    {
        Interation();
    }

    private void Interation()
    {
        if (objetosInteracoes.Count >= 1)
        {
            bool isCanvasActive = false;  // Variável para controlar o estado do Canvas

            foreach (GameObject interection in objetosInteracoes)
            {
                float distance = Vector3.Distance(transform.position, interection.transform.position);

                if (distance < 2f)
                {
                    // A posição do Canvas será ajustada para um ponto acima do objeto
                    Vector2 targetPosition = new Vector2(interection.transform.position.x, interection.transform.position.y + 1.5f);

                    // Atualiza a posição do Canvas e torna ele visível
                    canvas.transform.position = targetPosition;
                    canvas.enabled = true;

                    isCanvasActive = true; // Marca que o Canvas deve estar ativo

                    // Se a tecla F for pressionada, o item é adicionado e o objeto é destruído
                    if (Input.GetKeyDown(KeyCode.F))
                    {
                        verifyTypeTag(interection.tag, interection);
                        return;
                    }
                }
            }

            // Se a distância de todos os objetos for maior que 2, desativa o Canvas
            if (!isCanvasActive)
            {
                canvas.enabled = false;
            }
        }
    }

    private void verifyTypeTag(string tag, GameObject interection){
        switch (tag)
        {
            case "Item":
                itens.Add(interection.name.ToString());
                Destroy(interection);
                objetosInteracoes.Remove(interection);
                canvas.enabled = false; // Desativa o Canvas após a interação
                return;
            case "Doors":
                if(itens.Contains(interection.name.Replace("door", "key"))){
                    Destroy(interection);
                    objetosInteracoes.Remove(interection);
                    canvas.enabled = false;
                }else{
                    image.sprite = newSprite;
                    textMeshPro.text = newTxt; 
                    Invoke("VoltarAoSpriteOriginal", tempoEsperaInvoke);       
                }
                return;
            default:
                return;
        }
    }

    private void VoltarAoSpriteOriginal()
    {
        // Volta ao sprite original
        image.sprite = originalSprite;
        textMeshPro.text = originalTxt;
    }
}

