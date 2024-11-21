using UnityEngine;

public class OpenLinks : MonoBehaviour
{
    public void openUnityDocLink(){
        Application.OpenURL("https://docs.unity3d.com/ScriptReference/index.html");
    }

    public void openGitHubLink(){
        Application.OpenURL("https://github.com/IgorAraujo123/Jogo-Terror");
    }
}
