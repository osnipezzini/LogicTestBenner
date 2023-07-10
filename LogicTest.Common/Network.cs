namespace LogicTest.Common;

using System;

public class Network
{
    private int[] parent;
    private int networkLenght;

    public Network(int networkLenght)
    {
        if (networkLenght <= 0)
        {
            throw new ArgumentException("O número de redes deve ser positivo");
        }

        this.networkLenght = networkLenght;
        parent = new int[networkLenght];

        for (int i = 0; i < networkLenght; i++)
        {
            parent[i] = i;
        }
    }
    private void ValidateData(int source, int target)
    {
        if (source < 0 || source >= networkLenght || target < 0 || target >= networkLenght)
        {
            throw new ArgumentException($"O numero da rede deve ser maior que zero e não pode ser maior que {networkLenght} caracteres");
        }
    }
    public void Connect(int source, int target)
    {
        ValidateData(source, target);
        parent[Find(source)] = Find(target);
    }

    public bool Query(int source, int target)
    {
        ValidateData(source, target);
        return Find(source) == Find(target);
    }

    private int Find(int number)
    {
        if (parent[number] != number)
        {
            parent[number] = Find(parent[number]);
        }

        return parent[number];
    }
}
