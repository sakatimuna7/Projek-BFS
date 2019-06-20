using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.PowerPacks;

namespace WindowsFormsApplication1
{
    public partial class _BFS : Form
    {
        int[] arr;
        int i = 0;
        public _BFS()
        {
            InitializeComponent();
            
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            RectangleShape[] rf = {A8, B9, B8, A7, C9,B7,C8,A6,D9,C7,B6,D8,A5,E9,C6,D7,B5,E8,A4,
                                  F9,D6,C5,E7,B4,F8,A3,G9,D5,E6,C4,F7,B3,G8,A2,H9,E5,D4,F6,C3,G7,
                                  B2,H8,A1,I9,E4,F5,D3,G6,C2,H7,B1,I8,E3,F4,G5,D2,H6,C1,I7,F3,G4,E2,H5,D1,I6,G3,F2,H4,E1,I5,
                                  G2,H3,F1,I4,H2,G1,I3,H1,I2,I1};
            Label[] lb = { lbl1, lbl2, lbl3, lbl4, lbl5, lbl6, lbl7, lbl8, lbl9, lbl10, lbl11, lbl12, lbl13, lbl14, lbl15, lbl16, lbl17, lbl18, lbl19, lbl20, lbl21, lbl22, lbl23, lbl24, lbl25, lbl26, lbl27, lbl28, lbl29, lbl30, lbl31, lbl31, lbl32, lbl33, lbl34, lbl35, lbl36, lbl37, lbl38, lbl39, lbl40, lbl41, lbl42, lbl43, lbl44, lbl45, lbl46, lbl47, lbl48, lbl49, lbl50, lbl51, lbl52, lbl53, lbl54, lbl55, lbl56, lbl57, lbl58, lbl59, lbl60, lbl61, lbl62, lbl63, lbl64, lbl65, lbl66, lbl67, lbl68, lbl69, lbl70, lbl71, lbl72, lbl73, lbl74, lbl75, lbl76, lbl77, lbl78, lbl79, lbl80 };
            for (int i = 0; i < lb.Length; i++)
            {
                lb[i].Text = "";
                rf[i].BackStyle = BackStyle.Opaque;
            }
            
            
        }

        private void btn_mulai_Click(object sender, EventArgs e)
        {
            main();
            i = 0;
            _timer1.Start();            
        }
        private void btn_reset_Click(object sender, EventArgs e)
        {
            RectangleShape[] rf = {A8, B9, B8, A7, C9,B7,C8,A6,D9,C7,B6,D8,A5,E9,C6,D7,B5,E8,A4,
                                  F9,D6,C5,E7,B4,F8,A3,G9,D5,E6,C4,F7,B3,G8,A2,H9,E5,D4,F6,C3,G7,
                                  B2,H8,A1,I9,E4,F5,D3,G6,C2,H7,B1,I8,E3,F4,G5,D2,H6,C1,I7,F3,G4,E2,H5,D1,I6,G3,F2,H4,E1,I5,
                                  G2,H3,F1,I4,H2,G1,I3,H1,I2,I1};
            Label[] lb = { lbl1, lbl2, lbl3, lbl4, lbl5, lbl6, lbl7, lbl8, lbl9, lbl10, lbl11, lbl12, lbl13, lbl14, lbl15, lbl16, lbl17, lbl18, lbl19, lbl20, lbl21, lbl22, lbl23, lbl24, lbl25, lbl26, lbl27, lbl28, lbl29, lbl30, lbl31, lbl31, lbl32, lbl33, lbl34, lbl35, lbl36, lbl37, lbl38, lbl39, lbl40, lbl41, lbl42, lbl43, lbl44, lbl45, lbl46, lbl47, lbl48, lbl49, lbl50, lbl51, lbl52, lbl53, lbl54, lbl55, lbl56, lbl57, lbl58, lbl59, lbl60, lbl61, lbl62, lbl63, lbl64, lbl65, lbl66, lbl67, lbl68, lbl69, lbl70, lbl71, lbl72, lbl73, lbl74, lbl75, lbl76, lbl77, lbl78, lbl79, lbl80 };
            int i = 0;
            for (; i < rf.Length; i++)
            {
                lb[i].Text = "";
                rf[i].BackColor = Color.Transparent;
            }
            lb[i].Text = "";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Label[] lb = { lbl1, lbl2, lbl3, lbl4, lbl5, lbl6, lbl7, lbl8, lbl9, lbl10, lbl11, lbl12, lbl13, lbl14, lbl15, lbl16, lbl17, lbl18, lbl19, lbl20, lbl21, lbl22, lbl23, lbl24, lbl25, lbl26, lbl27, lbl28, lbl29, lbl30, lbl31, lbl32, lbl33, lbl34, lbl35, lbl36, lbl37, lbl38, lbl39, lbl40, lbl41, lbl42, lbl43, lbl44, lbl45, lbl46, lbl47, lbl48, lbl49, lbl50, lbl51, lbl52, lbl53, lbl54, lbl55, lbl56, lbl57, lbl58, lbl59, lbl60, lbl61, lbl62, lbl63, lbl64, lbl65, lbl66, lbl67, lbl68, lbl69, lbl70, lbl71, lbl72, lbl73, lbl74, lbl75, lbl76, lbl77, lbl78, lbl79, lbl80 };
            RectangleShape[] rf = {A8, B9, B8, A7, C9,B7,C8,A6,D9,C7,B6,D8,A5,E9,C6,D7,B5,E8,A4,
                                  F9,D6,C5,E7,B4,F8,A3,G9,D5,E6,C4,F7,B3,G8,A2,H9,E5,D4,F6,C3,G7,
                                  B2,H8,A1,I9,E4,F5,D3,G6,C2,H7,B1,I8,E3,F4,G5,D2,H6,C1,I7,F3,G4,E2,H5,D1,I6,G3,F2,H4,E1,I5,
                                  G2,H3,F1,I4,H2,G1,I3,H1,I2,I1};
            {
                lb[i].Text = "" + arr[i];
                lb[i].BackColor = Color.Blue;
                lb[i].ForeColor = Color.White;
                rf[i].BackColor = Color.Blue;
                if (i > 1)
                {
                    lb[i-2].BackColor = Color.Silver;
                    lb[i-2].ForeColor = Color.Gray;
                    rf[i - 2].BackColor = Color.Silver;
                }
            }
            i++;
            if (i == 80 || i > 80)
            {
                lb[i - 2].BackColor = Color.Silver;
                lb[i - 2].ForeColor = Color.Gray;
                lb[i-1].BackColor = Color.Silver;
                lb[i-1].ForeColor = Color.Gray;
                rf[i - 2].BackColor = Color.Silver;
                rf[i - 1].BackColor = Color.Silver;
                _timer1.Stop();
            }
        }

        // function

        void main()
        {
            // Create a graph given in the above diagram
            var g = new Graph();

            for (int i = 1; i <= 80; i++)
            {
                for (int j = 1; j <= 80; j++)
                {
                    g.AddEdge(i, j);
                }
            }
            arr = g.BFSWalkWithStartNode(1);
        }

        public class Graph
        {
            public int[] arr = new int[80];

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
