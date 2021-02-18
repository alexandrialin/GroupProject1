using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CharacterCustomization : MonoBehaviour
{
    // hair colour buttons
    public Button blondeButton;
    public Button redButton;
    public Button blueButton;
    public Button brownButton;
    public Button hatButton;

    // outfit buttons
    public Button outfitOne;
    public Button outfitTwo;
    public Button outfitThree;
    public Button outfitFour;

    // prefabs for outfit 1
    public GameObject blondeOne;
    public GameObject redOne;
    public GameObject blueOne;
    public GameObject brownOne;
    public GameObject hatOne;

    // prefabs for outfit 2
    public GameObject blondeTwo;
    public GameObject redTwo;
    public GameObject blueTwo;
    public GameObject brownTwo;
    public GameObject hatTwo;

    // prefabs for outfit 3
    public GameObject blondeThree;
    public GameObject redThree;
    public GameObject blueThree;
    public GameObject brownThree;
    public GameObject hatThree;

    // prefabs for outfit 4
    public GameObject blondeFour;
    public GameObject redFour;
    public GameObject blueFour;
    public GameObject brownFour;
    public GameObject hatFour;

    // to hold Instantiation
    private GameObject characterCloned;
    bool isBlonde = false;
    bool isRed = false;
    bool isBlue = false;
    bool isBrown = false;
    bool isHat = false;

    // to hold selected character
    private GameObject mainCharacter;

    void Start() {
        // default; blonde & outfit 1
        characterCloned = Instantiate(blondeOne, new Vector3(0, 0, -5), Quaternion.Euler(new Vector3(0, 180, 0)));
        isBlonde = true;
        isRed = false;
        isBlue = false;
        isBrown = false;
        isHat = false;
    }

    // hair
    public void changeHairRed() {
        characterCloned.SetActive(false);
        characterCloned = Instantiate(redOne, new Vector3(0, 0, -5), Quaternion.Euler(new Vector3(0, 180, 0)));
        isBlonde = false;
        isRed = true;
        isBlue = false;
        isBrown = false;
        isHat = false;
    }

    public void changeHairBlue() {
        characterCloned.SetActive(false);
        characterCloned = Instantiate(blueOne, new Vector3(0, 0, -5), Quaternion.Euler(new Vector3(0, 180, 0)));
        isBlonde = false;
        isRed = false;
        isBlue = true;
        isBrown = false;
        isHat = false;
    }

    public void changeHairBrown() {
        characterCloned.SetActive(false);
        characterCloned = Instantiate(brownOne, new Vector3(0, 0, -5), Quaternion.Euler(new Vector3(0, 180, 0)));
        isBlonde = false;
        isRed = false;
        isBlue = false;
        isBrown = true;
        isHat = false;
    }

    public void changeHairHat() {
        characterCloned.SetActive(false);
        characterCloned = Instantiate(hatOne, new Vector3(0, 0, -5), Quaternion.Euler(new Vector3(0, 180, 0)));
        isBlonde = false;
        isRed = false;
        isBlue = false;
        isBrown = false;
        isHat = true;
    }

    public void changeHairBlonde() {
        characterCloned.SetActive(false);
        characterCloned = Instantiate(blondeOne, new Vector3(0, 0, -5), Quaternion.Euler(new Vector3(0, 180, 0)));
        isBlonde = true;
        isRed = false;
        isBlue = false;
        isBrown = false;
        isHat = false;
    }

    // outfit
    public void changeOutfitTwo() {
        if (isBlonde == true) {
            characterCloned.SetActive(false);
            characterCloned = Instantiate(blondeTwo, new Vector3(0, 0, -5), Quaternion.Euler(new Vector3(0, 180, 0)));
        }
        if (isRed == true) {
            characterCloned.SetActive(false);
            characterCloned = Instantiate(redTwo, new Vector3(0, 0, -5), Quaternion.Euler(new Vector3(0, 180, 0)));
        }
        if (isBlue == true) {
            characterCloned.SetActive(false);
            characterCloned = Instantiate(blueTwo, new Vector3(0, 0, -5), Quaternion.Euler(new Vector3(0, 180, 0)));
        }
        if (isBrown == true) {
            characterCloned.SetActive(false);
            characterCloned = Instantiate(brownTwo, new Vector3(0, 0, -5), Quaternion.Euler(new Vector3(0, 180, 0)));
        }
        if (isHat == true) {
            characterCloned.SetActive(false);
            characterCloned = Instantiate(hatTwo, new Vector3(0, 0, -5), Quaternion.Euler(new Vector3(0, 180, 0)));
        }
    }

    public void changeOutfitThree() {
        if (isBlonde == true) {
            characterCloned.SetActive(false);
            characterCloned = Instantiate(blondeThree, new Vector3(0, 0, -5), Quaternion.Euler(new Vector3(0, 180, 0)));
        }
        if (isRed == true) {
            characterCloned.SetActive(false);
            characterCloned = Instantiate(redThree, new Vector3(0, 0, -5), Quaternion.Euler(new Vector3(0, 180, 0)));
        }
        if (isBlue == true) {
            characterCloned.SetActive(false);
            characterCloned = Instantiate(blueThree, new Vector3(0, 0, -5), Quaternion.Euler(new Vector3(0, 180, 0)));
        }
        if (isBrown == true) {
            characterCloned.SetActive(false);
            characterCloned = Instantiate(brownThree, new Vector3(0, 0, -5), Quaternion.Euler(new Vector3(0, 180, 0)));
        }
        if (isHat == true) {
            characterCloned.SetActive(false);
            characterCloned = Instantiate(hatThree, new Vector3(0, 0, -5), Quaternion.Euler(new Vector3(0, 180, 0)));
        }
    }

    public void changeOutfitFour() {
        if (isBlonde == true) {
            characterCloned.SetActive(false);
            characterCloned = Instantiate(blondeFour, new Vector3(0, 0, -5), Quaternion.Euler(new Vector3(0, 180, 0)));
        }
        if (isRed == true) {
            characterCloned.SetActive(false);
            characterCloned = Instantiate(redFour, new Vector3(0, 0, -5), Quaternion.Euler(new Vector3(0, 180, 0)));
        }
        if (isBlue == true) {
            characterCloned.SetActive(false);
            characterCloned = Instantiate(blueFour, new Vector3(0, 0, -5), Quaternion.Euler(new Vector3(0, 180, 0)));
        }
        if (isBrown == true) {
            characterCloned.SetActive(false);
            characterCloned = Instantiate(brownFour, new Vector3(0, 0, -5), Quaternion.Euler(new Vector3(0, 180, 0)));
        }
        if (isHat == true) {
            characterCloned.SetActive(false);
            characterCloned = Instantiate(hatFour, new Vector3(0, 0, -5), Quaternion.Euler(new Vector3(0, 180, 0)));
        }
    }

    public void changeOutfitOne() {
        if (isBlonde == true) {
            characterCloned.SetActive(false);
            characterCloned = Instantiate(blondeOne, new Vector3(0, 0, -5), Quaternion.Euler(new Vector3(0, 180, 0)));
        }
        if (isRed == true) {
            characterCloned.SetActive(false);
            characterCloned = Instantiate(redOne, new Vector3(0, 0, -5), Quaternion.Euler(new Vector3(0, 180, 0)));
        }
        if (isBlue == true) {
            characterCloned.SetActive(false);
            characterCloned = Instantiate(blueOne, new Vector3(0, 0, -5), Quaternion.Euler(new Vector3(0, 180, 0)));
        }
        if (isBrown == true) {
            characterCloned.SetActive(false);
            characterCloned = Instantiate(brownOne, new Vector3(0, 0, -5), Quaternion.Euler(new Vector3(0, 180, 0)));
        }
        if (isHat == true) {
            characterCloned.SetActive(false);
            characterCloned = Instantiate(hatOne, new Vector3(0, 0, -5), Quaternion.Euler(new Vector3(0, 180, 0)));
        }
    }

    public void startGame() {
        mainCharacter = characterCloned;
        // SceneManager.LoadScene(); // for later
    }

}