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

    public void Add(int vertex, int dest)
    {
        adj[vertex].Add(dest);
    }

    public void Helper(int vertex, bool[] visited, List<int> res)
    {
        visited[vertex] = true;
        res.Add(vertex);
        foreach (int item in adj[vertex])
        {
            if (!visited[item])
            {
                Helper(item, visited, res);
            }
        }
    }

    public List<int> BFS(int startPosition)
    {
        List<int> res = new List<int>();
        bool[] visited = new bool[vertices];
        Helper(startPosition, visited, res);
        
        return res;
    }
}
