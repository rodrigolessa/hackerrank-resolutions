using System;
using System.Collections.Generic;

namespace DSA.MyDataStructures;

public class Graph<T> where T : notnull
{
    private readonly Dictionary<T, HashSet<T>> _adjacencyList;
    public bool IsDirected { get; }

    public Graph(bool isDirected = false)
    {
        IsDirected = isDirected;
        _adjacencyList = new Dictionary<T, HashSet<T>>();
    }

    public void AddVertex(T vertex)
    {
        if (!_adjacencyList.ContainsKey(vertex))
        {
            _adjacencyList[vertex] = new HashSet<T>();
        }
    }

    public void AddEdge(T from, T to)
    {
        AddVertex(from);
        AddVertex(to);

        _adjacencyList[from].Add(to);

        if (!IsDirected)
        {
            _adjacencyList[to].Add(from);
        }
    }

    public bool HasEdge(T from, T to)
    {
        return _adjacencyList.ContainsKey(from) && _adjacencyList[from].Contains(to);
    }

    public IEnumerable<T> GetNeighbors(T vertex)
    {
        return _adjacencyList.TryGetValue(vertex, out var neighbors) ? neighbors : Array.Empty<T>();
    }

    public void RemoveEdge(T from, T to)
    {
        if (_adjacencyList.ContainsKey(from))
            _adjacencyList[from].Remove(to);

        if (!IsDirected && _adjacencyList.ContainsKey(to))
            _adjacencyList[to].Remove(from);
    }

    public void RemoveVertex(T vertex)
    {
        if (!_adjacencyList.ContainsKey(vertex))
            return;

        _adjacencyList.Remove(vertex);

        foreach (var neighbors in _adjacencyList.Values)
        {
            neighbors.Remove(vertex);
        }
    }

    public void PrintGraph()
    {
        foreach (var vertex in _adjacencyList)
        {
            Console.Write($"{vertex.Key}: ");
            Console.WriteLine(string.Join(", ", vertex.Value));
        }
    }
}