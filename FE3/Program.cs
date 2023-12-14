using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FE3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //represent the diagraph as matrix and list #3
            //vertices of digraph
            string[] vertices = { "red", "blue", "lightblue", "grey", "orange", "purple", "yellow", "green" };

            //adjacency matrix
            int[,] adjacencyM =
            {
                //red blue lightblue grey orange purple yellow green
                {0, 1, 0, 5, 0, 0, 0, 0 }, //red -> blue red to grey
                {0, 0, 1, 0, 0, 0, 8, 0 }, //blue -> lightblue blue -> ywllow
                {0, 1, 0, 0, 0, 0, 0, 0 }, //lightblue
                {0, 0, 1, 0, 1, 0, 0, 0 }, //grey
                {0, 0, 0, 0, 0, 1, 0, 0 }, //orange
                {0, 0, 0, 0, 0, 0, 1, 0 }, //prurple
                {0, 0, 0, 0, 0, 0, 0, 6 }, //yellow
                {0, 0, 0, 0, 0, 0, 0, 0 }, //green
            };

            //create adjacency list
            AdjacencyList adjacencyL = new AdjacencyList(vertices.Length);
            //red - 0 blue - 1 lightblue - 2 grey - 3 orange - 4 purple - 5 yellow - 6 green - 8
            //add edge (start, end, weight/distance)
            adjacencyL.AddEdge(0, 1, 1); //red -> blue
            adjacencyL.AddEdge(1, 6, 8); //blue -> yellow
            adjacencyL.AddEdge(6, 7, 6); //yellow -> green
            adjacencyL.AddEdge(1, 2, 1); //blue -> light blue
            adjacencyL.AddEdge(0, 3, 5); //red -> grey
            adjacencyL.AddEdge(2, 3, 0); //light blue -> grey
            adjacencyL.AddEdge(3, 4, 1); //grey -> orange
            adjacencyL.AddEdge(4, 5, 1); //orange -> purple
            adjacencyL.AddEdge(5, 6, 1); //purple -> yellow

            DepthFirstSearch(adjacencyL, 0, new bool[vertices.Length]);

        }

        //depth first seach #5
        static void DepthFirstSearch(AdjacencyList graph, int vertex, bool[] visited)
        {
            visited[vertex] = true; //boo; to mark when a vertex has been visited
            Console.WriteLine(graph.GetColor(vertex)); //output the color of the current vertex

            foreach (Tuple<int, int> neighbor in graph.GetNeighbors(vertex))
            {
                if (!visited[neighbor.Item1]) //chekck if a vertex has been visted
                {
                    DepthFirstSearch(graph, neighbor.Item1, visited); //recursively call for unvisited neighbors
                }
            }
        }

        class AdjacencyList
        {
            LinkedList<Tuple<int, int>>[] adjacencyList;
            string[] colors;

            //make an empty adj list
            public AdjacencyList(int vertices)
            {
                adjacencyList = new LinkedList<Tuple<int, int>>[vertices];
                colors = new string[vertices];

                for (int i = 0; i < adjacencyList.Length; i++)
                {
                    adjacencyList[i] = new LinkedList<Tuple<int, int>>();
                    colors[i] = "Color" + i.ToString();
                }
            }

            //add edges to the list
            public void AddEdge(int start, int end, int weight)
            {
                adjacencyList[start].AddLast(new Tuple<int, int>(end, weight));
            }

            //get the neighbors of each vertex
            public LinkedList<Tuple<int, int>> GetNeighbors(int vertex)
            {
                return adjacencyList[vertex];
            }

            //get the colors at each vertex
            public string GetColor(int vertex)
            {
                return colors[vertex];
            }
        }
    }
}
