namespace Exercise002
{
    using System.Collections.Generic;
    public class Components
    {
        public int n;
        public List<int>[] graph;
        public Components(int n)
        {
            this.n = n;
            this.graph = new List<int> [n + 1];

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

        public int Calculate()
        {
            int sum = 0;
            int search = 1;
            bool[] visited = new bool[n];

            foreach (bool i in visited)
            {
                if (i == false)
                {
                    Search(search, visited);
                    sum++;
                }
                search++;
            }
           return sum;
        }

        public void Search(int x, bool[] visited)
        {
            if (visited[x -1] == true)
            {
                return;
            }

            visited[x - 1] = true;

            foreach (int i in graph[x])
            {
                Search(i, visited);
            }
        }

    }
}
