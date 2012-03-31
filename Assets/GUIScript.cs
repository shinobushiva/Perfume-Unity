using UnityEngine;
using System.Collections;

public class GUIScript : MonoBehaviour
{
	public GUISkin skin;
	
	void OnGUI ()
	{
		GUI.skin = skin;
		
		GUILayout.BeginHorizontal (GUILayout.Width (Screen.width));
		if (CameraSwitcher.i.cameraNum != 0) {
			if (GUILayout.Button ("All")) {
				CameraSwitcher.i.Switch (0);
			}
		}
		GUILayout.FlexibleSpace ();
		
		Rect labelRect = new Rect (0, Screen.height * 0.8f, Screen.width, Screen.height * 0.2f);
		
		if (CameraSwitcher.i.cameraNum != 1) {
			if (GUILayout.Button ("AACHAN")) {
				CameraSwitcher.i.Switch (1);
			}
		} else {
			GUI.Label (labelRect, "AACHAN", "label");
		}
		
		if (CameraSwitcher.i.cameraNum != 2) {
			if (GUILayout.Button ("KASHIYUKA")) {
				CameraSwitcher.i.Switch (2);
			}
		} else {
			GUI.Label (labelRect, "KASHIYUKA", "label");
		}
		
		if (CameraSwitcher.i.cameraNum != 3) {
			if (GUILayout.Button ("NOCCHI")) {
				CameraSwitcher.i.Switch (3);
			}
		} else {
			GUI.Label (labelRect, "NOCCHI", "label");
		}
		GUILayout.EndHorizontal ();
		
		
		Rect backRect = new Rect (0, Screen.height * 0.8f, Screen.width, Screen.height * 0.2f);
		if (GUI.Button (backRect, "Back to the Title", "back")) {
			Application.LoadLevel ("Entrance");
		}
	}
}
