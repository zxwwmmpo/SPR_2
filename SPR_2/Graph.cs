using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPR_2;

public class Graph
{    
    private int vertices;
    private List<int>[] adj;

    public Graph(int vertices)
    {        
        this.vertices = vertices;
        adj = new List<int>[vertices];
        
        for (int i = 0; i < vertices; i++)
        {
            adj[i] = new List<int>();
        }
    }

    public void Add(int vertex, int weight)
    {
        adj[vertex].Add(weight);
    }

    public void Helper(int vertex, bool[] visited)
    {
        visited[vertex] = true;
        foreach (int item in adj[vertex])
        {
            if (!visited[item])
            {
                Helper(item, visited);
            }
        }
    }

    public void BFS(int startPosition)
    {
        bool[] visited = new bool[vertices];
        Helper(1, visited);
    }
}
