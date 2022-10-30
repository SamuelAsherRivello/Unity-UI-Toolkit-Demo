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
	public class Scene01_Intro : MonoBehaviour
	{
		//  Events ----------------------------------------


		//  Properties ------------------------------------


		//  Fields ----------------------------------------
		[SerializeField] 
		private UIDocument _uiDocument;

		private Button _playGameButton;

		//  Unity Methods  --------------------------------
		protected void Start ()
		{
			_playGameButton = _uiDocument.rootVisualElement.Q<Button>("PlayGameButton");
			_playGameButton.clicked += PlayGameButton_OnClicked;
		}


		//  Methods ---------------------------------------


		//  Event Handlers --------------------------------
		private void PlayGameButton_OnClicked()
		{
			Debug.Log("Play game");
			SceneManager.LoadScene("Scene02_Game");
		}
	}
}
