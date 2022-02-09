using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickHandler : MonoBehaviour
{

  public void openURL(string url) {
        Application.OpenURL(url);
  }

  public void showNotification() {

  }
}
