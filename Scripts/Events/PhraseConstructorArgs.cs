using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PhraseConstructorArgs {
    public string Help { get; set; }
    public PhraseSequence Phrase { get; set; }
    public List<PhraseSequence> EnteredPhrase { get; set; }
    public List<PhraseSequence> AvailableWords { get; set; }
    public ContextData Context { get; set; }
    public bool UseSlots { get; set; }
    public int EmptySlots { get; set; }

    public PhraseConstructorArgs(PhraseSequence phrase, List<PhraseSequence> availableWords) {
        this.Phrase = phrase;
        this.AvailableWords = availableWords;
        this.Help = "Say \"" + PlayerDataConnector.GetTranslation(phrase) + "\"";
        this.Context = new ContextData();
        this.EmptySlots = phrase.ComparableElementCount;
    }

    public PhraseConstructorArgs(PhraseSequence phrase, List<PhraseSequence> availableWords, int emptySlots)
        : this(phrase, availableWords) {
        this.EmptySlots = Mathf.Clamp(emptySlots, 0, phrase.ComparableElementCount);
    }

    public PhraseConstructorArgs(PhraseSequence phrase, List<PhraseSequence> availableWords, string help)
        : this(phrase, availableWords) {
        this.Help = help;
    }
}

