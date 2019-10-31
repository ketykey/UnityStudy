using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text Description;
    public Button[] OptionsButtons;

    public StoryItemBase CurrentItem;

    private int _numButtons;
    private Text[] _buttonTexts;
    private string[] _optionTexts;
    private StoryItemBase[] _optionItems;
    void Start()
    {
        _numButtons = OptionsButtons.GetLength(0);
        GetButtonTexts();
        CurrentItem.Activate(this);
    }

    private void GetButtonTexts() {
        _buttonTexts = new Text[_numButtons];
        for (int i = 0; i < _numButtons; i++) {
            _buttonTexts[i] = OptionsButtons[i].GetComponentInChildren<Text>(true);
        }
    }

    public void SetCurrentStoryItem(StoryItemBase item) {
        CurrentItem = item;
        CurrentItem.Activate(this);
    }

    public void OnMouseUpAsButton(int index) 
    {
        SetCurrentStoryItem(_optionItems[index]);
    }

    public void SetCardDetails(string desc, string[] optionTexts, StoryItemBase[] optionItems) {
        Description.text = desc;
        _optionTexts = optionTexts;
        _optionItems = optionItems;

        UpdateButtons();
    }

    public void UpdateButtons() {
        int numOptionTexts = _optionTexts == null ? 0 : _optionTexts.GetLength(0);
        int numOptionItems = _optionItems == null ? 0 : _optionItems.GetLength(0);
        int numActiveButtons = Math.Min(numOptionItems, numOptionTexts);
        for (int i = 0; i < _numButtons; i++) {
            if (i < numActiveButtons)
            {
                OptionsButtons[i].gameObject.SetActive(true);
                _buttonTexts[i].text = _optionTexts[i];
            }
            else {
                OptionsButtons[i].gameObject.SetActive(false);
            }
        }
    }
}
