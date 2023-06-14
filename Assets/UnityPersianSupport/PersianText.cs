using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using UnityPersianSupport;

[AddComponentMenu("UI/PersianText", 11)]
[ExecuteInEditMode]
public class PersianText : Text
{
    [SerializeField]
    [TextArea(3, 10)]
    public string rawText;

    private RectTransform _rectTransform;

    protected override void OnEnable()
    {
        SetText();
        base.OnEnable();
    }

    protected override void OnValidate()
    {
        SetText();
        base.OnValidate();
    }

    protected override void OnRectTransformDimensionsChange()
    {
        SetText();
        base.OnRectTransformDimensionsChange();
    }

    public void SetText(string text = "") 
    {
        if (_rectTransform == null)
            _rectTransform = GetComponent<RectTransform>();

        string output = "";

        if (!string.IsNullOrEmpty(text))
            rawText = text;

        output = PersianFixer.FixText(rawText);

        TextGenerationSettings setting = GetGenerationSettings(new Vector2(_rectTransform.rect.width, _rectTransform.rect.height));
        cachedTextGeneratorForLayout.Populate(output, setting);

        float width = _rectTransform.rect.width;
        float usedWidth = cachedTextGeneratorForLayout.GetPreferredWidth(output, setting);
        int lineCount = (int)(usedWidth / width) + 1;
        UICharInfo[] info = cachedTextGeneratorForLayout.GetCharactersArray();

        float jomleLength = 0;
        int charCounter = info.Length;
        List<string> strings = new List<string>();

        for (int i = 1; i < lineCount; i++)
        {
            while (width * i > jomleLength)
            {
                jomleLength += info[--charCounter].charWidth;
            }

            int spaceIndex = charCounter;
            for (; charCounter < info.Length - 1; charCounter++)
            {
                if (output[charCounter] == ' ')
                {
                    spaceIndex = charCounter;
                    break;
                }
            }

            charCounter = spaceIndex;

            int endIndex = output.Length - spaceIndex;

            strings.Add(output.Substring(spaceIndex, endIndex));
            output = output.Remove(spaceIndex, endIndex);
        }

        strings.Add(output);

        string result = "";

        for (int i = 0; i < strings.Count;)
        {
            result += strings[i];
            i++;
            if (i < strings.Count)
                result += '\u000A';
        }

        this.text = result;
    }
}