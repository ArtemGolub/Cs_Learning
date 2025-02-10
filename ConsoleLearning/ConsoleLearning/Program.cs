using ConsoleLearning.Interfaces;

Redoable r = new Redoable();
r.Do();
((IRedoable)r).Do();
((IUndoable)r).Do();