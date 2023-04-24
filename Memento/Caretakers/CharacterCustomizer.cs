using Memento.Mementos;
using Memento.Originators;

namespace Memento.Caretakers;

public class CharacterCustomizer
{
    private readonly Character _character;
    private readonly Stack<CharacterStateSnapshot> _previousStates = new();

    public CharacterCustomizer(Character character)
    {
        _character = character;
        _previousStates.Push(character.CreateSnapshot());
    }

    public void SaveCharacterState()
    {
        _previousStates.Push(_character.CreateSnapshot());
    }

    public void Customize(Action<Character>? customizationOperation)
    {
        customizationOperation?.Invoke(_character);
    }

    public void UndoLastState()
    {
        var previousState = _previousStates.Count == 1 ? _previousStates.Peek() : _previousStates.Pop();
        _character.RestoreFromSnapshot(previousState);
    }
}