using System.Collections;

namespace IteratorPattern;

/// <summary>演出歌单（聚合）：内部用数组存储，外界只能通过迭代器遍历</summary>
public class Playlist : IEnumerable<Song>
{
    private readonly Song[] _tracks;        // 内部结构：数组，客户端无感知

    public Playlist(Song[] tracks) => _tracks = tracks;

    /// <summary>只交出迭代器，数组本身不暴露</summary>
    public IEnumerator<Song> GetEnumerator() => new PlaylistEnumerator(_tracks);

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();     // 非泛型兼容
}
