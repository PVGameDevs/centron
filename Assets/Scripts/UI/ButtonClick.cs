﻿/*
 * Author(s): Isaiah Mann
 * Description: [to be added]
 * Usage: [no notes]
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonClick : UI 
{
  Button button;

  void Awake() {
    button = GetComponentInChildren<Button>();
    if(button) {
      button.onClick.AddListener(playClickSFX);
    }
  }

  void playClickSFX() {
    EventModule.Event(EventType.UI_CLICK);
  }
  
}
