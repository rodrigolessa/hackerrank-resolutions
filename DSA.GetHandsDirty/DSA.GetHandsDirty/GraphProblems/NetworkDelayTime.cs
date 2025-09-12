namespace DSA.GetHandsDirty.GraphProblems;

/// <summary>
/// LeetCode 743
/// https://leetcode.com/problems/network-delay-time/description/?envType=problem-list-v2&envId=shortest-path
/// </summary>
public class NetworkDelayTime
{
    /// <summary>
    /// Partindo de um nó específico, quanto tempo leva para percorrer a quantidade de nós indicada
    /// Solve using dijkstra
    /// </summary>
    /// <param name="times">
    /// Matrix [[2,1,1]] where positions are: source node, target node and the time it takes for signal travel from source to target
    /// times[i] = (u, v, w) → signal travels from u → v in w time.
    /// </param>
    /// <param name="n">nodes quantity - quantidade de nós que deve ser percorrida no menor tempo</param>
    /// <param name="k">start point - início</param>
    /// <returns></returns>
    public int FindTheMinimumTime(int[][] times, int n, int k)
    {
        // Converte a entrada para uma estrutura semelhante ao que conheço de Dijkstra
        Dictionary<int, List<(int neighbor, int time)>> networkMap =
            new Dictionary<int, List<(int neighbor, int time)>>();
        // Criar uma referência para cada nó da rede com uma lista de vizinhos vazia
        for (int i = 1; i <= n; i++)
            // Inicia por 1 pois corresponde ao código do nó
            networkMap.TryAdd(i, new List<(int neighbor, int time)>());

        // Insere todos os vizinhos conhecidos
        foreach (var time in times)
        {
            networkMap[time[0]].Add((time[1], time[2]));
        }

        // Estrutura de controle para guardar o menor tempo encontrado
        Dictionary<int, int> minTimeList = new Dictionary<int, int>();
        for (int i = 1; i <= n; i++)
            minTimeList.TryAdd(i, int.MaxValue);
        minTimeList[k] = 0; // The distance from start position is always zero

        // Estrutura para controle dos nós que precisamos visitar
        PriorityQueue<int, int> toVisit = new PriorityQueue<int, int>();
        toVisit.Enqueue(k, 0);

        while (toVisit.Count > 0)
        {
            // Retira da lista o nó com maior prioridade/menor tempo
            int currentNode = toVisit.Dequeue();
            // Busca o menor tempo já encontrado
            int currentNodeTime = minTimeList[currentNode];
            foreach (var (neighbor, time) in networkMap[currentNode])
            {
                // Soma o tempo já gasto para percorrer os nós até esse ponto e soma com o tempo para chegar até o próximo vizinho
                int newTime = currentNodeTime + time;
                // Se for maior, posso desconsiderar
                if (newTime > minTimeList[neighbor])
                    continue;
                
                minTimeList[neighbor] = newTime;
                toVisit.Enqueue(neighbor, newTime);
            }
        }

        int max = -1;
        foreach (var time in minTimeList.Values)
        {
            if (time == int.MaxValue) return -1;
            max = Math.Max(max, time);
        }

        return max;
    }
}