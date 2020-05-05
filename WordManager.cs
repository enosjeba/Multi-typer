using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordManager : MonoBehaviour
{
    public int Score = 0;


    public List<Word> words;

    public WordSpwaner wordSpwaner;

    private bool hasActiveWord;
    private Word activeWord;

    
    public void AddWord()
    {
        
        Word word = new Word(WordGenerator.GetRandomWord(), wordSpwaner.SpawnWord());
        Debug.Log(word.word);

        words.Add(word);
    }
   
    public void TypeLetter(char letter)
    {
        if (hasActiveWord)
        {
            // Check if letter was rhe next letter
                // remove it from the word
            if (activeWord.GetNextLetter() == letter)
            {
                activeWord.TypeLetter();
            }
            
        } else
        {
            foreach (Word word in words)
            {
                if (word.GetNextLetter() == letter)
                {
                    activeWord = word;
                    hasActiveWord = true;
                    word.TypeLetter();
                    break;
                }
            }
        }
        if (hasActiveWord && activeWord.WordTyped())
        {
            hasActiveWord = false;
            words.Remove(activeWord);
            Score = Score + 1;
            Debug.Log(Score);
        }
    }
}

