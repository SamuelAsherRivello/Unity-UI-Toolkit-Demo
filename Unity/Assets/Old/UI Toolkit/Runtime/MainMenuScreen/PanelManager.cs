using UnityEngine;
using UnityEngine.UIElements;

public class PanelManager : MonoBehaviour
{
    [SerializeField] private UIDocument _uiDocument = null;
    
    // Start is called before the first frame update
    void Start()
    {
        var root = _uiDocument.rootVisualElement;

        Button buttonStart = root.Query<Button>("start-button");
        
        buttonStart.clicked += ButtonStartOnclicked;
    }

    private void ButtonStartOnclicked()
    {
       Debug.Log("Clicked");
    }

}
