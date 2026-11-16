using UnityEngine;
using UnityEngine.UIElements;

public class GameOverScript : MonoBehaviour
{
    VisualElement root;

    void Start()
    {
        UIDocument doc = GetComponent<UIDocument>();
        root = doc.rootVisualElement;
        root.style.display = DisplayStyle.None;
    }

    void Update()
    {
        if (gameManeger.instance.GameOver == true)
        {
            root.style.display = DisplayStyle.Flex;
            Time.timeScale = 0;
        }
    }
}
