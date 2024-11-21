using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TelaLoading : MonoBehaviour
{
    [SerializeField] private Slider slider;
    [SerializeField] private TextMeshProUGUI txtPorcetagem;

    void Start()
    {        
        StartCoroutine(LoadScene());
    }

    private IEnumerator LoadScene(){
        yield return null;

        AsyncOperation operation = SceneManager.LoadSceneAsync(2);

        while (!operation.isDone)
        {
            float progress = Mathf.Clamp01(operation.progress / 0.9f) * 100;

            slider.value = progress;
            txtPorcetagem.text = progress + "%";

            yield return null;
        }
    }

    private IEnumerator LoadSceneTeste(){
        yield return null;

        //AsyncOperation operation = SceneManager.LoadSceneAsync(2);

        float progress = 0.0f;

        while (progress < 100)
        {
            progress += 5.0f;

            slider.value = progress;
            txtPorcetagem.text = progress + "%";

            yield return new WaitForSeconds(0.8f);
        }


        yield return null;
    }
}
