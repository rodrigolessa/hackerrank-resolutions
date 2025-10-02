using DSA.GetHandsDirty.LinkedListProblems.TextEditorUndoFunction;

namespace DSA.GetHandsDirty.UnitTests.LinkedListProblems;

public class MyTextEditorTests
{
    [Fact]
    public void Redo_GivenFourValidInputs_WhenIExecuteTheUndoTwoTimesAndOneRedo_ShouldReturnThePenultimaUpdate()
    {
        var editor = new MyTextEditor();

        editor.WriteText("System");
        editor.WriteText(" design");
        editor.WriteText(" interview");
        editor.WriteText(" task");

        editor.GetContent().ShouldBe("System design interview task");

        editor.Undo();
        editor.GetContent().ShouldBe("System design interview");

        editor.Undo();
        editor.GetContent().ShouldBe("System design");
        
        editor.Redo();
        editor.GetContent().ShouldBe("System design interview");
    }
}