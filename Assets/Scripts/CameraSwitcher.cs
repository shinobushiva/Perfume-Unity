using UnityEngine;
using System.Collections;

public class CameraSwitcher : MonoBehaviour
{
	
	public static CameraSwitcher i;
	public Camera main;
	public Camera aachan;
	public Camera kashiyuka;
	public Camera nocchi;
	private Camera[] cameras;
	public int cameraNum = 0;

	// Use this for initialization
	void Start ()
	{
		i = this;
		cameras = new Camera[]{main, aachan, kashiyuka, nocchi};
		Switch (0);
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}
	
	public void Switch (int num)
	{
		cameraNum = num;
		foreach (Camera c in cameras) {
			c.enabled = false;
		}
		if (num >= 0) {
			cameras [num].enabled = true;
		}
		
	}
}
