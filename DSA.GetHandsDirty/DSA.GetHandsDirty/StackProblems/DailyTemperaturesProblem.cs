namespace DSA.GetHandsDirty.StackProblems;

/// <summary>
/// LeetCode 739 -
/// Usar a stack como uma fila de processamento
/// </summary>
public class DailyTemperaturesProblem
{
    public int[] DailyTemperatures(int[] temperatures)
    {
        int[] daysToWarmerTemp = new int[temperatures.Length];
        Stack<int> stack = new Stack<int>();
        
        for (int i = 0; i < temperatures.Length; i++) // Verificar em sequencia cada temparatura
        {
            while (stack.Count > 0 && temperatures[stack.Peek()] < temperatures[i]) // Verifica se a temperatura aumentou: Se a última armazenada na stack é menor que a temperatura atual
            {
                int index = stack.Pop();
                daysToWarmerTemp[index] = i - index; // Verifica quanto tempo levou para elevar a temperatura
            }
            
            stack.Push(i); // Guardar a posição da temperatura que ainda não possui uma mais elevada 
        }

        return daysToWarmerTemp;
    }
}