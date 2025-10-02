using DSA.MyDataStructures;

namespace DSA.GetHandsDirty.GraphProblems;

public class Dijkstra
{
    public Dictionary<string, int> FindShortestDistance(
        Dictionary<string, List<(string name, int distance)>>? locations, string startPointName)
    {
        if (locations is null)
            return new Dictionary<string, int>();

        // Iniciar todas as distâncias entre localizações com o máximo possível
        Dictionary<string, int> distances = locations
            .Keys.ToDictionary(locationName => locationName, locationName => int.MaxValue);
        // Do ponto que iniciamos a distância será sempre zero
        distances[startPointName] = 0;

        PriorityQueue<string, int> toVisit = new PriorityQueue<string, int>();
        // Inicia a visita com o ponto de início
        toVisit.Enqueue(startPointName, 0);

        while (toVisit.Count > 0)
        {
            string currentLocation = toVisit.Dequeue();
            int currentDistance = distances[currentLocation];
            foreach (var (neighbor, distance) in locations[currentLocation])
            {
                // Soma a distância que eu já percorri com a distância para o próximo vizinho
                int newNeighborDistance = currentDistance + distance;
                // Se for maior, posso desconsiderar
                if (newNeighborDistance > distances[neighbor])
                    continue;

                // Se for menor, esse é o melhor caminho até o momento
                distances[neighbor] = newNeighborDistance;
                // Por qual motivo adicionar a nova distância se não uso no código?
                // R: Por ser uma priority queue, isso joga o vizinho (com a menor distância) para o início da fila
                // e assim, torna mais otimizada a busca por um caminho menor
                toVisit.Enqueue(neighbor, newNeighborDistance);
            }
        }

        return distances;
    }
}