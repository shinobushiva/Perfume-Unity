using UnityEngine;
using System.Collections;

public class TitleGUI : MonoBehaviour
{
	
	public GUISkin skin;

	private bool loading;
	
	void OnGUI ()
	{
		GUI.skin = skin;
		
		GUI.Label (new Rect (0, Screen.height * 0.2f, Screen.width, Screen.height * 0.2f), "Perfume: Global Site", "title");
		
		if (!loading && GUI.Button (new Rect (0, Screen.height * 0.4f, Screen.width, Screen.height * 0.2f), "Click to Play!", "title")) {
			Application.LoadLevelAsync ("Perfume");
			loading = true;
		}
		
		if(loading){
			GUI.Label (new Rect (0, Screen.height * 0.4f, Screen.width, Screen.height * 0.2f), "Loading...", "title");
		}
	}
}
