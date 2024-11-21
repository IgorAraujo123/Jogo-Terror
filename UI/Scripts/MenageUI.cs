using UnityEngine;

public class MenageUI : MonoBehaviour
{
    [Header("Doc")]
    [SerializeField] private GameObject tituloDoc;
    [SerializeField] private GameObject buttonGitHub;
    [SerializeField] private GameObject buttonUnity;
    [SerializeField] private GameObject buttonCloseDoc;
    [Header("Devs")]
    [SerializeField] private GameObject tituloDevs;
    [SerializeField] private GameObject textDevs;
    [SerializeField] private GameObject buttonCloseDevs;
    [Header("Menu")]
    [SerializeField] private GameObject tituloGame;
    [SerializeField] private GameObject buttonStart;
    [SerializeField] private GameObject buttonDevs;
    [SerializeField] private GameObject buttonDoc;

     public void fecharButtons(){
        if(tituloDoc.activeSelf){
            tituloDoc.SetActive(false);
            buttonGitHub.SetActive(false);
            buttonUnity.SetActive(false);                
            buttonCloseDoc.SetActive(false);
        }else if(tituloGame.activeSelf){
            tituloGame.SetActive(false);
            buttonStart.SetActive(false);
            buttonDevs.SetActive(false);
            buttonDoc.SetActive(false);
        }else{
            tituloDevs.SetActive(false);
            textDevs.SetActive(false);
            buttonCloseDevs.SetActive(false);
        }
    }
}
