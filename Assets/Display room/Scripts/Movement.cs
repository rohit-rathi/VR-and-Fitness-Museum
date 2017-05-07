using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Movement : MonoBehaviour {

	// used for the various position that the player can be at 
	public GameObject StartPosition;
	public GameObject PositionOneCanvas;
	public GameObject PositionTwoCanvas;
	public GameObject PositionThreeCanvas;
	public GameObject CanvasThreeHalfPosition;
	public GameObject PositionFourCanvas;
	public GameObject PositionFiveCanvas;
	public GameObject EndPosition;

	public GameObject player;

	// the various canvasses used
	public GameObject HoloFitButtons;
	public GameObject AthleteInfoButtons;
	public GameObject EnterGymCanvas;
	public GameObject DisplayIntroCanvas;
	public GameObject PlayBasketballCanvas;
	public GameObject MoveToThreeHalfCanvas;
	public GameObject MoveToFour;
	public GameObject StartTourCanvas;
	public GameObject WhatThisIsAboutCanvas;
	public GameObject EndTourCanvas;
	public GameObject AthleteInfoCanvas;

	public PersistantObject determinePositionOfCamera;

	public GameObject HoloFitVideo;


	// Use this for initialization
	void Start () {
		/*if (determinePositionOfCamera.GetCount () == 0) {
			EnableComponents.MakeItemAppear (StartTourCanvas);
			player.transform.position = StartPosition.transform.position;
			determinePositionOfCamera.IncrementCount ();
		} 

		else if (determinePositionOfCamera.GetCount () == 1) {
			player.transform.position = PositionThreeCanvas.transform.position;
			player.transform.eulerAngles = new Vector3 (0, -180, 0);
			EnableComponents.MakeItemAppear (MoveToThreeHalfCanvas);
			determinePositionOfCamera.IncrementCount ();
		} 

		else {
			EnableComponents.MakeItemAppear (EndTourCanvas);
			player.transform.position = PositionFiveCanvas.transform.position;
		}		
		DontDestroyOnLoad(determinePositionOfCamera);*/
		player.transform.position = PositionFourCanvas.transform.position;
		EnableComponents.MakeItemAppear (HoloFitButtons);

	}

	public void MoveToFirstCanvas() {
		iTween.MoveTo (player, PositionOneCanvas.transform.position, 1.5f);
		EnableComponents.MakeItemAppear (DisplayIntroCanvas);
		EnableComponents.MakeItemDisappear (StartTourCanvas);
	}

	public void MoveToSecondCanvas() {
		iTween.MoveTo (player, PositionTwoCanvas.transform.position, 1.5f);
		EnableComponents.MakeItemAppear (AthleteInfoButtons);
		EnableComponents.MakeItemDisappear(DisplayIntroCanvas);
	}

	public void MoveToThirdCanvas() {
		iTween.MoveTo (player, PositionThreeCanvas.transform.position, 1.5f);
		EnableComponents.MakeItemDisappear(AthleteInfoButtons);
		EnableComponents.MakeItemAppear (EnterGymCanvas);

	}

	public void MoveToThirdHalfCanvas() {
		iTween.MoveTo (player, CanvasThreeHalfPosition.transform.position, 1.5f);
		EnableComponents.MakeItemDisappear (MoveToThreeHalfCanvas);
		EnableComponents.MakeItemAppear (MoveToFour);

	}
		
	public void MoveToFourthCanvas() {
		iTween.MoveTo (player, PositionFourCanvas.transform.position, 1.5f);
		EnableComponents.MakeItemAppear (HoloFitButtons);
		EnableComponents.MakeItemDisappear(MoveToFour);

	}

	public void MoveToFifthCanvas() {
		iTween.MoveTo (player, PositionFiveCanvas.transform.position, 1.5f);
		EnableComponents.MakeItemDisappear(HoloFitButtons);
		EnableComponents.MakeItemAppear (PlayBasketballCanvas);
	}

	public void MoveToEnd() {
		EnableComponents.MakeItemDisappear (PlayBasketballCanvas);
		iTween.MoveTo (player, EndPosition.transform.position, 1.5f);
	}

	public void LoadGymScene() {
		EnableComponents.MakeItemDisappear (EnterGymCanvas);
		SceneManager.LoadScene ("WorkoutGYM");
	}

	public void LoadBasketballScene() {
		SceneManager.LoadScene ("BasketBall");
	}

	public void DisplayWhatThisIsAboutCanvas() {
		EnableComponents.MakeItemAppear (WhatThisIsAboutCanvas);
	}

	public void DisplayAthleteCanvas() {
		EnableComponents.MakeItemAppear (AthleteInfoCanvas);
	}

	public void PlayHoloFitVideo() {
		GameObject clone = Object.Instantiate (HoloFitVideo);
		clone.SetActive (true);
	}
}
