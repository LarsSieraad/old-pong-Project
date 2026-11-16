using UnityEngine;
using UnityEngine.UIElements;

public class StartGameScript : MonoBehaviour
{
    VisualElement root;
    private UnityEngine.UIElements.Button button;
    void Start()
    {
        UIDocument doc = GetComponent<UIDocument>();
        root = doc.rootVisualElement;
        button = root.Q<UnityEngine.UIElements.Button>("1");
        Time.timeScale = 0;
    }

    void Update()
    {
        button.clicked += OnButtonClicked;
    }

    void OnButtonClicked()
    {
        root.style.display = DisplayStyle.None;
        Time.timeScale = 1;
    }

}

