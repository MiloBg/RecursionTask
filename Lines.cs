using System;

namespace RecursionTask
{
    public class Lines
    {
        // Props
        public int ID { get; set; }
        public string Text { get; set; }
        public int ParentID { get; set; }
        // Constructor
        public Lines(int iD, string text, int parentID)
        {
            ID = iD;
            Text = text;
            ParentID = parentID;
        }
        // Methods
        public override string ToString() {
            return "ID: " + ID + " Text: " + Text + " ParentID: " + ParentID;
        }
        public static void RecursiveMethod(List<Lines> nodes, int parent, int level) {
            String children = new String('-', level);
            foreach (Lines node in nodes)
                {
                    if (node.ParentID == parent) {
                    Console.WriteLine(children + node.Text);
                    RecursiveMethod(nodes, node.ID, level + 1);
                }
            }
        }
    }
}