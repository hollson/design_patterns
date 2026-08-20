// 备忘录模式示例：文本编辑器撤销/重做功能

var editor = new Editor();
var history = new History();

// 编辑操作
editor.Type("Hello ");
history.Push(editor.CreateMemento());

editor.Type("World ");
history.Push(editor.CreateMemento());

editor.Type("!");
Console.WriteLine($"当前内容: {editor.GetContent()}\n");

// 撤销操作
Console.WriteLine("--- 撤销操作 ---");
editor.Restore(history.Pop());
Console.WriteLine($"撤销后: {editor.GetContent()}\n");

editor.Restore(history.Pop());
Console.WriteLine($"再次撤销: {editor.GetContent()}");
