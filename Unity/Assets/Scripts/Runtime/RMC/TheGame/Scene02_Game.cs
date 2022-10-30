using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

namespace RMC.Templates
{
    //  Namespace Properties ------------------------------

    //  Class Attributes ----------------------------------

    /// <summary>
    /// Replace with comments...
    /// </summary>
    public class Scene02_Game : MonoBehaviour
    {
        //  Events ----------------------------------------


        //  Properties ------------------------------------


        //  Fields ----------------------------------------
        [SerializeField] 
        private UIDocument _uiDocument;

        private Button _backButton;

        //  Unity Methods  --------------------------------
        protected void Start ()
        {
            _backButton = _uiDocument.rootVisualElement.Q<Button>("BackButton");
            _backButton.clicked += BackButton_OnClicked;
        }


        //  Methods ---------------------------------------


        //  Event Handlers --------------------------------
        private void BackButton_OnClicked()
        {
            SceneManager.LoadScene("Scene01_Intro");
        }
    }
}