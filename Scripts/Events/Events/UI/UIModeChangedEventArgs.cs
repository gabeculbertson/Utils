using UnityEngine;
using System.Collections;

public enum UIMode {
    Exploring,
    Speaking,
    FixedPhraseInput
}

public class UIModeChangedEventArgs : System.EventArgs {

    public UIMode Mode { get; set; }

    public UIModeChangedEventArgs(UIMode mode)
    {
        this.Mode = mode;
    }

}
