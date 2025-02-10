namespace ConsoleLearning.Interfaces;

public interface IRedoable: IUndoable
{ 
    void Do();
}