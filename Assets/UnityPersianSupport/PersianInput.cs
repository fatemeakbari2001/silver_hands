using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityPersianSupport;

public class PersianInput : InputField
{
    public PersianText persianText;

    protected override void Start()
    {
        base.Start();

        onValueChange.AddListener((string text) =>
            {
                persianText.SetText(text);
            });
    }
}
