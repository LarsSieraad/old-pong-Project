using UnityEngine;
using UnityEngine.UIElements;

public class gameManeger : MonoBehaviour
{
    public int score1 = 0;
    public int score2 = 0;

    private UnityEngine.UIElements.Label labelScore1;
    private UnityEngine.UIElements.Label labelScore2;

    public bool GameStart = true;
    public bool GameOver = false;

    VisualElement root;


    public static gameManeger instance { get; private set; }
    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this);
        }
        else
        {
            instance = this;
        }
    }

    private void OnEnable()
    {
        var doc = GetComponent<UIDocument>();

        root = doc.rootVisualElement;

        labelScore1 = root.Q<Label>("label1");
        labelScore1.text = "Hallo";
        labelScore2 = root.Q<Label>("label2");
    }

    private void Update()
    {

        labelScore1.text = score1.ToString();
        labelScore2.text = score2.ToString();

        if (score1 == 5 || score2 == 5)
        {
            GameOver = true;
        }

        if (GameStart == true)
        {
            root.style.display = DisplayStyle.None;
        }
        else
        {
            root.style.display = DisplayStyle.Flex;
        }

    }
}
