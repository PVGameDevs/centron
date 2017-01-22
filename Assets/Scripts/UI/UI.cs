﻿/*
 * Author(s): Isaiah Mann
 * Description: [to be added]
 * Usage: [no notes]
 */

using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI : MonoBehaviour 
{
  const int TITLE_SCREEN = 0;
  const int MAIN_GAME = 1;
  const int CREDITS = 2;

  public void LoadTitleScreen() {
    SceneManager.LoadScene(TITLE_SCREEN);
  }

  public void PlayGame() {
    SceneManager.LoadScene(MAIN_GAME);
  }

  public void LoadCredits() {
    SceneManager.LoadScene(CREDITS);
  }

  public void QuitGame() {
    Application.Quit();
  }

}