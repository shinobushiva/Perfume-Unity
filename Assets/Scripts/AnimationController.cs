 using UnityEngine;
using System.Collections;

public class AnimationController : MonoBehaviour
{
	public AudioSource aSource;
	public Animation aachan;
	public Animation kashiyuka;
	public Animation nocchi;
	public Renderer blackWall;
	
	void Awake ()
	{
		aachan.Sample ();
		nocchi.Sample ();
		kashiyuka.Sample ();
	}
	
	// Use this for initialization
	void Start ()
	{
		foreach (AnimationState state in nocchi) {
			state.speed = 1.66f; 
		}
		foreach (AnimationState state in kashiyuka) {
			state.speed = 1.66f; 
		}
		foreach (AnimationState state in aachan) {
			state.speed = 1.66f; 
		}
		
		
		aachan.Sample ();
		nocchi.Sample ();
		kashiyuka.Sample ();
		
		blackWall.enabled = true;
		StartCoroutine (WaitAndStart ());
	}
	 
	bool isPlaying = false;
	
	public IEnumerator WaitAndStart ()
	{
		blackWall.enabled = true;
		yield return new WaitForSeconds(1.0f);
		
		blackWall.enabled = false;
			 
		if (CameraSwitcher.i.cameraNum == -1) {
			CameraSwitcher.i.Switch (0);
		}
		aachan.Play ();
		kashiyuka.Play ();
		nocchi.Play ();
		aSource.Play (); 
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetButtonDown ("Jump")) {
			
			aachan.Stop ();
			aachan.Rewind ();
			
			kashiyuka.Stop ();
			kashiyuka.Rewind ();
			
			nocchi.Stop ();
			nocchi.Rewind ();
			
			aachan.Sample ();
			nocchi.Sample ();
			kashiyuka.Sample ();
			
			aSource.Stop ();
			
			blackWall.enabled = true;
			StartCoroutine (WaitAndStart ());
		
			isPlaying = true;
		}
		
	}
}
