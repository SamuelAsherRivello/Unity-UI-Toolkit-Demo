using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEditor.UIElements;


public class MyCustomEditor : EditorWindow
{

    [SerializeField] private VisualTreeAsset m_UXMLTree;

    [MenuItem("Window/UI Toolkit/MyCustomEditor")]
    public static void ShowExample()
    {
        MyCustomEditor wnd = GetWindow<MyCustomEditor>();
        wnd.titleContent = new GUIContent("MyCustomEditor");
    }

    public void CreateGUI()
    {
        // Each editor window contains a root VisualElement object
        VisualElement root = rootVisualElement;
        
        // Import UXML
        var visualTree = AssetDatabase.LoadAssetAtPath<VisualTreeAsset>("Assets/Editor/MyCustomEditor.uxml");
        VisualElement labelFromUXML = visualTree.Instantiate();
        root.Add(labelFromUXML);
        
        

        // VisualElements objects can contain other VisualElements following a tree hierarchy.
        Label label = new Label("\n\nThese controls were created using C# code.");
        root.Add(label);

        Button button = new Button();
        button.name = "button3";
        button.text = "This is button3.";
        rootVisualElement.Add(button);

        Toggle toggle = new Toggle();
        toggle.name = "toggle3";
        toggle.label = "Number?";
        rootVisualElement.Add(toggle);

        SetupButtonHandler();
        
        Debug.Log("m_UXMLTree: " + m_UXMLTree);
        rootVisualElement.Add(m_UXMLTree.Instantiate());
    }

    private void SetupButtonHandler()
    {
        var buttons = rootVisualElement.Query<Button>();
        buttons.ForEach(RegisterHandler);
    }

    private void RegisterHandler(Button button)
    {
        button.RegisterCallback<ClickEvent>(PrintClickMessage);
    }

    private void PrintClickMessage(ClickEvent evt)
    {
        Debug.Log("ok");
    }

}