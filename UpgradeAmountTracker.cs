using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeAmountTracker : MonoBehaviour
{
    public Image tracker;
    public Levels levels;
    private string nameOfUpgrade;
    public Sprite emptyOne;
    public Sprite emptyTwo;
    public Sprite emptyThree;
    public Sprite emptyFour;
    public Sprite fullOne;
    public Sprite fullTwo;
    public Sprite fullThree;
    public Sprite fullFour;
    public Sprite halfTwo;
    public Sprite oneThree;
    public Sprite oneFour;
    public Sprite halfFour;
    public Sprite twoThree;
    public Sprite threeFour;
    private Color colour;
    private Color colorol;
    // Start is called before the first frame update
    void Start()
    {
        tracker = this.GetComponent<Image>();
        colour = tracker.color;
        colorol = tracker.color;
        colour.a = 0f;
        nameOfUpgrade = this.gameObject.name;
        switch (name)
        {
            case "Discipline":
                switch (levels.selectedFrog.currentFrogSO.maxAmountUpgradeDisciplin)
                {
                    case 0:
                        tracker.GetComponentInParent<Button>().interactable = false;
                        tracker.color = colour;
                        break;
                    case 1:
                        if (levels.selectedFrog.frogData.GetDisciplin() - levels.selectedFrog.frogData.disciplinBase == 0)
                        {
                            tracker.sprite = emptyOne;
                            tracker.GetComponentInParent<Button>().interactable = true;
                            tracker.color = colorol;
                        }
                        else if (levels.selectedFrog.frogData.GetDisciplin() - levels.selectedFrog.frogData.disciplinBase == levels.selectedFrog.currentFrogSO.disciplinIncreaseAmount)
                        {
                            tracker.sprite = fullOne;
                            tracker.GetComponentInParent<Button>().interactable = false;
                            tracker.color = colorol;
                        }
                        break;
                    case 2:
                        if (levels.selectedFrog.frogData.GetDisciplin() - levels.selectedFrog.frogData.disciplinBase == 0)
                        {
                            tracker.sprite = emptyTwo;
                            tracker.GetComponentInParent<Button>().interactable = true;
                            tracker.color = colorol;
                        }
                        else if (levels.selectedFrog.frogData.GetDisciplin() - levels.selectedFrog.frogData.disciplinBase == levels.selectedFrog.currentFrogSO.disciplinIncreaseAmount)
                        {
                            tracker.sprite = halfTwo;
                            tracker.GetComponentInParent<Button>().interactable = true;
                            tracker.color = colorol;
                        }
                        else if (levels.selectedFrog.frogData.GetDisciplin() - levels.selectedFrog.frogData.disciplinBase == (levels.selectedFrog.currentFrogSO.disciplinIncreaseAmount * 2))
                        {
                            tracker.sprite = fullTwo;
                            tracker.GetComponentInParent<Button>().interactable = false;
                            tracker.color = colorol;
                        }
                        break;
                    case 3:
                        if (levels.selectedFrog.frogData.GetDisciplin() - levels.selectedFrog.frogData.disciplinBase == 0)
                        {
                            tracker.sprite = emptyThree;
                            tracker.GetComponentInParent<Button>().interactable = true;
                            tracker.color = colorol;
                        }
                        else if (levels.selectedFrog.frogData.GetDisciplin() - levels.selectedFrog.frogData.disciplinBase == levels.selectedFrog.currentFrogSO.disciplinIncreaseAmount)
                        {
                            tracker.sprite = oneThree;
                            tracker.GetComponentInParent<Button>().interactable = true;
                            tracker.color = colorol;
                        }
                        else if (levels.selectedFrog.frogData.GetDisciplin() - levels.selectedFrog.frogData.disciplinBase == (levels.selectedFrog.currentFrogSO.disciplinIncreaseAmount * 2))
                        {
                            tracker.sprite = twoThree;
                            tracker.GetComponentInParent<Button>().interactable = true;
                            tracker.color = colorol;
                        }
                        else if (levels.selectedFrog.frogData.GetDisciplin() - levels.selectedFrog.frogData.disciplinBase == (levels.selectedFrog.currentFrogSO.disciplinIncreaseAmount * 3))
                        {
                            tracker.sprite = fullThree;
                            tracker.GetComponentInParent<Button>().interactable = false;
                            tracker.color = colorol;
                        }
                        break;
                    case 4:
                        if (levels.selectedFrog.frogData.GetDisciplin() - levels.selectedFrog.frogData.disciplinBase == 0)
                        {
                            tracker.sprite = emptyFour;
                            tracker.GetComponentInParent<Button>().interactable = true;
                            tracker.color = colorol;
                        }
                        else if (levels.selectedFrog.frogData.GetDisciplin() - levels.selectedFrog.frogData.disciplinBase == levels.selectedFrog.currentFrogSO.disciplinIncreaseAmount)
                        {
                            tracker.sprite = oneFour;
                            tracker.GetComponentInParent<Button>().interactable = true;
                            tracker.color = colorol;
                        }
                        else if (levels.selectedFrog.frogData.GetDisciplin() - levels.selectedFrog.frogData.disciplinBase == (levels.selectedFrog.currentFrogSO.disciplinIncreaseAmount * 2))
                        {
                            tracker.sprite = halfFour;
                            tracker.GetComponentInParent<Button>().interactable = true;
                            tracker.color = colorol;
                        }
                        else if (levels.selectedFrog.frogData.GetDisciplin() - levels.selectedFrog.frogData.disciplinBase == (levels.selectedFrog.currentFrogSO.disciplinIncreaseAmount * 3))
                        {
                            tracker.sprite = threeFour;
                            tracker.GetComponentInParent<Button>().interactable = true;
                            tracker.color = colorol;
                        }
                        else if (levels.selectedFrog.frogData.GetDisciplin() - levels.selectedFrog.frogData.disciplinBase == (levels.selectedFrog.currentFrogSO.disciplinIncreaseAmount * 4))
                        {
                            tracker.sprite = fullFour;
                            tracker.GetComponentInParent<Button>().interactable = false;
                            tracker.color = colorol;
                        }
                        break;
                    default:

                        break;
                }
                break;
            case "Damage":
                switch (levels.selectedFrog.currentFrogSO.maxAmountUpgradeDamage)
                {
                    case 0:
                        tracker.GetComponentInParent<Button>().interactable = false;
                        tracker.color = colour;
                        break;
                    case 1:
                        if (levels.selectedFrog.frogData.GetDamage() - levels.selectedFrog.frogData.damageBase == 0)
                        {
                            tracker.sprite = emptyOne;
                            tracker.GetComponentInParent<Button>().interactable = true;
                            tracker.color = colorol;
                        }
                        else if (levels.selectedFrog.frogData.GetDamage() - levels.selectedFrog.frogData.damageBase == levels.selectedFrog.currentFrogSO.damageIncreaseAmount)
                        {
                            tracker.sprite = fullOne;
                            tracker.GetComponentInParent<Button>().interactable = false;
                            tracker.color = colorol;
                        }
                        break;
                    case 2:
                        if (levels.selectedFrog.frogData.GetDamage() - levels.selectedFrog.frogData.damageBase == 0)
                        {
                            tracker.sprite = emptyTwo;
                            tracker.GetComponentInParent<Button>().interactable = true;
                            tracker.color = colorol;
                        }
                        else if (levels.selectedFrog.frogData.GetDamage() - levels.selectedFrog.frogData.damageBase == levels.selectedFrog.currentFrogSO.damageIncreaseAmount)
                        {
                            tracker.sprite = halfTwo;
                            tracker.GetComponentInParent<Button>().interactable = true;
                            tracker.color = colorol;
                        }
                        else if (levels.selectedFrog.frogData.GetDamage() - levels.selectedFrog.frogData.damageBase == (levels.selectedFrog.currentFrogSO.damageIncreaseAmount * 2))
                        {
                            tracker.sprite = fullTwo;
                            tracker.GetComponentInParent<Button>().interactable = false;
                            tracker.color = colorol;
                        }
                        break;
                    case 3:
                        if (levels.selectedFrog.frogData.GetDamage() - levels.selectedFrog.frogData.damageBase == 0)
                        {
                            tracker.sprite = emptyThree;
                            tracker.GetComponentInParent<Button>().interactable = true;
                            tracker.color = colorol;
                        }
                        else if (levels.selectedFrog.frogData.GetDamage() - levels.selectedFrog.frogData.damageBase == levels.selectedFrog.currentFrogSO.damageIncreaseAmount)
                        {
                            tracker.sprite = oneThree;
                            tracker.GetComponentInParent<Button>().interactable = true;
                            tracker.color = colorol;
                        }
                        else if (levels.selectedFrog.frogData.GetDamage() - levels.selectedFrog.frogData.damageBase == (levels.selectedFrog.currentFrogSO.damageIncreaseAmount * 2))
                        {
                            tracker.sprite = twoThree;
                            tracker.GetComponentInParent<Button>().interactable = true;
                            tracker.color = colorol;
                        }
                        else if (levels.selectedFrog.frogData.GetDamage() - levels.selectedFrog.frogData.damageBase == (levels.selectedFrog.currentFrogSO.damageIncreaseAmount * 3))
                        {
                            tracker.sprite = fullThree;
                            tracker.GetComponentInParent<Button>().interactable = false;
                            tracker.color = colorol;
                        }
                        break;
                    case 4:
                        if (levels.selectedFrog.frogData.GetDamage() - levels.selectedFrog.frogData.damageBase == 0)
                        {
                            tracker.sprite = emptyFour;
                            tracker.GetComponentInParent<Button>().interactable = true;
                            tracker.color = colorol;
                        }
                        else if (levels.selectedFrog.frogData.GetDamage() - levels.selectedFrog.frogData.damageBase == levels.selectedFrog.currentFrogSO.damageIncreaseAmount)
                        {
                            tracker.sprite = oneFour;
                            tracker.GetComponentInParent<Button>().interactable = true;
                            tracker.color = colorol;
                        }
                        else if (levels.selectedFrog.frogData.GetDamage() - levels.selectedFrog.frogData.damageBase == (levels.selectedFrog.currentFrogSO.damageIncreaseAmount * 2))
                        {
                            tracker.sprite = halfFour;
                            tracker.GetComponentInParent<Button>().interactable = true;
                            tracker.color = colorol;
                        }
                        else if (levels.selectedFrog.frogData.GetDamage() - levels.selectedFrog.frogData.damageBase == (levels.selectedFrog.currentFrogSO.damageIncreaseAmount * 3))
                        {
                            tracker.sprite = threeFour;
                            tracker.GetComponentInParent<Button>().interactable = true;
                            tracker.color = colorol;
                        }
                        else if (levels.selectedFrog.frogData.GetDamage() - levels.selectedFrog.frogData.damageBase == (levels.selectedFrog.currentFrogSO.damageIncreaseAmount * 4))
                        {
                            tracker.sprite = fullFour;
                            tracker.GetComponentInParent<Button>().interactable = false;
                            tracker.color = colorol;
                        }
                        break;
                    default:

                        break;
                }
                break;
            case "Fire Rate":
                switch (levels.selectedFrog.currentFrogSO.maxAmountUpgradeFireRate)
                {
                    case 0:
                        tracker.GetComponentInParent<Button>().interactable = false;
                        tracker.color = colour;
                        break;
                    case 1:
                        if (levels.selectedFrog.frogData.GetFireRate() - levels.selectedFrog.frogData.fireRateBase == 0)
                        {
                            tracker.sprite = emptyOne;
                            tracker.GetComponentInParent<Button>().interactable = true;
                            tracker.color = colorol;
                        }
                        else if (levels.selectedFrog.frogData.GetFireRate() - levels.selectedFrog.frogData.fireRateBase == levels.selectedFrog.currentFrogSO.fireRateIncreaseAmount)
                        {
                            tracker.sprite = fullOne;
                            tracker.GetComponentInParent<Button>().interactable = false;
                            tracker.color = colorol;
                        }
                        break;
                    case 2:
                        if (levels.selectedFrog.frogData.GetFireRate() - levels.selectedFrog.frogData.fireRateBase == 0)
                        {
                            tracker.sprite = emptyTwo;
                            tracker.GetComponentInParent<Button>().interactable = true;
                            tracker.color = colorol;
                        }
                        else if (levels.selectedFrog.frogData.GetFireRate() - levels.selectedFrog.frogData.fireRateBase == levels.selectedFrog.currentFrogSO.fireRateIncreaseAmount)
                        {
                            tracker.sprite = halfTwo;
                            tracker.GetComponentInParent<Button>().interactable = true;
                            tracker.color = colorol;
                        }
                        else if (levels.selectedFrog.frogData.GetFireRate() - levels.selectedFrog.frogData.fireRateBase == (levels.selectedFrog.currentFrogSO.fireRateIncreaseAmount * 2))
                        {
                            tracker.sprite = fullTwo;
                            tracker.GetComponentInParent<Button>().interactable = false;
                            tracker.color = colorol;
                        }
                        break;
                    case 3:
                        if (levels.selectedFrog.frogData.GetFireRate() - levels.selectedFrog.frogData.fireRateBase == 0)
                        {
                            tracker.sprite = emptyThree;
                            tracker.GetComponentInParent<Button>().interactable = true;
                            tracker.color = colorol;
                        }
                        else if (levels.selectedFrog.frogData.GetFireRate() - levels.selectedFrog.frogData.fireRateBase == levels.selectedFrog.currentFrogSO.fireRateIncreaseAmount)
                        {
                            tracker.sprite = oneThree;
                            tracker.GetComponentInParent<Button>().interactable = true;
                            tracker.color = colorol;
                        }
                        else if (levels.selectedFrog.frogData.GetFireRate() - levels.selectedFrog.frogData.fireRateBase == (levels.selectedFrog.currentFrogSO.fireRateIncreaseAmount * 2))
                        {
                            tracker.sprite = twoThree;
                            tracker.GetComponentInParent<Button>().interactable = true;
                            tracker.color = colorol;
                        }
                        else if (levels.selectedFrog.frogData.GetFireRate() - levels.selectedFrog.frogData.fireRateBase == (levels.selectedFrog.currentFrogSO.fireRateIncreaseAmount * 3))
                        {
                            tracker.sprite = fullThree;
                            tracker.GetComponentInParent<Button>().interactable = false;
                            tracker.color = colorol;
                        }
                        break;
                    case 4:
                        if (levels.selectedFrog.frogData.GetFireRate() - levels.selectedFrog.frogData.fireRateBase == 0)
                        {
                            tracker.sprite = emptyFour;
                            tracker.GetComponentInParent<Button>().interactable = true;
                            tracker.color = colorol;
                        }
                        else if (levels.selectedFrog.frogData.GetFireRate() - levels.selectedFrog.frogData.fireRateBase == levels.selectedFrog.currentFrogSO.fireRateIncreaseAmount)
                        {
                            tracker.sprite = oneFour;
                            tracker.GetComponentInParent<Button>().interactable = true;
                            tracker.color = colorol;
                        }
                        else if (levels.selectedFrog.frogData.GetFireRate() - levels.selectedFrog.frogData.fireRateBase == (levels.selectedFrog.currentFrogSO.fireRateIncreaseAmount * 2))
                        {
                            tracker.sprite = halfFour;
                            tracker.GetComponentInParent<Button>().interactable = true;
                            tracker.color = colorol;
                        }
                        else if (levels.selectedFrog.frogData.GetFireRate() - levels.selectedFrog.frogData.fireRateBase == (levels.selectedFrog.currentFrogSO.fireRateIncreaseAmount * 3))
                        {
                            tracker.sprite = threeFour;
                            tracker.GetComponentInParent<Button>().interactable = true;
                            tracker.color = colorol;
                        }
                        else if (levels.selectedFrog.frogData.GetFireRate() - levels.selectedFrog.frogData.fireRateBase == (levels.selectedFrog.currentFrogSO.fireRateIncreaseAmount * 4))
                        {
                            tracker.sprite = fullFour;
                            tracker.GetComponentInParent<Button>().interactable = false;
                            tracker.color = colorol;
                        }
                        break;
                    default:

                        break;
                }
                break;
            case "Range":
                switch (levels.selectedFrog.currentFrogSO.maxAmountUpgradeRange)
                {
                    case 0:
                        tracker.GetComponentInParent<Button>().interactable = false;
                        tracker.color = colour;
                        break;
                    case 1:
                        if (levels.selectedFrog.frogData.GetRange() - levels.selectedFrog.frogData.rangeBase == 0)
                        {
                            tracker.sprite = emptyOne;
                            tracker.GetComponentInParent<Button>().interactable = true;
                            tracker.color = colorol;
                        }
                        else if (levels.selectedFrog.frogData.GetRange() - levels.selectedFrog.frogData.rangeBase == levels.selectedFrog.currentFrogSO.rangeIncreaseAmount)
                        {
                            tracker.sprite = fullOne;
                            tracker.GetComponentInParent<Button>().interactable = false;
                            tracker.color = colorol;
                        }
                        break;
                    case 2:
                        if (levels.selectedFrog.frogData.GetRange() - levels.selectedFrog.frogData.rangeBase == 0)
                        {
                            tracker.sprite = emptyTwo;
                            tracker.GetComponentInParent<Button>().interactable = true;
                            tracker.color = colorol;
                        }
                        else if (levels.selectedFrog.frogData.GetRange() - levels.selectedFrog.frogData.rangeBase == levels.selectedFrog.currentFrogSO.rangeIncreaseAmount)
                        {
                            tracker.sprite = halfTwo;
                            tracker.GetComponentInParent<Button>().interactable = true;
                            tracker.color = colorol;
                        }
                        else if (levels.selectedFrog.frogData.GetRange() - levels.selectedFrog.frogData.rangeBase == (levels.selectedFrog.currentFrogSO.rangeIncreaseAmount * 2))
                        {
                            tracker.sprite = fullTwo;
                            tracker.GetComponentInParent<Button>().interactable = false;
                            tracker.color = colorol;
                        }
                        break;
                    case 3:
                        if (levels.selectedFrog.frogData.GetRange() - levels.selectedFrog.frogData.rangeBase == 0)
                        {
                            tracker.sprite = emptyThree;
                            tracker.GetComponentInParent<Button>().interactable = true;
                            tracker.color = colorol;
                        }
                        else if (levels.selectedFrog.frogData.GetRange() - levels.selectedFrog.frogData.rangeBase == levels.selectedFrog.currentFrogSO.rangeIncreaseAmount)
                        {
                            tracker.sprite = oneThree;
                            tracker.GetComponentInParent<Button>().interactable = true;
                            tracker.color = colorol;
                        }
                        else if (levels.selectedFrog.frogData.GetRange() - levels.selectedFrog.frogData.rangeBase == (levels.selectedFrog.currentFrogSO.rangeIncreaseAmount * 2))
                        {
                            tracker.sprite = twoThree;
                            tracker.GetComponentInParent<Button>().interactable = true;
                            tracker.color = colorol;
                        }
                        else if (levels.selectedFrog.frogData.GetRange() - levels.selectedFrog.frogData.rangeBase == (levels.selectedFrog.currentFrogSO.rangeIncreaseAmount * 3))
                        {
                            tracker.sprite = fullThree;
                            tracker.GetComponentInParent<Button>().interactable = false;
                            tracker.color = colorol;
                        }
                        break;
                    case 4:
                        if (levels.selectedFrog.frogData.GetRange() - levels.selectedFrog.frogData.rangeBase == 0)
                        {
                            tracker.sprite = emptyFour;
                            tracker.GetComponentInParent<Button>().interactable = true;
                            tracker.color = colorol;
                        }
                        else if (levels.selectedFrog.frogData.GetRange() - levels.selectedFrog.frogData.rangeBase == levels.selectedFrog.currentFrogSO.rangeIncreaseAmount)
                        {
                            tracker.sprite = oneFour;
                            tracker.GetComponentInParent<Button>().interactable = true;
                            tracker.color = colorol;
                        }
                        else if (levels.selectedFrog.frogData.GetRange() - levels.selectedFrog.frogData.rangeBase == (levels.selectedFrog.currentFrogSO.rangeIncreaseAmount * 2))
                        {
                            tracker.sprite = halfFour;
                            tracker.GetComponentInParent<Button>().interactable = true;
                            tracker.color = colorol;
                        }
                        else if (levels.selectedFrog.frogData.GetRange() - levels.selectedFrog.frogData.rangeBase == (levels.selectedFrog.currentFrogSO.rangeIncreaseAmount * 3))
                        {
                            tracker.sprite = threeFour;
                            tracker.GetComponentInParent<Button>().interactable = true;
                            tracker.color = colorol;
                        }
                        else if (levels.selectedFrog.frogData.GetRange() - levels.selectedFrog.frogData.rangeBase == (levels.selectedFrog.currentFrogSO.rangeIncreaseAmount * 4))
                        {
                            tracker.sprite = fullFour;
                            tracker.GetComponentInParent<Button>().interactable = false;
                            tracker.color = colorol;
                        }
                        break;
                    default:

                        break;
                }
                break;
            default:
                break;
        }

    }

    // Update is called once per frame
    void Update()
    {

        switch (name)
        {
            case "Discipline":
                switch (levels.selectedFrog.currentFrogSO.maxAmountUpgradeDisciplin)
                {
                    case 0:
                        tracker.GetComponentInParent<Button>().interactable = false;
                        tracker.color = colour;
                        break;
                    case 1:
                        if (levels.selectedFrog.frogData.GetDisciplin() - levels.selectedFrog.frogData.disciplinBase == 0)
                        {
                            tracker.sprite = emptyOne;
                            tracker.GetComponentInParent<Button>().interactable = true;
                            tracker.color = colorol;
                        }
                        else if (levels.selectedFrog.frogData.GetDisciplin() - levels.selectedFrog.frogData.disciplinBase == levels.selectedFrog.currentFrogSO.disciplinIncreaseAmount)
                        {
                            tracker.sprite = fullOne;
                            tracker.GetComponentInParent<Button>().interactable = false;
                            tracker.color = colorol;
                        }
                        break;
                    case 2:
                        if (levels.selectedFrog.frogData.GetDisciplin() - levels.selectedFrog.frogData.disciplinBase == 0)
                        {
                            tracker.sprite = emptyTwo;
                            tracker.GetComponentInParent<Button>().interactable = true;
                            tracker.color = colorol;
                        }
                        else if (levels.selectedFrog.frogData.GetDisciplin() - levels.selectedFrog.frogData.disciplinBase == levels.selectedFrog.currentFrogSO.disciplinIncreaseAmount)
                        {
                            tracker.sprite = halfTwo;
                            tracker.GetComponentInParent<Button>().interactable = true;
                            tracker.color = colorol;
                        }
                        else if (levels.selectedFrog.frogData.GetDisciplin() - levels.selectedFrog.frogData.disciplinBase == (levels.selectedFrog.currentFrogSO.disciplinIncreaseAmount * 2))
                        {
                            tracker.sprite = fullTwo;
                            tracker.GetComponentInParent<Button>().interactable = false;
                            tracker.color = colorol;
                        }
                        break;
                    case 3:
                        if (levels.selectedFrog.frogData.GetDisciplin() - levels.selectedFrog.frogData.disciplinBase == 0)
                        {
                            tracker.sprite = emptyThree;
                            tracker.GetComponentInParent<Button>().interactable = true;
                            tracker.color = colorol;
                        }
                        else if (levels.selectedFrog.frogData.GetDisciplin() - levels.selectedFrog.frogData.disciplinBase == levels.selectedFrog.currentFrogSO.disciplinIncreaseAmount)
                        {
                            tracker.sprite = oneThree;
                            tracker.GetComponentInParent<Button>().interactable = true;
                            tracker.color = colorol;
                        }
                        else if (levels.selectedFrog.frogData.GetDisciplin() - levels.selectedFrog.frogData.disciplinBase == (levels.selectedFrog.currentFrogSO.disciplinIncreaseAmount * 2))
                        {
                            tracker.sprite = twoThree;
                            tracker.GetComponentInParent<Button>().interactable = true;
                            tracker.color = colorol;
                        }
                        else if (levels.selectedFrog.frogData.GetDisciplin() - levels.selectedFrog.frogData.disciplinBase == (levels.selectedFrog.currentFrogSO.disciplinIncreaseAmount * 3))
                        {
                            tracker.sprite = fullThree;
                            tracker.GetComponentInParent<Button>().interactable = false;
                            tracker.color = colorol;
                        }
                        break;
                    case 4:
                        if (levels.selectedFrog.frogData.GetDisciplin() - levels.selectedFrog.frogData.disciplinBase == 0)
                        {
                            tracker.sprite = emptyFour;
                            tracker.GetComponentInParent<Button>().interactable = true;
                            tracker.color = colorol;
                        }
                        else if (levels.selectedFrog.frogData.GetDisciplin() - levels.selectedFrog.frogData.disciplinBase == levels.selectedFrog.currentFrogSO.disciplinIncreaseAmount)
                        {
                            tracker.sprite = oneFour;
                            tracker.GetComponentInParent<Button>().interactable = true;
                            tracker.color = colorol;
                        }
                        else if (levels.selectedFrog.frogData.GetDisciplin() - levels.selectedFrog.frogData.disciplinBase == (levels.selectedFrog.currentFrogSO.disciplinIncreaseAmount * 2))
                        {
                            tracker.sprite = halfFour;
                            tracker.GetComponentInParent<Button>().interactable = true;
                            tracker.color = colorol;
                        }
                        else if (levels.selectedFrog.frogData.GetDisciplin() - levels.selectedFrog.frogData.disciplinBase == (levels.selectedFrog.currentFrogSO.disciplinIncreaseAmount * 3))
                        {
                            tracker.sprite = threeFour;
                            tracker.GetComponentInParent<Button>().interactable = true;
                            tracker.color = colorol;
                        }
                        else if (levels.selectedFrog.frogData.GetDisciplin() - levels.selectedFrog.frogData.disciplinBase == (levels.selectedFrog.currentFrogSO.disciplinIncreaseAmount * 4))
                        {
                            tracker.sprite = fullFour;
                            tracker.GetComponentInParent<Button>().interactable = false;
                            tracker.color = colorol;
                        }
                        break;
                    default:

                        break;
                }
                break;
            case "Damage":
                switch (levels.selectedFrog.currentFrogSO.maxAmountUpgradeDamage)
                {
                    case 0:
                        tracker.GetComponentInParent<Button>().interactable = false;
                        tracker.color = colour;
                        break;
                    case 1:
                        if (levels.selectedFrog.frogData.GetDamage() - levels.selectedFrog.frogData.damageBase == 0)
                        {
                            tracker.sprite = emptyOne;
                            tracker.GetComponentInParent<Button>().interactable = true;
                            tracker.color = colorol;
                        }
                        else if (levels.selectedFrog.frogData.GetDamage() - levels.selectedFrog.frogData.damageBase == levels.selectedFrog.currentFrogSO.damageIncreaseAmount)
                        {
                            tracker.sprite = fullOne;
                            tracker.GetComponentInParent<Button>().interactable = false;
                            tracker.color = colorol;
                        }
                        break;
                    case 2:
                        if (levels.selectedFrog.frogData.GetDamage() - levels.selectedFrog.frogData.damageBase == 0)
                        {
                            tracker.sprite = emptyTwo;
                            tracker.GetComponentInParent<Button>().interactable = true;
                            tracker.color = colorol;
                        }
                        else if (levels.selectedFrog.frogData.GetDamage() - levels.selectedFrog.frogData.damageBase == levels.selectedFrog.currentFrogSO.damageIncreaseAmount)
                        {
                            tracker.sprite = halfTwo;
                            tracker.GetComponentInParent<Button>().interactable = true;
                            tracker.color = colorol;
                        }
                        else if (levels.selectedFrog.frogData.GetDamage() - levels.selectedFrog.frogData.damageBase == (levels.selectedFrog.currentFrogSO.damageIncreaseAmount * 2))
                        {
                            tracker.sprite = fullTwo;
                            tracker.GetComponentInParent<Button>().interactable = false;
                            tracker.color = colorol;
                        }
                        break;
                    case 3:
                        if (levels.selectedFrog.frogData.GetDamage() - levels.selectedFrog.frogData.damageBase == 0)
                        {
                            tracker.sprite = emptyThree;
                            tracker.GetComponentInParent<Button>().interactable = true;
                            tracker.color = colorol;
                        }
                        else if (levels.selectedFrog.frogData.GetDamage() - levels.selectedFrog.frogData.damageBase == levels.selectedFrog.currentFrogSO.damageIncreaseAmount)
                        {
                            tracker.sprite = oneThree;
                            tracker.GetComponentInParent<Button>().interactable = true;
                            tracker.color = colorol;
                        }
                        else if (levels.selectedFrog.frogData.GetDamage() - levels.selectedFrog.frogData.damageBase == (levels.selectedFrog.currentFrogSO.damageIncreaseAmount * 2))
                        {
                            tracker.sprite = twoThree;
                            tracker.GetComponentInParent<Button>().interactable = true;
                            tracker.color = colorol;
                        }
                        else if (levels.selectedFrog.frogData.GetDamage() - levels.selectedFrog.frogData.damageBase == (levels.selectedFrog.currentFrogSO.damageIncreaseAmount * 3))
                        {
                            tracker.sprite = fullThree;
                            tracker.GetComponentInParent<Button>().interactable = false;
                            tracker.color = colorol;
                        }
                        break;
                    case 4:
                        if (levels.selectedFrog.frogData.GetDamage() - levels.selectedFrog.frogData.damageBase == 0)
                        {
                            tracker.sprite = emptyFour;
                            tracker.GetComponentInParent<Button>().interactable = true;
                            tracker.color = colorol;
                        }
                        else if (levels.selectedFrog.frogData.GetDamage() - levels.selectedFrog.frogData.damageBase == levels.selectedFrog.currentFrogSO.damageIncreaseAmount)
                        {
                            tracker.sprite = oneFour;
                            tracker.GetComponentInParent<Button>().interactable = true;
                            tracker.color = colorol;
                        }
                        else if (levels.selectedFrog.frogData.GetDamage() - levels.selectedFrog.frogData.damageBase == (levels.selectedFrog.currentFrogSO.damageIncreaseAmount * 2))
                        {
                            tracker.sprite = halfFour;
                            tracker.GetComponentInParent<Button>().interactable = true;
                            tracker.color = colorol;
                        }
                        else if (levels.selectedFrog.frogData.GetDamage() - levels.selectedFrog.frogData.damageBase == (levels.selectedFrog.currentFrogSO.damageIncreaseAmount * 3))
                        {
                            tracker.sprite = threeFour;
                            tracker.GetComponentInParent<Button>().interactable = true;
                            tracker.color = colorol;
                        }
                        else if (levels.selectedFrog.frogData.GetDamage() - levels.selectedFrog.frogData.damageBase == (levels.selectedFrog.currentFrogSO.damageIncreaseAmount * 4))
                        {
                            tracker.sprite = fullFour;
                            tracker.GetComponentInParent<Button>().interactable = false;
                            tracker.color = colorol;
                        }
                        break;
                    default:

                        break;
                }
                break;
            case "Fire Rate":
                switch (levels.selectedFrog.currentFrogSO.maxAmountUpgradeFireRate)
                {
                    case 0:
                        tracker.GetComponentInParent<Button>().interactable = false;
                        tracker.color = colour;
                        break;
                    case 1:
                        if (levels.selectedFrog.frogData.GetFireRate() - levels.selectedFrog.frogData.fireRateBase == 0)
                        {
                            tracker.sprite = emptyOne;
                            tracker.GetComponentInParent<Button>().interactable = true;
                            tracker.color = colorol;
                        }
                        else if (levels.selectedFrog.frogData.GetFireRate() - levels.selectedFrog.frogData.fireRateBase == levels.selectedFrog.currentFrogSO.fireRateIncreaseAmount)
                        {
                            tracker.sprite = fullOne;
                            tracker.GetComponentInParent<Button>().interactable = false;
                            tracker.color = colorol;
                        }
                        break;
                    case 2:
                        if (levels.selectedFrog.frogData.GetFireRate() - levels.selectedFrog.frogData.fireRateBase == 0)
                        {
                            tracker.sprite = emptyTwo;
                            tracker.GetComponentInParent<Button>().interactable = true;
                            tracker.color = colorol;
                        }
                        else if (levels.selectedFrog.frogData.GetFireRate() - levels.selectedFrog.frogData.fireRateBase == levels.selectedFrog.currentFrogSO.fireRateIncreaseAmount)
                        {
                            tracker.sprite = halfTwo;
                            tracker.GetComponentInParent<Button>().interactable = true;
                            tracker.color = colorol;
                        }
                        else if (levels.selectedFrog.frogData.GetFireRate() - levels.selectedFrog.frogData.fireRateBase == (levels.selectedFrog.currentFrogSO.fireRateIncreaseAmount * 2))
                        {
                            tracker.sprite = fullTwo;
                            tracker.GetComponentInParent<Button>().interactable = false;
                            tracker.color = colorol;
                        }
                        break;
                    case 3:
                        if (levels.selectedFrog.frogData.GetFireRate() - levels.selectedFrog.frogData.fireRateBase == 0)
                        {
                            tracker.sprite = emptyThree;
                            tracker.GetComponentInParent<Button>().interactable = true;
                            tracker.color = colorol;
                        }
                        else if (levels.selectedFrog.frogData.GetFireRate() - levels.selectedFrog.frogData.fireRateBase == levels.selectedFrog.currentFrogSO.fireRateIncreaseAmount)
                        {
                            tracker.sprite = oneThree;
                            tracker.GetComponentInParent<Button>().interactable = true;
                            tracker.color = colorol;
                        }
                        else if (levels.selectedFrog.frogData.GetFireRate() - levels.selectedFrog.frogData.fireRateBase == (levels.selectedFrog.currentFrogSO.fireRateIncreaseAmount * 2))
                        {
                            tracker.sprite = twoThree;
                            tracker.GetComponentInParent<Button>().interactable = true;
                            tracker.color = colorol;
                        }
                        else if (levels.selectedFrog.frogData.GetFireRate() - levels.selectedFrog.frogData.fireRateBase == (levels.selectedFrog.currentFrogSO.fireRateIncreaseAmount * 3))
                        {
                            tracker.sprite = fullThree;
                            tracker.GetComponentInParent<Button>().interactable = false;
                            tracker.color = colorol;
                        }
                        break;
                    case 4:
                        if (levels.selectedFrog.frogData.GetFireRate() - levels.selectedFrog.frogData.fireRateBase == 0)
                        {
                            tracker.sprite = emptyFour;
                            tracker.GetComponentInParent<Button>().interactable = true;
                            tracker.color = colorol;
                        }
                        else if (levels.selectedFrog.frogData.GetFireRate() - levels.selectedFrog.frogData.fireRateBase == levels.selectedFrog.currentFrogSO.fireRateIncreaseAmount)
                        {
                            tracker.sprite = oneFour;
                            tracker.GetComponentInParent<Button>().interactable = true;
                            tracker.color = colorol;
                        }
                        else if (levels.selectedFrog.frogData.GetFireRate() - levels.selectedFrog.frogData.fireRateBase == (levels.selectedFrog.currentFrogSO.fireRateIncreaseAmount * 2))
                        {
                            tracker.sprite = halfFour;
                            tracker.GetComponentInParent<Button>().interactable = true;
                            tracker.color = colorol;
                        }
                        else if (levels.selectedFrog.frogData.GetFireRate() - levels.selectedFrog.frogData.fireRateBase == (levels.selectedFrog.currentFrogSO.fireRateIncreaseAmount * 3))
                        {
                            tracker.sprite = threeFour;
                            tracker.GetComponentInParent<Button>().interactable = true;
                            tracker.color = colorol;
                        }
                        else if (levels.selectedFrog.frogData.GetFireRate() - levels.selectedFrog.frogData.fireRateBase == (levels.selectedFrog.currentFrogSO.fireRateIncreaseAmount * 4))
                        {
                            tracker.sprite = fullFour;
                            tracker.GetComponentInParent<Button>().interactable = false;
                            tracker.color = colorol;
                        }
                        break;
                    default:

                        break;
                }
                break;
            case "Range":
                switch (levels.selectedFrog.currentFrogSO.maxAmountUpgradeRange)
                {
                    case 0:
                        tracker.GetComponentInParent<Button>().interactable = false;
                        tracker.color = colour;
                        break;
                    case 1:
                        if (levels.selectedFrog.frogData.GetRange() - levels.selectedFrog.frogData.rangeBase == 0)
                        {
                            tracker.sprite = emptyOne;
                            tracker.GetComponentInParent<Button>().interactable = true;
                            tracker.color = colorol;
                        }
                        else if (levels.selectedFrog.frogData.GetRange() - levels.selectedFrog.frogData.rangeBase == levels.selectedFrog.currentFrogSO.rangeIncreaseAmount)
                        {
                            tracker.sprite = fullOne;
                            tracker.GetComponentInParent<Button>().interactable = false;
                            tracker.color = colorol;
                        }
                        break;
                    case 2:
                        if (levels.selectedFrog.frogData.GetRange() - levels.selectedFrog.frogData.rangeBase == 0)
                        {
                            tracker.sprite = emptyTwo;
                            tracker.GetComponentInParent<Button>().interactable = true;
                            tracker.color = colorol;
                        }
                        else if (levels.selectedFrog.frogData.GetRange() - levels.selectedFrog.frogData.rangeBase == levels.selectedFrog.currentFrogSO.rangeIncreaseAmount)
                        {
                            tracker.sprite = halfTwo;
                            tracker.GetComponentInParent<Button>().interactable = true;
                            tracker.color = colorol;
                        }
                        else if (levels.selectedFrog.frogData.GetRange() - levels.selectedFrog.frogData.rangeBase == (levels.selectedFrog.currentFrogSO.rangeIncreaseAmount * 2))
                        {
                            tracker.sprite = fullTwo;
                            tracker.GetComponentInParent<Button>().interactable = false;
                            tracker.color = colorol;
                        }
                        break;
                    case 3:
                        if (levels.selectedFrog.frogData.GetRange() - levels.selectedFrog.frogData.rangeBase == 0)
                        {
                            tracker.sprite = emptyThree;
                            tracker.GetComponentInParent<Button>().interactable = true;
                            tracker.color = colorol;
                        }
                        else if (levels.selectedFrog.frogData.GetRange() - levels.selectedFrog.frogData.rangeBase == levels.selectedFrog.currentFrogSO.rangeIncreaseAmount)
                        {
                            tracker.sprite = oneThree;
                            tracker.GetComponentInParent<Button>().interactable = true;
                            tracker.color = colorol;
                        }
                        else if (levels.selectedFrog.frogData.GetRange() - levels.selectedFrog.frogData.rangeBase == (levels.selectedFrog.currentFrogSO.rangeIncreaseAmount * 2))
                        {
                            tracker.sprite = twoThree;
                            tracker.GetComponentInParent<Button>().interactable = true;
                            tracker.color = colorol;
                        }
                        else if (levels.selectedFrog.frogData.GetRange() - levels.selectedFrog.frogData.rangeBase == (levels.selectedFrog.currentFrogSO.rangeIncreaseAmount * 3))
                        {
                            tracker.sprite = fullThree;
                            tracker.GetComponentInParent<Button>().interactable = false;
                            tracker.color = colorol;
                        }
                        break;
                    case 4:
                        if (levels.selectedFrog.frogData.GetRange() - levels.selectedFrog.frogData.rangeBase == 0)
                        {
                            tracker.sprite = emptyFour;
                            tracker.GetComponentInParent<Button>().interactable = true;
                            tracker.color = colorol;
                        }
                        else if (levels.selectedFrog.frogData.GetRange() - levels.selectedFrog.frogData.rangeBase == levels.selectedFrog.currentFrogSO.rangeIncreaseAmount)
                        {
                            tracker.sprite = oneFour;
                            tracker.GetComponentInParent<Button>().interactable = true;
                            tracker.color = colorol;
                        }
                        else if (levels.selectedFrog.frogData.GetRange() - levels.selectedFrog.frogData.rangeBase == (levels.selectedFrog.currentFrogSO.rangeIncreaseAmount * 2))
                        {
                            tracker.sprite = halfFour;
                            tracker.GetComponentInParent<Button>().interactable = true;
                            tracker.color = colorol;
                        }
                        else if (levels.selectedFrog.frogData.GetRange() - levels.selectedFrog.frogData.rangeBase == (levels.selectedFrog.currentFrogSO.rangeIncreaseAmount * 3))
                        {
                            tracker.sprite = threeFour;
                            tracker.GetComponentInParent<Button>().interactable = true;
                            tracker.color = colorol;
                        }
                        else if (levels.selectedFrog.frogData.GetRange() - levels.selectedFrog.frogData.rangeBase == (levels.selectedFrog.currentFrogSO.rangeIncreaseAmount * 4))
                        {
                            tracker.sprite = fullFour;
                            tracker.GetComponentInParent<Button>().interactable = false;
                            tracker.color = colorol;
                        }
                        break;
                    default:

                        break;
                }
                break;
            default:
                break;
        }
    }
}
