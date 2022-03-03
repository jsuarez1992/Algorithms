namespace Exercise001
{
    using System.Collections.Generic;
    public class Connectivity
    {
        public int n;
        public List<int> [] graph;

        public List<int> visitedList;

        public Connectivity(int n)
        {
            this.n = n;
            this.graph = new List<int> [n + 1];
            this.visitedList = new List<int>();
            for (int i = 1; i <= n; i++)
            {
                graph[i] = new List<int>();
            }
        }

        public void AddConnection(int a, int b)
        {
           this.graph[a].Add(b);
           this.graph[b].Add(a);
        }

        public int Calculate(int x)
        {
            if (visitedList.Contains(x))
            {
                return 0;
            }
            visitedList.Add(x);

            foreach(int i in graph[x])
            {
                Calculate(i);
            }
            return visitedList.Count -1;
        }
    }
}
