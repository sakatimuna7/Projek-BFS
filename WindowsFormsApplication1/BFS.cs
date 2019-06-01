using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class _BFS : Form
    {
        int[] arr;
        public _BFS()
        {
            InitializeComponent();
            
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            Label[] lb = { lbl1, lbl2, lbl3, lbl4, lbl5, lbl6, lbl7, lbl8, lbl9, lbl10, lbl11, lbl12, lbl13, lbl14, lbl15, lbl16, lbl17, lbl18, lbl19, lbl20, lbl21, lbl22, lbl23, lbl24, lbl25, lbl26, lbl27, lbl28, lbl29, lbl30, lbl31, lbl31, lbl32, lbl33, lbl34, lbl35, lbl36, lbl37, lbl38, lbl39, lbl40, lbl41, lbl42, lbl43, lbl44, lbl45, lbl46, lbl47, lbl48, lbl49, lbl50, lbl51, lbl52, lbl53, lbl54, lbl55, lbl56, lbl57, lbl58, lbl59, lbl60, lbl61, lbl62, lbl63, lbl64, lbl65, lbl66, lbl67, lbl68, lbl69, lbl70, lbl71, lbl72, lbl73, lbl74, lbl75, lbl76, lbl77, lbl78, lbl79, lbl80 };
            for (int i = 0; i < lb.Length; i++)
            {
                lb[i].Text = "";
            }

        }

        private void btn_mulai_Click(object sender, EventArgs e)
        {
            main();
            timer1_Tick(sender, e);
            Label[] lb = { lbl1, lbl2, lbl3, lbl4, lbl5, lbl6, lbl7, lbl8, lbl9, lbl10, lbl11, lbl12, lbl13, lbl14, lbl15, lbl16, lbl17, lbl18, lbl19, lbl20, lbl21, lbl22, lbl23, lbl24, lbl25, lbl26, lbl27, lbl28, lbl29, lbl30, lbl31, lbl31, lbl32, lbl33, lbl34, lbl35, lbl36, lbl37, lbl38, lbl39, lbl40, lbl41, lbl42, lbl43, lbl44, lbl45, lbl46, lbl47, lbl48, lbl49, lbl50, lbl51, lbl52, lbl53, lbl54, lbl55, lbl56, lbl57, lbl58, lbl59, lbl60, lbl61, lbl62, lbl63, lbl64, lbl65, lbl66, lbl67, lbl68, lbl69, lbl70, lbl71, lbl72, lbl73, lbl74, lbl75, lbl76, lbl77, lbl78, lbl79, lbl80 };
            for (int i = 0; i < lb.Length; i++)
            {
                lb[i].Text = "" + arr[i];
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
        
        }
        // function

        void main()
        {
            // Create a graph given in the above diagram
            var g = new Graph();

            for (int i = 1; i <= 81; i++)
            {
                for (int j = 1; j <= 81; j++)
                {
                    g.AddEdge(i, j);
                }
            }
            arr = g.BFSWalkWithStartNode(1);
        }

        public class Graph
        {
            public int[] arr = new int[81];

            void pesan(string pesan)
            {
                MessageBox.Show(pesan);
            }
            public Graph()
            {
                Adj = new Dictionary<int, HashSet<int>>();
            }

            public Dictionary<int, HashSet<int>> Adj { get; private set; }

            public void AddEdge(int source, int target)
            {
                if (Adj.ContainsKey(source))
                {
                    try
                    {
                        Adj[source].Add(target);
                    }
                    catch
                    {
                        pesan("This edge already exists: " + source + " to " + target);
                    }
                }
                else
                {
                    var hs = new HashSet<int>();
                    hs.Add(target);
                    Adj.Add(source, hs);
                }
            }

            public int[] BFSWalkWithStartNode(int vertex)
            {
                int i = 0;
                var visited = new HashSet<int>();
                // Mark this node as visited
                visited.Add(vertex);
                // Queue for BFS
                var q = new Queue<int>();
                // Add this node to the queue
                q.Enqueue(vertex);

                while (q.Count > 0)
                {
                    var current = q.Dequeue();
                    arr[i] = current;
                    //Console.WriteLine(current);
                    // Only if the node has a any adj notes
                    if (Adj.ContainsKey(current))
                    {
                        // Iterate through UNVISITED nodes
                        foreach (int neighbour in Adj[current].Where(a => !visited.Contains(a)))
                        {
                            visited.Add(neighbour);
                            q.Enqueue(neighbour);
                        }
                    }
                    i++;
                }

                return arr;
            }
        }
    }
}
