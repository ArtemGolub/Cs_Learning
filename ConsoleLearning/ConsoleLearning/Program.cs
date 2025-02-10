using ConsoleLearning.Interfaces;

RichTextBox r = new RichTextBox();
r.Undo();
((IUndoable)r).Undo();
((TextBox)r).Undo();