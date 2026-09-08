using System.Collections;

namespace IteratorPattern;

/// <summary>歌单迭代器（手写版）：foreach 背后的真实机制</summary>
public class PlaylistEnumerator : IEnumerator<Song>
{
    private readonly Song[] _tracks;
    private int _cursor = -1;               // 游标起点在第一首之前

    public PlaylistEnumerator(Song[] tracks) => _tracks = tracks;

    public Song Current => _cursor >= 0 && _cursor < _tracks.Length
        ? _tracks[_cursor]
        : throw new InvalidOperationException("游标越界");

    object IEnumerator.Current => Current;  // 非泛型兼容

    /// <summary>前进到下一首：false 表示歌单播完</summary>
    public bool MoveNext() => ++_cursor < _tracks.Length;

    /// <summary>回到起点，可再次遍历</summary>
    public void Reset() => _cursor = -1;

    public void Dispose() { }               // 无非托管资源，空实现
}
