// 迭代器模式：顺序访问集合元素，而不暴露内部表示

using IteratorPattern;

Console.WriteLine("========== 迭代器模式 (Iterator Pattern) ==========");
Console.WriteLine("顺序访问集合元素，而不暴露内部表示\n");

Console.WriteLine("--- 经典场景: 音乐节歌单（手写迭代器） ---");

// 聚合内部是数组，客户端只拿到迭代器，全程无感知
var playlist = new Playlist(
[
    new("晴天", "周杰伦", "4:29"),
    new("海阔天空", "Beyond", "5:24"),
    new("平凡之路", "朴树", "5:01"),
    new("夜空中最亮的星", "逃跑计划", "4:12"),
]);

Console.WriteLine(">> foreach 遍历歌单：");
int total = playlist.Count();
int i = 1;
foreach (var song in playlist)
    Console.WriteLine($"[{i++}/{total}] {song.Title} — {song.Artist}（{song.Duration}）");

Console.WriteLine("\n>> 手写等价写法（foreach 的真身 = MoveNext + Current）：");
using var enumerator = playlist.GetEnumerator();
while (enumerator.MoveNext())
    Console.WriteLine($"  · {enumerator.Current.Title} — {enumerator.Current.Artist}");

Console.WriteLine("\n--- 软件项目: 浏览器历史（yield 现代写法） ---");

var history = new BrowserHistory();
history.Visit("github.com", "stackoverflow.com", "nuget.org", "learn.microsoft.com");

Console.WriteLine(">> 正序遍历（yield GetEnumerator）：");
foreach (var url in history)
    Console.WriteLine($"  {url}");

Console.WriteLine("\n>> 倒序遍历（GetRecentFirst，最近优先）：");
foreach (var url in history.GetRecentFirst())
    Console.WriteLine($"  {url}");

Console.WriteLine("\n>> 只看最近 2 条（GetRecent）：");
foreach (var url in history.GetRecent(2))
    Console.WriteLine($"  {url}");
