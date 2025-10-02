using DSA.MyDataStructures;
using DSA.MyDataStructures.LeetCodeStructures;

namespace DSA.GetHandsDirty.LinkedListProblems;

/// <summary>
/// LeetCode 2 -
/// Para cada posição do array eu devo aplicar a formula somando o valor já encontrado
/// val1 += l1[i] * 10^i
/// ou soma = l1[i] + l2[i] + excedente da soma anterior
/// - então dividir por 10 para saber o quanto leva para frente
/// - o valor do nó é o módulo de 10 da soma
/// </summary>
public class AddTwoNumbersProblem
{
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        ListNode dummyHead = new ListNode(0);
        ListNode current = dummyHead;
        int carry = 0;

        while (l1 != null || l2 != null) {
            int x = (l1 != null) ? l1.val : 0;
            int y = (l2 != null) ? l2.val : 0;

            int sum = x + y + carry;
            carry = sum / 10;

            current.next = new ListNode(sum % 10);
            current = current.next;

            if (l1 != null) l1 = l1.next;
            if (l2 != null) l2 = l2.next;
        }

        if (carry > 0) {
            current.next = new ListNode(carry);
        }

        return dummyHead.next;
    }
}