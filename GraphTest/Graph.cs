using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphTest
{
    class Graph
    {
        private const int NUM_VERTICES=18;
        private Vertex[] vertices;//върхове на графа
        private int[,] adjMatrix;//матрица на съседство
        private int numVerts;//текущ брой върхове
        public Graph()
        {
            vertices = new Vertex[NUM_VERTICES];
            adjMatrix = new int[NUM_VERTICES, NUM_VERTICES];
            numVerts = 0;
            for (int j = 0; j < NUM_VERTICES; j++)
            {
                for (int k = 0; k < NUM_VERTICES; k++)
                {
                    adjMatrix[j, k] = 0;
                }
            }
        }
        public bool addVertex(string label)
        {
            //добавя нов връх
            try
            {
                vertices[numVerts] = new Vertex(label);
                numVerts++;
                return true;
            }
            catch
            {
                return false;
            }
        }
        public void AddAdge (int start,int eend)
        {
            try
            {
                adjMatrix[start, eend] = 1;
            }
            catch { }
        }
        public bool HasEdge(int start, int eend)
        { 
            return  (adjMatrix[start,eend]==0)?false:true;
        }
        public string ShowVertex(int v)
        {
            return vertices[v].label;//името на върха
        }
        public string ShowMatrix()
        {
            //Изобразява матрицата на съседство
            if (numVerts == 0) return "";
            string s = "   |";
            for (int i = 0; i < numVerts; i++)
            {
                s += string.Format(" {0} |", ShowVertex(i));
            }
            s += "\n";
            for (int i = 0; i < numVerts; i++)
            {
                s += "===|";
            }
            s += "\n";
            for (int j = 0; j < numVerts; j++)
            {
                for (int k = 0; k < numVerts; k++)
                {
                    if (HasEdge(j, k))
                    {
                        s += " 1 |";
                    }
                    else
                    {
                        s += " 0 |";
                    }
                }
                s += "\n";
            }
            return s;
        }
        public void DelEdge(int start, int eend)
        {
            try
            {
                adjMatrix[start, eend] = 0;
            }
            catch { }
        }
        public bool DelVertex(int vert)
        {
            //изтрива върх с номер vert
            try
            {
                if (numVerts == 0) return true;
                if (vert != numVerts - 1)
                {
                    for (int j = vert; j < numVerts - 1; j++)
                    {
                        vertices[j] = vertices[j + 1];
                        MoveRow(j, numVerts);
                        MoveCol(j, numVerts-1);
                    }
                }
                numVerts--;
                return true;
            }
            catch { return false; }
        }
        private void MoveRow(int row, int length)
        {
            //изтрива ред от матрицата на съседство
            for (int col = 0; col < length; col++)
                adjMatrix[row, col] = adjMatrix[row + 1, col];
        }
        private void MoveCol(int col, int length)
        {
            //изтрива ред от матрицата на съседство
            for (int row = 0; row < length; row++)
                adjMatrix[row, col] = adjMatrix[row, col+1];
        }
        public void ClearGraph()
        {
            //изтрива всички възли
            for (int i = 0; i < NUM_VERTICES; i++)
                vertices[i] =null;
            numVerts=0;
            for (int j = 0; j < NUM_VERTICES; j++)
            {
                for (int k = 0; k < NUM_VERTICES; k++)
                {
                    adjMatrix[j, k] = 0;
                }
            }
        }
        public int Count()
        {
            return numVerts;
        }
        private int GetUnvisitedVertix(int v)
        {
            //връща индекс на непосетен връх
            for (int j = 0; j < numVerts; j++)
            {
                if ((adjMatrix[v, j] == 1) && (vertices[j].wasVisited == false))
                {
                    return j;
                }
            }
            return -1;
        }
        public string BreadthFirstSearch()
        {
            //Обхождане на граф е ширина - BFS
            Queue gQueue = new Queue();
            vertices[0].wasVisited = true;
            string s = ShowVertex(0) + " -> ";
            gQueue.Enqueue(0);
            int vParent, vChild;
            while (gQueue.Count > 0)
            {
                vParent = (int)gQueue.Dequeue();
                vChild = GetUnvisitedVertix(vParent);
                while (vChild != -1)
                {
                    vertices[vChild].wasVisited = true;
                    s += ShowVertex (vChild)+ " -> ";
                    gQueue.Enqueue(vChild);
                    vChild = GetUnvisitedVertix(vParent);
                }
                s += " |\n ";
                    
            }
            // Подготовка за следващо обхождане
            for (int j = 0; j < numVerts; j++)
                vertices[j].wasVisited = false; 
            return s;
        }
        public string DepthFirstSearch()
        {
            //Обхождане на граф е дълбочина - DFS
            vertices[0].wasVisited = true;
            string s = ShowVertex(0) + " -> ";
            Stack gStack = new Stack();
            gStack.Push(0);
            int v;
            while (gStack.Count > 0)
            {
                v = GetUnvisitedVertix((int)gStack.Peek());
                if (v == -1)
                {
                    gStack.Pop(); s += "|\n";
                }
                else
                {
                    vertices[v].wasVisited = true;
                    s += ShowVertex(v) + " -> ";
                    gStack.Push(v);
                }
            }
            // Подготовка за следващо обхождане
            for (int j = 0; j < numVerts; j++)
                vertices[j].wasVisited = false;
           return s;
        }
    }
    class Vertex{
        public bool wasVisited;
        public string label;
        public Vertex(string label)
        {
            this.label = label;
            wasVisited = false;
        }   
    } 
}
